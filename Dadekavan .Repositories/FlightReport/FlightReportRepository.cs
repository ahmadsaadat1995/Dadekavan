using Dadekavan.Domain.Repository;
using Dadekavan.EntityFrameworkCore.DadekavanDbContextApplication;

namespace Dadekavan_.Repositories.FlightReport
{
    public class FlightReportRepository : IFlightReportRepository
    {
        private readonly DadekavanDbContext _dbContext;

        public FlightReportRepository(DadekavanDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task GetFlightReportListAsync(DateTime startTime, DateTime EndTime, byte agency_id)
        {

            //join flights,routes,subscriptions
            var result = (from sub in _dbContext.Subscriptions
                          from route in _dbContext.Routes
                          from fli in _dbContext.Flights
                          where sub.origin_city_id == route.origin_city_id
                          where fli.route_id == route.route_id
                          where sub.agency_id == agency_id
                          where fli.departure_time == EndTime
                          where fli.arrival_time == startTime
                          select new
                          {
                              OriginCityId = route.origin_city_id,
                              DestinationCityId = route.destination_city_id,
                              DepartureTime = fli.departure_time,
                              ArrivalTime = fli.arrival_time,
                              AirlineId = fli.airline_id,
                              Agencyid = sub.agency_id,
                          }).ToList();

            return Task.CompletedTask;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"origin_city_id:{item.OriginCityId} DestinationCityId:{item.DestinationCityId} DepartureTime:{item.DepartureTime} ArrivalTime:{item.ArrivalTime} AirlineId:{item.AirlineId}");
            //}

        }
    }
}
