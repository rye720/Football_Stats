using Core.Contexts;
using Core.Models;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PlayerRepository : BaseRepository, IPlayerRepository
    {

        public IEnumerable<Player> GetAllPlayers()
        {
            var context = DbContext();
            return context.Player.ToList();
        }

        public async Task InsertPlayers(IEnumerable<Player> players)
        {
            using (var context = DbContext())
            {
                context.Player.AddRange(players);
                await context.SaveChangesAsync();
            }
        }
    }
}
