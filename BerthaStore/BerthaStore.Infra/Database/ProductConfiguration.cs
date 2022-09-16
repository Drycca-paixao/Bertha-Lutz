using BerthaStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaStore.Infra.Database
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("ProductTable");
            builder.HasKey(pk => pk.IdProduct);

            builder.Property(p => p.Name)
                .HasColumnType("VARCHAR(48)")
                .IsRequired();
            builder.Property(p => p.Description)
                .HasColumnType("VARCHAR(248)");
            builder.Property(p => p.Price)
                .HasColumnType("DECIMAL(18, 2)")
                .IsRequired();
            builder.Property(p => p.Storage)
                .HasColumnType("INT")
                .IsRequired();
            builder.Property(p => p.Created)
                .HasColumnType("DATETIME");
        }
    }
}
