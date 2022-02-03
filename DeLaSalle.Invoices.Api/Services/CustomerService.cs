using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Api.Services.Interfaces;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;

namespace DeLaSalle.Invoices.Api.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepositories _customerRepository;
    public CustomerService(ICustomerRepositories customerRepositories)
    {
        _customerRepository = customerRepositories;
        
    }
    public async Task<List<Customer>> GetAllAsync()
    {
        return await _customerRepository.GetAllAsync();
    }
}
