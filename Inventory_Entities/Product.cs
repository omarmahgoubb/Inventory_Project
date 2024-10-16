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
        public string productName { get; set; }

        [DisplayName("Product Description")]
        public string? productDescription { get; set; }

        [DisplayName("Product Price")]
        [Range(1, 10000, ErrorMessage = "price must be greater than 0")]
        public float productPrice { get; set; }

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
        [ForeignKey("Inventory")]
        public int? inventoryId { get; set; }

        public Inventory? inventory { get; set; }
    }
}
