namespace Dadekavan.Domain
{
    public record ResultFlightDto
    {

        public DateTime startTime { get; set; }
        public DateTime EndTime { get; set; }
        public byte agency_id { get; set; }

    }
}
