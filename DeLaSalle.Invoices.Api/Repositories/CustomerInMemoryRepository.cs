using DeLaSalle.Invoices.Api.Repositories.Interfaces;
using DeLaSalle.Invoices.Api.Services.Interfaces;
using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Repositories;

public class CustomerInMemoryRepository : ICustomerRepositories
{
    public async Task<List<Customer>> GetAllAsync()
    {
        var lst = new List<Customer>();
        lst.Add(new Customer{Id = 1,Name = "Customer"});

        return await Task.FromResult(lst);
    }
}