﻿using Domain.Contexts;
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
                return await context.Player.ToListAsync();
            }
        }

        // savechangesasync not working??
        public async Task InsertPlayersAsync(IEnumerable<Player> players)
        {
            using (var context = DbContext())
            {
                foreach(var p in players)
                {
                    context.Player.Add(p);
                }

                context.SaveChanges();
            }
        }

        public async Task InsertPlayerAsync(Player player)
        {
            using (var context = DbContext())
            {
                context.Player.Add(player);
                await context.SaveChangesAsync();
            }
        }
    }
}
