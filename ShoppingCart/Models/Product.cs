using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Product
    {
        public int Id { get; set; }       
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public float Price { get; set; }        
        public float Weight { get; set; }
        public int NumberInStock { get; set; }   
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }        
    }
}