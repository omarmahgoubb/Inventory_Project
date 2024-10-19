using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
        public string productName { get; set; }

        [DisplayName("Product Description")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]

        public string? productDescription { get; set; }

        [DisplayName("Product Price")]
        [Range(0.01, 100000, ErrorMessage = "price must be greater than 0")]
        public float productPrice { get; set; }

        [DisplayName("Product Quantity")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative.")]
        public int productQuantity { get; set; } // New field for product quantity

        public DateTime? CreationDate { get; set; } = DateTime.Now;

        [DisplayName("Category")]
        [ForeignKey("Category")]
        public int? categoryId { get; set; }

        public Category? category { get; set; }

        public string? imagePath { get; set; }

        [NotMapped]
        public IFormFile? clientFile { get; set; }

        public byte[]? dbimage { get; set; }

        [NotMapped]
        public string? imageSrc
        {
            get
            {
                if (dbimage != null)
                {
                    string base64String = Convert.ToBase64String(dbimage, 0, dbimage.Length);
                    return "data:image/jpg;base64," + base64String;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        // New field to store the email of the user who created the product
        [DisplayName("Created By")]
        public string? CreatedBy { get; set; }

        [DisplayName("Inventory")]
        [ForeignKey("Inventory_Entities.Inventory")]
        public int? inventoryId { get; set; }

        public Inventory? inventory { get; set; }

        [DisplayName("Supplier")]
        [ForeignKey("Supplier")]
        public int? supplierId { get; set; }

        public Supplier? supplier { get; set; }
    }
}
