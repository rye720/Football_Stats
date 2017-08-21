using Domain.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class BaseRepository
    {
        //magic connection string for now

        private static string connectionString = "Data Source=RY3SBABY;Initial Catalog=FootballStatsProj;Integrated Security=True";

        protected FootballStatsContext DbContext()
        {
            return new FootballStatsContext(connectionString);
        }
    }
}
