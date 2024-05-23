using Microsoft.EntityFrameworkCore;
using pr29savichev.Classes.Common;
using pr29savichev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr29savichev.Classes
{
    public class ClubContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
