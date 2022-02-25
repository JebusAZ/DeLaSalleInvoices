using Microsoft.AspNetCore.Mvc;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Responses;
using DeLaSalle.Invoices.Api.Services.Interface;

namespace DeLaSalle.Invoices.Api.Controllers;

[ApiController]

public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    [Route("api/[controller]")]
    public async Task<ActionResult<Response<IEnumerable<Customer>>>> GetAll()
    {
        var response = new Response<IEnumerable<Customer>>();
        var customers = await _customerService.GetAllAsync();

        response.Data = customers;


        var x= 0;
        var l = 10/x;

        return Ok(response);
    }

    [HttpGet]
    [Route("api/[controller]/{id}")]
    public async Task<ActionResult<Response<Customer>>> GetById(int id)
    {
        var response = new Response<Customer>();
        var customer = await _customerService.GetCustomerbyIdAsync(id);

        if (customer == null)
        {
            response.Message="Customer not found";
            response.Errors.Add("The customer id provider was not found");

            return NotFound(response);
        }

        response.Data = customer;

        return Ok(response);
    }







    [HttpPost]
    [Route("api/[controller]")]
    public async Task<ActionResult<Response<Customer>>> Save([FromBody] Customer customer)
    {
        
        var response = new Response<Customer>();
        customer = await _customerService.SaveAsync(customer);
        response.Data=customer;

        return Created("api/customer/"+customer.Id,customer);

    }



    [HttpPut]
    [Route("api/[controller]")]
    public async Task<ActionResult<Response<Customer>>> Update([FromBody] Customer customer)
    {
        var response = new Response<Customer>();
        customer = await _customerService.UpdateAsync(customer);
        response.Data = customer;

        return Ok(response);

    }

    [HttpDelete]
    [Route("api/[controller]/{id}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        response.Data = await _customerService.DeleteAsync(id);
        

        return Ok(response);

    }
}
