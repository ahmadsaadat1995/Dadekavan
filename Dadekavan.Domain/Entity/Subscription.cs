using System.ComponentModel.DataAnnotations;

namespace Dadekavan.Domain.Entity
{
    public class Subscription
    {
        [Key]
        public byte agency_id { get; set; }
        public short origin_city_id { get; set; }
        public short destination_city_id { get; set; }
    }
}
