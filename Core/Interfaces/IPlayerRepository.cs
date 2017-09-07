using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAllPlayersAsync();
        Task<Dictionary<string, Player>> GetAllPlayersDictionaryAsync();
        Task InsertPlayersAsync(IEnumerable<Player> players);
    }
}
