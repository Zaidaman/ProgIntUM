using System;
using System.Linq;
using Progetto_UI.Services;
using Progetto_UI.Services.Shared;
using Progetto_UI.Services.Shared.Organization;

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
                    Email = "email3@test.it",
                    Password = "Uy6qvZV0iA2/drm4zACDLCCm7BE9aCKZVQ16bg80XiU=", // SHA-256 of text "Test"
                    FirstName = "Nome3",
                    LastName = "Cognome3",
                    NickName = "Nickname3"
                });

            if (!context.Warehouses.Any())
            {
                context.Warehouses.AddRange(
                    new Warehouse
                    {
                        Id = 1,
                        Name = "Warehouse1",
                        Capacity = 100
                    },
                    new Warehouse
                    {
                        Id = 2,
                        Name = "Warehouse2",
                        Capacity = 200
                    });
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Id = 1,
                        Name = "Product1",
                        Description = "Description1"
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Product2",
                        Description = "Description2"
                    });
            }

            if (!context.Space.Any())
            {
                context.Space.AddRange(
                    new Space
                    {
                        Id = 1,
                        WarehouseId = 1
                    },
                    new Space
                    {
                        Id = 2,
                        WarehouseId = 1
                    });
            }

            context.SaveChanges();
        }
    }
}
