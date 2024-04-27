using Dadekavan.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dadekavan.EntityFrameworkCore.OnConfigure
{
    internal class SubscriptionConfigure : IEntityTypeConfiguration<Subscription>
    {
        #region SubscriptionConfigure   
        
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasKey(it => it.agency_id);
            builder.Property(it => it.origin_city_id).HasColumnType("short");
            builder.Property(it => it.destination_city_id).HasColumnType("short");
            builder.HasIndex(it => it.agency_id).IsUnique().HasName("INDEX-Subscription");
        }
        #endregion
    }
}
