using DeLaSalle.Invoices.Api.Repositories.Interface;
using DeLaSalle.Invoices.Api.Services.Interface;
using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Repository;

public class CustomerInMemoryRepository : ICustomerRepository
{
    private readonly List<Customer> _customers;

    public CustomerInMemoryRepository()
    {
        _customers = new List<Customer>();
        
    }


    public async Task<bool> DeleteAsync(int id)
    {
        return await Task.FromResult(_customers.Remove(_customers.First(x => x.Id == id)));
        
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        return await Task.FromResult(_customers);
    }

    public async Task<Customer> SaveAsync(Customer customer)
    {
        int id = _customers.Count + 1;
        customer.Id= id;

        _customers.Add(customer);

        return await Task.FromResult(customer);

    }


    public async Task<Customer> GetCustomerbyIdAsync(int id)
    {
       return await Task.FromResult(_customers.FirstOrDefault(x => x.Id == id));
    }


    public async Task<Customer> UpdateAsync(Customer customer)
    {
        var index = _customers.FindIndex(x => x.Id ==customer.Id);
        if(index!= -1)
        {
            _customers[index] = customer;
        }

        return await Task.FromResult(customer);
    }
}