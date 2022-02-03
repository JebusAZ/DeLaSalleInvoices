using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Repositories.Interfaces;

public interface ICustomerRepositories
{
    Task<List<Customer>> GetAllAsync();
}

