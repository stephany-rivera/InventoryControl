using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Models;
using Inventory.Models.ViewModels;
using System.ComponentModel.DataAnnotations;


namespace Inventory.Controllers
{
    class CreateController
    {
        private void NewProduct(ProductViewModel model)
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
                        products product = new products();
                        product.IDProduct = model.IDProduct;
                        product.Product = model.Product;
                        product.Quantity = model.Quantity;
                        product.Modified_date = model.Modified_date;

                        db.products.Add(product);
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


        public void convertToModelProdut(int iDProduct, string product, int quantity, System.DateTime date)
        {
            ProductViewModel modelProduct = new ProductViewModel();
            modelProduct.IDProduct = iDProduct;
            modelProduct.Product = product;
            modelProduct.Quantity = quantity;
            modelProduct.Modified_date = date;
            NewProduct(modelProduct);
        }


    }
}
