using System;
using Microsoft.EntityFrameworkCore;

namespace DropDownMenu.Models
{
    public class Db: DbContext
    {
        const string dbConnectString = "Host=localhost;Database=nick;Username=postgres;Password=nickwill";

        public DbSet<Human> Humen { get; set; }
        public DbSet<AdmissionScript> AdmissionScripts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(dbConnectString);
    }
}