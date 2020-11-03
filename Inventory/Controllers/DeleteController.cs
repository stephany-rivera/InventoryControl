using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Models;
using Inventory.Models.ViewModels;

namespace Inventory.Controllers
{
    class DeleteController
    {
        public void delete(int id)
        {
            using (inventoryEntities db = new inventoryEntities())
            {
                ProductViewModel product = new ProductViewModel();
                var response = db.products.FirstOrDefault(r => r.IDProduct == id);
                db.products.Remove(response);
                db.SaveChanges();
            }

        }


    }
}
