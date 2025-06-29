using FastEndpoints;
using PoC1_FastEndpoints.Models;
using PoC1_FastEndpoints.Services;

namespace PoC1_FastEndpoints.Endpoints.Customers;

public class CustomerById(ICustomerService customerService) : Endpoint<IdRequest, CustomerGetResponse>
{
    public override void Configure()
    {
        Get("Customers/{id}");
        AllowAnonymous();
        Throttle(2, 60); // Limit to 2 requests per minute
    }

    public override async Task HandleAsync(IdRequest id, CancellationToken ct)
    {
        var customer = customerService.GetById(id.Id);
        if (customer is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        await SendAsync(new CustomerGetResponse
        {
            Id = customer?.Id ?? 0,
            Name = customer?.Name,
            Email = customer?.Email
        }, cancellation: ct);
    }
}

public class CustomerGetResponse
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}