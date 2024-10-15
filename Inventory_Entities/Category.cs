using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string categoryName { get; set; }

        public ICollection<Product>? products { get; set; }

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

    }
}
