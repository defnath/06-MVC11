using Microsoft.EntityFrameworkCore;

namespace lab11.Models
{
    public class DemoContext : DbContext 
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // funciona como contenedor de la tablas
       public DemoContext(DbContextOptions<DemoContext> options): base(options) { }
    }
}
