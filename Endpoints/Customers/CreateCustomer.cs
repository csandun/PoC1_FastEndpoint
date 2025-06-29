using FastEndpoints;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace PoC1_FastEndpoints.Endpoints.Customers;

public class CreateCustomer(ILogger<CreateCustomer> logger) : Endpoint<CreateCustomerRequest, CreateCustomerResponse>
{
    public override void Configure()
    {
        Post("Customers");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateCustomerRequest req, CancellationToken ct)
    {
        logger.LogInformation("Creating customer with Name: {Name}, Email: {Email}", req.Name, req.Email);
        await SendAsync(new CreateCustomerResponse
        {
            Id = new Random().Next(1, 1000)
        }, StatusCodes.Status201Created, ct);
    }
}

public class CreateCustomerRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class CreateCustomerResponse
{
    public int Id { get; set; }
}