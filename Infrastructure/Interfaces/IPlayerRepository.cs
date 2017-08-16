using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAllPlayers();
        Task InsertPlayers(IEnumerable<Player> players);
    }
}
