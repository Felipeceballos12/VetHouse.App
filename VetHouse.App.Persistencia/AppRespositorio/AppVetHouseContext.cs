using Microsoft.EntityFrameworkCore;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public class AppVetHouseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<AuxVet> AuxVets { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<VitalSign> VitalSigns { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<CareSuggestion> CareSuggestions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VetHouseBD");
            }
        }
    }
}