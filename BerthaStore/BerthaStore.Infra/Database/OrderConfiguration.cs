using BerthaStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaStore.Infra.Database
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("OrderTable");
            builder.HasKey(pk => pk.IdOrder);

            builder.Property(p => p.PaymentType)
                .HasColumnType("VARCHAR(24)")
                .IsRequired();
            builder.Property(p => p.ShippingDate)
                .HasColumnType("DATETIME");
            builder.Property(p => p.TotalPrice)
                .HasColumnType("DECIMAL(18, 2)");
            builder.Property(p => p.Created)
                .HasColumnType("DATETIME");
            builder.Property(p => p.Status)
                .HasColumnType("VARCHAR(24)");

            builder.HasOne(fk => fk.Client)
                .WithMany(fk => fk.Orders)
                .HasForeignKey(fk => fk.IdClient);
        }
    }
}
