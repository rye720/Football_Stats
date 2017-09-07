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
            // async testing
            MainAsync(args).Wait();

        }

        static async Task MainAsync(string[] args)
        {
            PlayersUpdater updater = new PlayersUpdater();

            await updater.UpdatePlayers();
        }
    }
}
