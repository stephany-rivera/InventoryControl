using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Controllers;
using Inventory.Models;
using Inventory.Models.ViewModels;
using System.ComponentModel.DataAnnotations;


namespace Inventory.Controllers
{
    class UpdateController
    {


        public ProductViewModel update(int id)
        {
            using (inventoryEntities db = new inventoryEntities())
            {
                ProductViewModel product = new ProductViewModel();
                var response = db.products.FirstOrDefault(r => r.IDProduct == id);
                Console.WriteLine(id + "");
                product.IDTable = response.IDTable;
                product.IDProduct = response.IDProduct;
                product.Product = response.Product;
                product.Quantity = response.Quantity;
                product.Modified_date = response.Modified_date;

                return product;
            }

        }

        private void updateProduct(ProductViewModel model)
        {
            ValidationContext context = new ValidationContext(model, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            try
            {

                if (!Validator.TryValidateObject(model, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                        Console.WriteLine(result.ErrorMessage);
                    // MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    using (inventoryEntities db = new inventoryEntities())
                    {
                        var product = db.products.FirstOrDefault(r => r.IDProduct == model.IDTable);
                        product.IDProduct = model.IDProduct;
                        product.Product = model.Product;
                        product.Quantity = model.Quantity;
                        product.Modified_date = model.Modified_date;

                        db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }
                    Console.WriteLine("guardado");
                    //MessageBox.Show("Validated");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void convertToModelProdut(int iDProduct, string product, int quantity, System.DateTime date, int iDTable)
        {
            ProductViewModel modelProduct = new ProductViewModel();
            modelProduct.IDProduct = iDProduct;
            modelProduct.Product = product;
            modelProduct.Quantity = quantity;
            modelProduct.Modified_date = date;
            modelProduct.IDTable = iDTable;
            updateProduct(modelProduct);

        }



    }
}
