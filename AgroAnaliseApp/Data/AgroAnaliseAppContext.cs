using Microsoft.EntityFrameworkCore;
using AgroAnaliseApp.Models;
using AgroAnaliseApp.Models.ViewModels;


namespace AgroAnaliseApp.Data
{
    public class AgroAnaliseAppContext : DbContext
    {
        public AgroAnaliseAppContext (DbContextOptions<AgroAnaliseAppContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Analysis> Analyses { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Farm> Farms{ get; set; }
        public DbSet<Farmer> Farmers { get; set; }        
    }
}
