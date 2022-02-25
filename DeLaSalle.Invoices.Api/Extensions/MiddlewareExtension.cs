using System.Net;
using DeLaSalle.Invoices.Api.Responses;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DeLaSalle.Invoices.Api.MiddlwareExtension;

public static class MiddlwareException
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder app)   
    {
        app.UseExceptionHandler((appError) => {
            appError.Run(async context => {

                context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
                context.Response.ContentType="aplication/json";


                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null)
                {
                    var response = new Response<string>();

                    response.Errors.Add(contextFeature.Error.Message);

                    await context.Response.WriteAsJsonAsync(response);

                }

            });
        });
    }
}
