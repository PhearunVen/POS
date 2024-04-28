using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrudMenu.Models.Entities
{
    public  class Menu
    {
        public int MenuId { get; set; }
        public int IsHidden { get; set; }
        public int MenuTypeId { get; set; }

        public MenuType MenuType { get; set; }
        public string MenuName { get; set; } = string.Empty;
        public string ItemDescription { get; set; } = string.Empty;
        public decimal SalePrice { get; set; }
        public string Image {  get; set; }

        [NotMapped]
        
        public IFormFile ImageUpload { get; set; }
    }
}
