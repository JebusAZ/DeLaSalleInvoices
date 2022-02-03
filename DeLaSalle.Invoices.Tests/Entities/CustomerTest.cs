using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;
using Xunit;

namespace DeLaSalle.Invoices.Tests.Entities;

public class CustomerTest
{
    [Fact]
    public void Name_WhenSetNameValue_ReturnsSameValue()
    {
        //AAA 
        var expected = "DeLaSalle Oaxaca";
        var sut = new Customer();
        //Arrange

        //Act

        sut.Name = expected;
        var result = sut.Name;

        //Assert       
        Assert.Equal(expected,result);     
    }
}
