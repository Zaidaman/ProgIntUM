using System;
using Microsoft.EntityFrameworkCore;
using Progetto_UI.Infrastructure;
using Progetto_UI.Services.Shared;
using System.Collections.Generic;

namespace Progetto_UI.Services
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(Environment.SpecialFolder.LocalApplicationData);
        }
    }

    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {
            var folder = Environment.CurrentDirectory;
            DbPath = System.IO.Path.Join(folder, "databaseIUM.db");
        }

        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Space> Space { get; set; }
        public DbSet<User> Users { get; set; }
        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
