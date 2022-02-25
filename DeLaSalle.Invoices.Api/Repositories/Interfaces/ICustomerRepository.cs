using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Repositories.Interface;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAllAsync();
    Task<Customer> GetCustomerbyIdAsync(int id);
    Task<Customer> SaveAsync(Customer customer);
    Task<Customer> UpdateAsync(Customer customer);
    Task<bool> DeleteAsync(int id);
}

