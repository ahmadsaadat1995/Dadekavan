using Dadekavan.Domain.Repository;
using Dadekavan_.Repositories.FlightReport;
using Microsoft.Extensions.DependencyInjection;

namespace Dadekavan.EndPoint_ConsoleApp
{
    public class RegisterService
    {
        public  void RegisterServices()
        {
            var builder = new ServiceCollection();
            builder.AddScoped<IFlightReportRepository, FlightReportRepository>();
            builder.BuildServiceProvider();

        }
    }
}
