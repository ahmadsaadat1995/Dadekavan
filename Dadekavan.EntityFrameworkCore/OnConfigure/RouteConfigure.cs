using Dadekavan.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace Dadekavan.EntityFrameworkCore.OnConfigure
{
    internal class RouteConfigure : IEntityTypeConfiguration<Route>
    {
        #region RouteConfigure

        public void Configure(EntityTypeBuilder<Route> builder)
        {
          
            builder.HasKey(it => it.route_id);
            builder.Property(it => it.origin_city_id).HasColumnType("short");
            builder.Property(it => it.destination_city_id).HasColumnType("short");
            builder.Property(it => it.departure_date).HasDefaultValue(DateTime.Now);
            builder.HasIndex(it=> it.route_id).IsUnique().HasName("INDEX-ROUTEID");
        }
        #endregion
    }
}
