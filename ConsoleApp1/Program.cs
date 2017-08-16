using Core.Models;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //crude entity mapping test
            PlayerRepository playerRepo = new PlayerRepository();

            List<Player> newPs = new List<Player>();

            var np = new Player();
            np.birthdate = "12/6/1986";
            np.college = "Orgeron";
            np.first_name = "LeGilbert";
            np.full_name = "LeGarrette Blount";
            np.gsis_id = "12345";
            np.gsis_name = "L.Bloun";
            np.height = "35";
            np.last_name = "Bluntz";
            np.profile_id = "34344";
            np.profile_url = "www.nope.com";
            np.weight = "654";
            np.years_pro = "45";

            newPs.Add(np);

            playerRepo.InsertPlayers(newPs);

            var players = playerRepo.GetAllPlayers();

            foreach (var x in players)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(x.full_name);
                Console.WriteLine(x.college);
                Console.WriteLine(x.profile_url);
                Console.WriteLine(x.RowID);
            }

            


        }
    }
}
