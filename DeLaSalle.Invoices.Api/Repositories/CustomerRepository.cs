using DeLaSalle.Invoices.Api.Repositories.Interface;
using DeLaSalle.Invoices.Api.Services.Interface;
using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Repository;

public class CustomerRepository : ICustomerRepository

{
    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetCustomerbyIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> SaveAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> UpdateAsync(Customer customer)
    {
        throw new NotImplementedException();
    }
}
