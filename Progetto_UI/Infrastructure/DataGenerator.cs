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
                },
                new User
                {
                    Id = Guid.Parse("aea13c69-7edb-4332-bd3f-c141f1055a47"), // Forced to specific Guid for tests
                    Email = "a@a.it",
                    Password = "ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb", // SHA-256 of text "a"
                    FirstName = "a",
                    LastName = "a",
                    NickName = "a"
                });

            if (!context.Warehouse.Any())
            {
                context.Warehouse.AddRange(
                    new Warehouse
                    {
                        WarehouseId = 1,
                        Name = "Warehouse1"                        
                    });                  
            }

            if (!context.Piece.Any())
            {
                context.Piece.AddRange(
                    new Piece
                    {
                        Id = 1,
                        Name = "Product1",
                        Description = "Description1"
                    },
                    new Piece
                    {
                        Id = 2,
                        Name = "Product2",
                        Description = "Description2"
                    },
                    new Piece
                    {
                        Id = 3,
                        Name = "Marchingegno",
                        Description = "Ingranaggi"
                    },
                    new Piece
                    {
                        Id = 4,
                        Name = "Leva",
                        Description = "Ingranaggi"
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
