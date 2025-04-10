﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared
{
    public class AssignPieceToSpaceCommand
    {
        public int PieceId { get; set; }
        public int SpaceId { get; set; }
    }

    public class RemovePieceFromSpaceCommand
    {
        public int SpaceId { get; set; }
    }

    public class MovePieceToAnotherSpaceCommand
    {
        public int PieceId { get; set; }
        public int NewSpaceId { get; set; }
    }

    public partial class SharedService
    {
        public virtual async Task AssignPieceToSpace(AssignPieceToSpaceCommand cmd)
        {
            var space = await _dbContext.Space
                .FirstOrDefaultAsync(s => s.Id == cmd.SpaceId);

            if (space == null)
                throw new Exception("Spazio non trovato");

            space.PieceId = cmd.PieceId;

            await _dbContext.SaveChangesAsync();
        }

        public async Task RemovePieceFromSpace(RemovePieceFromSpaceCommand cmd)
        {
            var space = await _dbContext.Space
                .FirstOrDefaultAsync(s => s.Id == cmd.SpaceId);

            if (space == null)
                throw new Exception("Spazio non trovato");

            space.PieceId = 0; // Rimuove la relazione impostando il valore a 0 o null

            await _dbContext.SaveChangesAsync();
        }

        public async Task MovePieceToAnotherSpace(MovePieceToAnotherSpaceCommand cmd)
        {
            var currentSpace = await _dbContext.Space
                .FirstOrDefaultAsync(s => s.PieceId == cmd.PieceId);

            if (currentSpace != null)
            {
                currentSpace.PieceId = 0; // Rimuove il pezzo dallo spazio corrente
            }

            var newSpace = await _dbContext.Space
                .FirstOrDefaultAsync(s => s.Id == cmd.NewSpaceId);

            if (newSpace == null)
                throw new Exception("Nuovo spazio non trovato");

            newSpace.PieceId = cmd.PieceId;

            await _dbContext.SaveChangesAsync();
        }
    }
}
