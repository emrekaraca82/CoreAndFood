using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class productAdd
    {    
        public string Name { get; set; }   
        public string Description { get; set; }     
        public double Price { get; set; }
        public IFormFile ImageUrl { get; set; }       
        public string Stock { get; set; }     
        public int CategoryID { get; set; }
    }
}
