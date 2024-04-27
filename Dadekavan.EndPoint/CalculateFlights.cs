
public class CalculateFlights
{

    public DateTime NewFlights(DateTime BeforesevenDaysAgo)
    {
        BeforesevenDaysAgo.AddDays(-7);
        Console.WriteLine("NewFlights At: " + BeforesevenDaysAgo);
        return BeforesevenDaysAgo;
    }

    public DateTime DiscontinuedFlights(DateTime AftersevenDaysAgo)
    {
        AftersevenDaysAgo.AddDays(+7).AddMinutes(+30).AddMinutes(-30);
        Console.WriteLine("DiscontinuedFlights At :" + AftersevenDaysAgo);
        return AftersevenDaysAgo;
    }

}