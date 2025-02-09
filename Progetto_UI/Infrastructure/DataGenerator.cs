using System;
using System.Linq;
using Progetto_UI.Services;
using Progetto_UI.Services.Shared;

namespace Progetto_UI.Infrastructure
{
    public class DataGenerator
    {
        public static void InitializeData(TemplateDbContext context)
        {
            if (context.Users.Any())
            {
                return;   // Data was already seeded
            }

            context.Users.AddRange(
                new User
                {
                    Id = Guid.Parse("3de6883f-9a0b-4667-aa53-0fbc52c4d300"), // Forced to specific Guid for tests
                    Email = "email1@test.it",
                    Password = "M0Cuk9OsrcS/rTLGf5SY6DUPqU2rGc1wwV2IL88GVGo=", // SHA-256 of text "Prova"
                    FirstName = "Nome1",
                    LastName = "Cognome1",
                    NickName = "Nickname1"
                },
                new User
                {
                    Id = Guid.Parse("a030ee81-31c7-47d0-9309-408cb5ac0ac7"), // Forced to specific Guid for tests
                    Email = "email2@test.it",
                    Password = "Uy6qvZV0iA2/drm4zACDLCCm7BE9aCKZVQ16bg80XiU=", // SHA-256 of text "Test"
                    FirstName = "Nome2",
                    LastName = "Cognome2",
                    NickName = "Nickname2"
                },
                new User
                {
                    Id = Guid.Parse("bfdef48b-c7ea-4227-8333-c635af267354"), // Forced to specific Guid for tests
                    Email = "mario.vialli@gmail.com",
                    Password = "Uy6qvZV0iA2/drm4zACDLCCm7BE9aCKZVQ16bg80XiU=", // SHA-256 of text "Test"
                    FirstName = "Mario",
                    LastName = "Vialli",
                    NickName = "Viama0"
                });

            if (!context.Warehouses.Any())
            {
                context.Warehouses.AddRange(
                    new Warehouse
                    {
                        WarehouseId = 1,
                        Name = "Warehouse1",
                        Capacity = 100
                    });                  
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        ProductId = 1,
                        Name = "Product1",
                        Description = "Description1"
                    },
                    new Product
                    {
                        ProductId = 2,
                        Name = "Product2",
                        Description = "Description2"
                    },
                    new Product
                    {
                        ProductId = 3,
                        Name = "Marchingegno",
                        Description = "Ingranaggi"
                    });
            }

            if (!context.Space.Any())
            {
                context.Space.AddRange(
                    new Space
                    {
                        SpaceId = 1,
                        WarehouseId = 1
                    },
                    new Space
                    {
                        SpaceId = 2,
                        WarehouseId = 1
                    });
            }

            context.SaveChanges();
        }
    }
}
