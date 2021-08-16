using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Food
    {  
        public int FoodID { get; set; }

        [Required(ErrorMessage = "Yiyecek Adı Boş Geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yiyecek Açıklama Boş Geçilemez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fiyat Boş Geçilemez")]
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Stok Boş Geçilemez")]
        public string Stock { get; set; }

        [Required(ErrorMessage = "Kategori Boş Geçilemez")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
