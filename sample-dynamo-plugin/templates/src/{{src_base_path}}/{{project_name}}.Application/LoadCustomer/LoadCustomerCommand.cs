namespace {{project_name}}.Application.CreateHelloWorld;

public class LoadCustomerCommand : IRequest<LoadCustomerResult>
{
    public string Cpf { get; set; } = default!;
}