using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Controllers;

namespace Inventory.Views
{
    public partial class FormCreate : Form
    {
        CreateController productController = new CreateController();
        public FormCreate()
        {
            InitializeComponent();
        }


        //Save data
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                int id = int.Parse(BoxIdProduct.Text);
                string product = BoxNameProduct.Text;
                int quantity = int.Parse(BoxQuantity.Text);
                System.DateTime date = dateTimeProduct.Value;
                productController.convertToModelProdut(id, product, quantity, date);
                MessageBox.Show("Producto Registrado con éxito", "Valid", MessageBoxButtons.OK);
                cleanFields();
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }


        }

        /// <summary>
        ///  Validations
        /// </summary>    
        ///    

        private void BoxIdProduct_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxIdProduct.Text);
            this.errorProvider.SetError(BoxIdProduct, "Digita el id del producto");
        }

        private void BoxIdProduct_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxIdProduct, "");
        }



        private void BoxNameProduct_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxNameProduct.Text);
            this.errorProvider.SetError(BoxNameProduct, "Digita el nombre del producto");
        }

        private void BoxNameProduct_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxNameProduct, "");

        }


        private void BoxQuantity_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxQuantity.Text);
            this.errorProvider.SetError(BoxQuantity, "Digita la cantidad del producto");
        }

        private void BoxQuantity_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxQuantity, "");
        }


        private void cleanFields()
        {
            BoxIdProduct.Text = "";
            BoxNameProduct .Text= "";
            BoxQuantity.Text = "";
            dateTimeProduct.Value = DateTime.Now;
            errorProvider.Clear();
            
        }  

    }

    }

       

        

        
    

