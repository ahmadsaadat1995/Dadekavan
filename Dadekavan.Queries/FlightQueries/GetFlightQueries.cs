using Dadekavan.Domain.Entity;
using MediatR;

namespace Dadekavan.Queries.FlightQueries
{
    public class GetFlightQueries : IRequest<Flight>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte AgencyId { get; set; }

    }
}
