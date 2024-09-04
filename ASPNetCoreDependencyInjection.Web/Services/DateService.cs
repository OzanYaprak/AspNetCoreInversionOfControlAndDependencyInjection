using ASPNetCoreDependencyInjection.Web.Interfaces;

namespace ASPNetCoreDependencyInjection.Web.Services
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;

            _logger.LogWarning("DateService Constructor Girdi");
        }

        public DateTime GetDateTime {  get; } = DateTime.Now;
    }
}
