using FastEndpoints;
using PoC1_FastEndpoints.Services;

namespace PoC1_FastEndpoints.Endpoints.Customers;

public class GetCustomers(ICustomerService customerService) : Endpoint<List<CustomerGetResponse>>
{
    public override void Configure()
    {
        Get("Customers");
        AllowAnonymous();
    }

    public override async Task HandleAsync(List<CustomerGetResponse> req, CancellationToken ct)
    {
        var customers = customerService.GetList();
        await SendAsync(customers, cancellation: ct);
    }
}