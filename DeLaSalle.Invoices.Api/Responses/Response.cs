using DeLaSalle.Invoices.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace DeLaSalle.Invoices.Api.Responses;

public class Response<T>
{
    public T Data {get;set;}

    public List<string> Errors {get;set;} = new List<string>();

    public string Message{get;set;}
    
}
