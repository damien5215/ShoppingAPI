using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI.Models
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string ProductName { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public string ShopName { get; set; }
    }
}
