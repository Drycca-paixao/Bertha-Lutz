using BerthaStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Database
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.ToTable("ItemOrder");
            builder.HasKey(pk => pk.IdItemOrder);

            builder.Property(p => p.Quantity)
                .HasColumnType("INT");
            builder.Property(p => p.UnitaryPrice)
                .HasColumnType("DECIMAL(18, 2)");

            builder.HasOne(fk => fk.Order)
                .WithMany(fk => fk.ItemOrders)
                .HasForeignKey(fk => fk.IdOrder);

            builder.HasOne(fk => fk.Product)
                .WithMany(fk => fk.ItemOrders)
                .HasForeignKey(fk => fk.IdProduct);
        }
    }
}
