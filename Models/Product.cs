using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductSoreWebAPICRUD.Models
{
    public class Product
    {
        // Primary Key Setup
        [Key]
        public int Id { get; set; }
        // property stores the name of the product
        public string Name { get; set; }
        // property stores the category of the product
        public string Category { get; set; }
        // stores the product stock status
        public string StockStatus { get; set; }
        // this stores the price of the product
        public decimal Price { get; set; }
    
    }
}