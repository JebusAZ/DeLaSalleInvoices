using Microsoft.AspNetCore.Mvc;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Responses;
using DeLaSalle.Invoices.Api.Services.Interface;

namespace DeLaSalle.Invoices.Api.Controllers;

[ApiController]

public class ErrorController : ControllerBase
{
    [Route("/api/error")]

    public IActionResult HandleError() => Problem();
}