using Domain.Contexts;
using Domain.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repository;
using System.Data.Entity;

namespace Infrastructure.Repository
{
    public class PlayerRepository : BaseRepository, IPlayerRepository
    {

        public async Task<IEnumerable<Player>> GetAllPlayersAsync()
        {
            using (var context = DbContext())
            {
                var x = await context.Player.ToListAsync();
                return x;
            }
        }

        public async Task InsertPlayersAsync(IEnumerable<Player> players)
        {
            using (var context = DbContext())
            {
                context.Player.AddRange(players);
                await context.SaveChangesAsync();
            }
        }
    }
}
