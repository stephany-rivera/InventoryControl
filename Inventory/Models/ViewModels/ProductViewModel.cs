using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory.Models.ViewModels
{
    class ProductViewModel
    {
        public int IDTable { get; set; }
        public int IDProduct { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public System.DateTime Modified_date { get; set; }

    }
}
