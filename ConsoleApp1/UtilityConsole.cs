using Domain.Models;
using Infrastructure.Repository;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;

namespace ConsoleApp1
{
    class UtilityConsole
    {
        static void Main(string[] args)
        {

            //crude entity mapping test
            PlayerRepository playerRepo = new PlayerRepository();

            List<Player> newPs = new List<Player>();

            //var np = new Player();
            //np.birthdate = "12/6/1986";
            //np.college = "Orgeron";
            //np.first_name = "LeGilbert";
            //np.full_name = "LeGarrette Blount";
            //np.gsis_id = "12345";
            //np.gsis_name = "L.Bloun";
            //np.height = "35";
            //np.last_name = "Bluntz";
            //np.profile_id = "34344";
            //np.profile_url = "www.nope.com";
            //np.weight = "654";
            //np.years_pro = "45";

            //var np2 = new Player();
            //np2.birthdate = "12/7/1983";
            //np2.college = "Louisville";
            //np2.first_name = "Guy";
            //np2.full_name = "Ville";
            //np2.gsis_id = "12346";
            //np2.gsis_name = "LvilleMans";
            //np2.height = "32";
            //np2.last_name = "w00t";
            //np2.profile_id = "34346";
            //np2.profile_url = "www.nopeagain.com";
            //np2.weight = "236";
            //np2.years_pro = "69";

            //newPs.Add(np);
            //newPs.Add(np2);

            //Task.Run(() => playerRepo.InsertPlayersAsync(newPs));

            //var players = playerRepo.GetAllPlayersAsync();

            //foreach (var x in players.Result)
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine(x.full_name);
            //    Console.WriteLine(x.college);
            //    Console.WriteLine(x.profile_url);
            //    Console.WriteLine(x.RowID);
            //}

            PlayersUpdater updater = new PlayersUpdater();

            //Task.Run(() => updater.UpdatePlayers());

            updater.UpdatePlayers();
        }
    }
}
