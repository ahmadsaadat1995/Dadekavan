using System.ComponentModel.DataAnnotations;

namespace Dadekavan.Domain.Entity
{
    public class Flight
    {
        [Key]
        public int flight_id { get; set; }
        public int route_id { get; set; }
        public DateTime departure_time { get; set; }
        public DateTime arrival_time { get; set; }
        public byte airline_id { get; set; }
    }
}
