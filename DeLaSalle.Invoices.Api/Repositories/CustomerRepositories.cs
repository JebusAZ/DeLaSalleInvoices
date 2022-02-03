using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;
using DeLaSalle.Invoices.Api.Services.Interfaces;
using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Repositories;

public class CustomerRepositories : ICustomerRepositories

{
    public async Task<List<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
