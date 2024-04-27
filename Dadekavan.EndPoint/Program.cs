using Dadekavan.Domain.Repository;
using Dadekavan.EntityFrameworkCore.DadekavanDbContextApplication;
using Dadekavan_.Repositories.FlightReport;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        #region StartTime
        DateTime StartTime;
        DateTime EndTime;
        byte AgencyId;
        Console.WriteLine("Plase Enter StartDate:");
        StartTime = DateTime.Parse(Console.ReadLine());
        CalculateFlights calculate = new();
        calculate.NewFlights(StartTime);
        #endregion

        #region EndTime
        Console.WriteLine("Plase Enter  EndDate:");
        EndTime = DateTime.Parse(Console.ReadLine());
        calculate.DiscontinuedFlights(EndTime);
        #endregion

        #region AgencyId
        Console.WriteLine("Plase Enter  AgencyId:");
        AgencyId = byte.Parse(Console.ReadLine());
        #endregion

        #region configureService
        services.AddScoped<IFlightReportRepository, FlightReportRepository>();
        services.AddDbContext<DadekavanDbContext>();
        var serviceProvider = services.BuildServiceProvider();

        var flightReport = serviceProvider.GetRequiredService<IFlightReportRepository>();
        #endregion

        //call GetFlightReportListAsync
        flightReport.GetFlightReportListAsync(StartTime, EndTime, AgencyId);

        //System.IO.File.WriteAllLines("C:/outFile.csv", flightReport.ToArray());



    }
}