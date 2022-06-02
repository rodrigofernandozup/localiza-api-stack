
using {{project_name}}.Domain.Interfaces.Repositories;

namespace {{project_name}}.Application.CreateHelloWorld;

public class LoadCustomerHandler : IRequestHandler<LoadCustomerCommand, LoadCustomerResult>
{
    private readonly ILogger<LoadCustomerHandler> _logger;
    private readonly IMapper _mapper;
    private readonly ICustomerRepository _customerRepository;


    public LoadCustomerHandler(ILogger<LoadCustomerHandler> logger,
                                    IMapper mapper,
                                    ICustomerRepository customerRepository)
    {
        _logger = logger;
        _mapper = mapper;
        _customerRepository = customerRepository;
    }

    public async Task<LoadCustomerResult> Handle(LoadCustomerCommand request, CancellationToken cancellationToken)
    {
        _logger.LogDebug("Init Handle");
        try
        {
            var response = await _customerRepository.LoadAsync(request.Cpf);
            _logger.LogInformation("Customer Loaded.");
            return _mapper.Map<LoadCustomerResult>(response);

        }
        catch (System.Exception ex)
        {

            _logger.LogError(ex, ex.Message);
            return null;
        }
    }
}