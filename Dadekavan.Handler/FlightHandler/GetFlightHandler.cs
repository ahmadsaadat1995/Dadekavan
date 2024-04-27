using Dadekavan.Domain.Entity;
using Dadekavan.Domain.Repository;
using Dadekavan.Queries.FlightQueries;
using MediatR;

namespace Dadekavan.Handler.FlightHandler
{
    public class GetFlightHandler : IRequestHandler<GetFlightQueries, Flight>
    {
        private readonly IFlightReportRepository _flightReport;

        public GetFlightHandler(IFlightReportRepository flightReport)
        {
            _flightReport = flightReport;
        }

        public async Task<Flight> Handle(GetFlightQueries request, CancellationToken cancellationToken)
        {
            //return await _flightReport.GetFlightReportListAsync(request.EndDate,request.EndDate,request.AgencyId);
            throw new NotImplementedException();
        }
    }
}
