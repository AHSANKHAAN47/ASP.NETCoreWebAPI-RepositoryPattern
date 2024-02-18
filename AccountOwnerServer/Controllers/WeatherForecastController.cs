using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;
        private readonly ILoggerManager _logger;
        public WeatherForecastController(ILoggerManager logger,IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var domesticAccounts = _repositoryWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var owners = _repositoryWrapper.Owner.FindAll();
            return new string[] { "value1", "value2" };
        }
    }
}
