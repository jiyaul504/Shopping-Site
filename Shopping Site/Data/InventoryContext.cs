using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shopping_Site.Models;

namespace Shopping_Site.Data
{
    public class InventoryContext :DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        //public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }

    }
}
