using Microsoft.EntityFrameworkCore;

namespace BerthaStore.Infra.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
