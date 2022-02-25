using DeLaSalle.Invoices.Api.Repository;
using DeLaSalle.Invoices.Api.Repositories.Interface;
using DeLaSalle.Invoices.Api.Services;
using DeLaSalle.Invoices.Api.Services.Interface;

using DeLaSalle.Invoices.Api.MiddlwareExtension;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddSingleton<ICustomerRepository,CustomerInMemoryRepository>();;

builder.Services.AddScoped<ICustomerService,CustomerService>();
builder.Services.AddSingleton<ICustomerRepository,CustomerInMemoryRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseExceptionHandler("/api/error");

app.ConfigureExceptionHandler();

app.UseAuthorization();

app.MapControllers();

app.Run();
