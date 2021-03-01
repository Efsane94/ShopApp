using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        //[Required]
        //[StringLength(60, MinimumLength =10, ErrorMessage ="Mehsul adi minimum 10 ve maksimum 60 simvoldan ibaret ola biler.")]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(10000, MinimumLength = 20, ErrorMessage = "Mehsul aciqlamasi minimum 20 ve maksimum 100 simvoldan ibaret ola biler.")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Qiymeti daxil edin.")]
        [Range(1,10000)]
        public decimal? Price { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}

