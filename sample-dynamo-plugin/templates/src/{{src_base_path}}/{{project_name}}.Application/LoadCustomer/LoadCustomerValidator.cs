namespace {{project_name}}.Application.CreateHelloWorld;

public class LoadCustomerValidator : AbstractValidator<LoadCustomerCommand>
{
    public LoadCustomerValidator()
    {
        RuleFor(command => command.Cpf)
        .NotNull()
        .NotEmpty();
    }
}