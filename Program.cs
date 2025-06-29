using FastEndpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PoC1_FastEndpoints.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddFastEndpoints();

builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();

app.UseFastEndpoints(config => { config.Endpoints.RoutePrefix = "api"; });

app.Run();