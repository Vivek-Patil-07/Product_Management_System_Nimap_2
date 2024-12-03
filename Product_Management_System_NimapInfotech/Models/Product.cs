using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Management_System_NimapInfotech.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        // Navigation Property for Relationship
        public virtual Category Category { get; set; }
    }
}