using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contexts
{
    public partial class FootballStatsContext : DbContext
    {
        public FootballStatsContext(string connectionString)
        : base(connectionString) { }

        //Tables
        public DbSet<Player> Player { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties()
                        .Where(p => p.Name == "RowID")
                        .Configure(p => p.IsKey());
        }

    }
}
