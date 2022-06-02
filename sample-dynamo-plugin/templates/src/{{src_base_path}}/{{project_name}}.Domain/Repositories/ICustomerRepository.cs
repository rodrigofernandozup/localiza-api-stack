namespace {{project_name}}.Domain.Interfaces.Repositories;

public interface ICustomerRepository
{
    Task<Customer> LoadAsync(string cpf);
}
