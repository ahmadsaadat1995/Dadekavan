namespace Dadekavan.Domain
{
    public record ResponseFlightReportDto
    {
        public short origin_city_id { get; set; }
        public short destination_city_id { get; set; }
        public DateTime departure_time { get; set; }
        public DateTime arrival_time { get; set; }
        public byte airline_id { get; set; }
        public byte agency_id { get; set; }
    }
}
