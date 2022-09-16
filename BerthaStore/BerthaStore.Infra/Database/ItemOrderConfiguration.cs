using BerthaStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaStore.Infra.Database
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.ToTable("ItemOrderTable");
            builder.HasKey(pk => pk.IdItemOrder);

            builder.Property(p => p.Quantity)
                .HasColumnType("INT");
            builder.Property(p => p.UnitaryPrice)
                .HasColumnType("DECIMAL(18, 2)");

            builder.HasOne(fk => fk.Product)
                .WithMany(fk => fk.ItensOrder)
                .HasForeignKey(fk => fk.IdProduct);
            builder.HasOne(fk => fk.Order)
                .WithMany(fk => fk.ItensOrder)
                .HasForeignKey(fk => fk.IdOrder);
        }
    }
}
