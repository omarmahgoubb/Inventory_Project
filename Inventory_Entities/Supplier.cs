using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Entities
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(100, ErrorMessage = "Supplier name cannot exceed 100 characters.")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string SupplierPhone { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string SupplierEmail { get; set; } // New property for supplier email

        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
        public string SupplierAddress { get; set; } // New property for supplier address

        [StringLength(50, ErrorMessage = "City cannot exceed 50 characters.")]
        public string City { get; set; } // New property for city

        public ICollection<Product>? Products { get; set; } // Updated to follow naming conventions


    }
}
