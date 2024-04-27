namespace Dadekavan.Domain.Repository
{
    public interface IFlightReportRepository
    {
        //Task GetFlightReportListAsync(ResultFlightDto input);
        Task GetFlightReportListAsync(DateTime startTime, DateTime EndTime, byte agency_id);
    }
}
