using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PlayersUpdater
    {
        private JSONHelper _jsonHelper;
        private PlayerRepository _playerRepo;

        public PlayersUpdater()
        {
            _jsonHelper = new JSONHelper();
            _playerRepo = new PlayerRepository();
        }

        public async Task UpdatePlayers()
        {
            var json = _jsonHelper.GetPlayerJSONFromURL(
                "https://raw.githubusercontent.com/BurntSushi/nflgame/master/nflgame/players.json");

            var playersDict = JsonConvert.DeserializeObject<Dictionary<string, Player>>(json);

            var existingPlayersDict = await _playerRepo.GetAllPlayersDictionaryAsync();

            //this will insert new players
            foreach (var p in playersDict)
            {
                if (!existingPlayersDict.ContainsKey(p.Key))
                {
                    await _playerRepo.InsertPlayerAsync(p.Value);
                }
            }
        }

    }
}
