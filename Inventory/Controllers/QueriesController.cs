using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Models;
using Inventory.Models.ViewModels;


namespace Inventory.Controllers
{
    class QueriesController
    {
        public IEnumerable<ListProductViewModels> GetListAll()
        {
            using (inventoryEntities db = new inventoryEntities())
            {
                IEnumerable<ListProductViewModels> lst = (from d in db.products
                                                          select new ListProductViewModels
                                                          {
                                                              IDProduct = d.IDProduct,
                                                              Product = d.Product,
                                                              Quantity = d.Quantity,
                                                              Modified_date = d.Modified_date
                                                          }).ToList();
                return lst;
            }
        }


        public IEnumerable<ListProductViewModels> GetListName(string name)
        {
            using (inventoryEntities db = new inventoryEntities())
            {
                IEnumerable<ListProductViewModels> lst = db.products.Where(n => n.Product == name).Select
                                                          (n => new ListProductViewModels
                                                          {
                                                              IDProduct = n.IDProduct,
                                                              Product = n.Product,
                                                              Quantity = n.Quantity,
                                                              Modified_date = n.Modified_date
                                                          }).ToList();
                return lst;
            }
        }

        public IEnumerable<ListProductViewModels> GetListQuantity(int quantity)
        {
            using (inventoryEntities db = new inventoryEntities())
            {
                IEnumerable<ListProductViewModels> lst = db.products.Where(n => n.Quantity == quantity).Select
                                                          (n => new ListProductViewModels
                                                          {
                                                              IDProduct = n.IDProduct,
                                                              Product = n.Product,
                                                              Quantity = n.Quantity,
                                                              Modified_date = n.Modified_date
                                                          }).ToList();
                return lst;
            }
        }


        public IEnumerable<ListProductViewModels> GetListDate(System.DateTime dateInit, System.DateTime dateFinish)
        {
            using (inventoryEntities db = new inventoryEntities())
            {
                IEnumerable<ListProductViewModels> lst = db.products.Where(n => n.Modified_date >= dateInit && n.Modified_date <= dateFinish).Select
                                                          (n => new ListProductViewModels
                                                          {
                                                              IDProduct = n.IDProduct,
                                                              Product = n.Product,
                                                              Quantity = n.Quantity,
                                                              Modified_date = n.Modified_date
                                                          }).ToList();
                return lst;
            }
        }




    }
}
