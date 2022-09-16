using BerthaStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BerthaStore.Infra.Database
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("ClientTable");
            builder.HasKey(pk => pk.IdClient);

            builder.Property(p => p.Name)
                .HasColumnType("VARCHAR(48)")
                .IsRequired();
            builder.Property(p => p.Email)
                .HasColumnType("VARCHAR(48)")
                .IsRequired();
            builder.Property(p => p.Cpf)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();
            builder.Property(p => p.Password)
                .HasColumnType("CHAR(60)")
                .IsRequired();
            builder.Property(p => p.Created)
                .HasColumnType("DATETIME");
        }
    }
}
