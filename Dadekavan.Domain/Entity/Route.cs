using System.ComponentModel.DataAnnotations;

namespace Dadekavan.Domain.Entity
{
    public class Route
    {
        [Key]
        public int route_id { get; set; }
        public short origin_city_id { get; set; }
        public short destination_city_id { get; set; }
        public DateTime departure_date { get; set; }

    }
}
