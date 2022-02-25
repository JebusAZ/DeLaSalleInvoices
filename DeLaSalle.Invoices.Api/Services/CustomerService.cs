using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Api.Services.Interface;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Repositories.Interface;

namespace DeLaSalle.Invoices.Api.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
        
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _customerRepository.DeleteAsync(id);
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        return await _customerRepository.GetAllAsync();
    }

    public async Task<Customer> GetCustomerbyIdAsync(int id)
    {
        return await _customerRepository.GetCustomerbyIdAsync(id);
    }

    public async Task<Customer> SaveAsync(Customer customer)
    {
        return await _customerRepository.SaveAsync(customer); 
    }

    public async Task<Customer> UpdateAsync(Customer customer)
    {
        return await _customerRepository.UpdateAsync(customer);
    }
}
