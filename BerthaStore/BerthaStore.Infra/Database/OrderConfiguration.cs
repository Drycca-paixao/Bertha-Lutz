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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(pk => pk.IdOrder); //Coluna Id do Pedido

            builder.Property(p => p.PaymentType) //Coluna Tipo de Pagamento
                .HasColumnType("VARCHAR(24)")
                .IsRequired();
            builder.Property(p => p.ShippingDate) //Coluna Data de Despacho
                .HasColumnType("DATETIME");
            builder.Property(p => p.TotalPrice) //Coluna Preço Total
                .HasColumnType("DECIMAL(18, 2)");
            builder.Property(p => p.Created) //Coluna Data de Criação do Pedido
                .HasColumnType("DATETIME");
            builder.Property(p => p.Status) //Coluna Status do Pedido
                .HasColumnType("VARCHAR(24)");

            builder.HasOne(fk => fk.Client) //Coluna Id Cliente
                .WithMany(fk => fk.Orders)
                .HasForeignKey(fk => fk.IdClient);
        }
    }
}
