using {{project_name}}.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using StackSpot.Database.DynamoDB;

namespace {{project_name}}.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private IDynamoDB _dynamoDB;
    ILogger<CustomerRepository> _logger;
    public CustomerRepository(IDynamoDB dynamoDB, ILogger<CustomerRepository> logger)
    {
        _dynamoDB = dynamoDB;
        _logger = logger;
    }
    public async Task<{{project_name}}.Domain.Customer> LoadAsync(string cpf)
    {
        try
        {
            _logger.LogInformation("Loading data from customer.");
            var customer = await _dynamoDB.LoadAsync<{{project_name}}.Infrastructure.Customer>(cpf);
            return new Domain.Customer(customer?.Id, customer?.City, customer?.Name);
        }
        catch (System.Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }
}
