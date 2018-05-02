using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeupRetailSearcher.Models
{
    public class Makeup
    {
        public int ID { get; set; }
        public int Product_Id { get; set; }

        [Display(Name = "Product name")]
        public string Product_Name { get; set; }
        public string Brand { get; set; }
        public int Retailer_Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Link { get; set; }
        
    }
}
