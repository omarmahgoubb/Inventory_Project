using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Entities
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; } // Updated to follow naming conventions

        [Required] // Make it mandatory
        [DisplayName("Inventory Name")]
        public string InventoryName { get; set; }

        [Required] // Make it mandatory
        [DisplayName("Inventory Address")]
        public string Address { get; set; } // Updated to follow naming conventions

        public ICollection<Product>? Products { get; set; } // Updated to follow naming conventions

        [DisplayName("Created By")]
        public string? CreatedBy { get; set; }
    }
}