using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Responses;
using DeLaSalle.Invoices.Api.Services.Interfaces;

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

        return Ok(response);



        /*var response = new Response<IEnumerable<Customer>>();
        var lst = new List<Customer>();
        var customer =  new Customer {Id = 1};

        lst.Add(customer);

        response.Data = lst;

        return response; 
        */
    }
}
