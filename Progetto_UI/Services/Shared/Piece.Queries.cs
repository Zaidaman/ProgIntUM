using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared
{
    public class CreatePieceCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class DeletePieceCommand
    {
        public int PieceId { get; set; }
    }

    public partial class SharedService
    {
        public async Task<int> CreatePieceAsync(CreatePieceCommand cmd)
        {
            var piece = new Piece
            {
                Name = cmd.Name,
                Description = cmd.Description
            };

            _dbContext.Piece.Add(piece);
            await _dbContext.SaveChangesAsync();

            return piece.Id; // Ritorniamo l'ID generato dal DB
        }

        public async Task DeletePieceAsync(DeletePieceCommand cmd)
        {
            var piece = await _dbContext.Piece
                .FirstOrDefaultAsync(p => p.Id == cmd.PieceId);

            if (piece == null)
                throw new Exception("Pezzo non trovato.");

            _dbContext.Piece.Remove(piece);
            await _dbContext.SaveChangesAsync();
        }
    }
}
