using Microsoft.EntityFrameworkCore;
using Progetto_UI.Infrastructure;
using Progetto_UI.Services.Shared;
using Progetto_UI.Services.Shared.Organization;

namespace Progetto_UI.Services
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext()
        {
        }

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {
            DataGenerator.InitializeData(this);

        }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Space> Space { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
