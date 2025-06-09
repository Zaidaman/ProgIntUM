using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Progetto_UI.Services.Shared
{
    public class FindPieceByIdQuery
    {
        public int PieceId { get; set; }
    }

    public class FindPieceByIdDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SpaceId { get; set; }
    }

    public class RemovePieceFromSpaceQuery
    {
        public int SpaceId { get; set; }
    }

    public class SpaceWithPieceDTO
    {
        public int SpaceId { get; set; }
        public int? PieceId { get; set; }
    }

    public partial class SharedService
    {
        public async Task<FindPieceByIdDTO> Query(FindPieceByIdQuery qry)
        {
            return await _dbContext.Piece
                .Where(p => p.Id == qry.PieceId)
                .Select(p => new FindPieceByIdDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    SpaceId = _dbContext.Space
                        .Where(s => s.PieceId == p.Id)
                        .Select(s => s.Id)
                        .FirstOrDefault()
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<SpaceWithPieceDTO>> QueryAllSpacesWithPiece()
        {
            return await _dbContext.Space
                .Select(s => new SpaceWithPieceDTO
                {
                    SpaceId = s.Id,
                    PieceId = s.PieceId
                })
                .ToListAsync();
        }
    }
}
