using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Entities
{
    public class Inventory
    {
        public int id { get; set; }
        public string InventoryName { get; set; }

        public int productQuantity { get; set; }
    }
}
