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
            //configure unity at some point
            _jsonHelper = new JSONHelper();
            _playerRepo = new PlayerRepository();
        }

        public async Task UpdatePlayers()
        {
            var json = _jsonHelper.GetPlayerJSONFromURL(
                "https://raw.githubusercontent.com/BurntSushi/nflgame/master/nflgame/players.json");

            var playersDict = JsonConvert.DeserializeObject<Dictionary<string, Player>>(json);

            var playersList = playersDict.Values.ToList();

            await _playerRepo.InsertPlayersAsync(playersList);
        }
    }
}
