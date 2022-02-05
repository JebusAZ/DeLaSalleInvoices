using DeLaSalle.Invoices.Api.Services;
using DeLaSalle.Invoices.Entities;
using Xunit;
using System.Collections.Generic;
using Moq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;

namespace DeLaSalle.Invoices.Tests.ApiServices;

public class CustomerServiceTest
{
    [Fact]
    public async Task GetAllAsync_WhenGetList_ReturnList()
    //arrange
    {

        var expected = new List<Customer>{
            new Customer{Id =1, Name = "Customer 1"},
            new Customer{Id =2, Name = "Customer 2"}


    };
    var mock = new Mock<ICustomerRepositories>();

    mock.Setup(m=> m.GetAllAsync()).Returns(Task.FromResult(expected));

    var sut = new CustomerService(mock.Object);

    //act
    var result = await sut.GetAllAsync();

    //assert

    Assert.Equal(expected,result);
        
    }


}

    