using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Entities
{
    public class Inventory
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Inventory Name")]

        public string InventoryName { get; set; }

        [DisplayName("Inventory Address")]
        public string address { get; set; }

        public ICollection<Product>? products { get; set; }

        [DisplayName("Created By")]
        public string? CreatedBy { get; set; }

    }
}
