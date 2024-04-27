using Dadekavan.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Dadekavan.EntityFrameworkCore.OnConfigure
{

    #region FlightConfigure


    internal class FlightConfigure : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(it => it.flight_id);
            builder.Property(it => it.departure_time).HasDefaultValue(DateTime.Now);
            builder.Property(it => it.arrival_time).HasDefaultValue(DateTime.Now);
            builder.Property(it => it.airline_id).HasColumnType("byte");
            builder.HasIndex(it => it.flight_id).IsUnique().HasName("INDEX-FLIGHTIS");
        }
    }
    #endregion
}
