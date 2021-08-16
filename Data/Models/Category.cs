using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage="Kategori Adı Boş Geçilemez")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Kategori Mesajı Boş Geçilemez")]
        public string CategoryDescription { get; set; }

        public bool Status { get; set; }
        public List<Food> Foods { get; set; }
        
    }
}
