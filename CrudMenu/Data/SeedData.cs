using Microsoft.EntityFrameworkCore;
using CrudMenu.Models;
using CrudMenu.Models.Entities;
namespace CrudMenu.Data
{
    public class SeedData
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            context.Database.Migrate();
            if (!context.Menus.Any())
            {
                MenuType fastfood = new MenuType { MenuTypeName = "fastfood"};
                MenuType drink = new MenuType { MenuTypeName = "Drink"};
                context.Menus.AddRange(
                        new Menu
                        {
                            IsHidden=1,
                            MenuType= drink,
                            MenuName = "coffee",
                            ItemDescription = "For Drink",
                            SalePrice = 1,
                            Image = "Coffee.jpg"
                        },
                         new Menu
                         {
                             IsHidden = 0,
                             MenuType = fastfood,
                             MenuName = "Hotport",
                             ItemDescription = "For eat",
                             SalePrice = 12,
                             Image = "Coffee.jpg"
                         }
                        );
                context.SaveChanges();
            }
        }
    }
}
