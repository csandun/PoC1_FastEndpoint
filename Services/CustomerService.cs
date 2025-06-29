namespace PoC1_FastEndpoints.Services;

public interface ICustomerService
{
    Customer? GetById(int id);
    List<Customer> GetList();
}

public class CustomerService : ICustomerService
{
    private static readonly List<Customer> _customers = new()
    {
        new Customer { Id = 1, Name = "Alice", Email = "alice@example.com" },
        new Customer { Id = 2, Name = "Bob", Email = "bob@example.com" },
        new Customer { Id = 3, Name = "Charlie", Email = "charlie@example.com" }
    };

    public Customer? GetById(int id)
    {
        return _customers.FirstOrDefault(c => c.Id == id);
    }

    public List<Customer> GetList()
    {
        return _customers;
    }
}