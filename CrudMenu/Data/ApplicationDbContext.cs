using CrudMenu.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudMenu.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

     
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
    }
}

