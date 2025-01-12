using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared
{
    public class AddProductToSpaceCommand
    {
        public Int32 ProductId { get; set; }
        public Int32 SpaceId { get; set; }
    }

    public class MoveProductCommand
    {
        public Int32 ProductId { get; set; }
        public Int32 NewSpaceId { get; set; }
    }

    public class RemoveProductFromSpaceCommand
    {
        public Int32 ProductId { get; set; }
    }

    public partial class SharedService
    {
        /// <summary>
        /// Adds a product to a space
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public async Task Handle(AddProductToSpaceCommand cmd)
        {
            var space = await _dbContext.Space
                .Where(x => x.SpaceId == cmd.SpaceId)
                .FirstOrDefaultAsync();

            if (space == null)
            {
                throw new Exception("Space not found");
            }
            space.ProductId = cmd.ProductId;

            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Moves a product to a new space
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public async Task Handle(MoveProductCommand cmd)
        {
            var space = await _dbContext.Space
                .Where(x => x.ProductId == cmd.ProductId)
                .FirstOrDefaultAsync();

            if (space == null)
            {
                throw new Exception("Product not found in any space");
            }

            space.ProductId = 0; // Remove product from current space

            var newSpace = await _dbContext.Space
                .Where(x => x.SpaceId == cmd.NewSpaceId)
                .FirstOrDefaultAsync();

            if (newSpace == null)
            {
                throw new Exception("New space not found");
            }

            newSpace.ProductId = cmd.ProductId;

            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Removes a product from a space
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public async Task Handle(RemoveProductFromSpaceCommand cmd)
        {
            var space = await _dbContext.Space
                .Where(x => x.ProductId == cmd.ProductId)
                .FirstOrDefaultAsync();

            if (space == null)
            {
                throw new Exception("Product not found in any space");
            }

            space.ProductId = 0; // Remove product from space

            await _dbContext.SaveChangesAsync();
        }
    }
}
