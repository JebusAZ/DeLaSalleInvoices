using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Services.Interfaces;

public interface ICustomerService
{
    Task<List<Customer>> GetAllAsync();
}

