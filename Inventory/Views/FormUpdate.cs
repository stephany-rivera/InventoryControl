using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Models.ViewModels;
using Inventory.Controllers;


namespace Inventory.Views
{
    public partial class FormUpdate : Form
    {
        UpdateController productController = new UpdateController();
        private int idTable = 0;
        public FormUpdate()
        {
            InitializeComponent();
        }



        //Button  Search the product By ID
        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                ProductViewModel product = new ProductViewModel();
                int id = int.Parse(BoxIdProduct.Text);
                product = productController.update(id);
                BoxIdUpdate.Text = product.IDProduct + "";
                BoxNameUpdate.Text = product.Product;
                BoxQuantityUpdate.Text = product.Quantity + "";
                dateTimeUpdate.Value = product.Modified_date;
                panelData.Visible = true;               
                if (!String.IsNullOrEmpty(BoxIdProduct.Text))
                {
                    enabledButton();
                    idTable = product.IDTable;                   
                }
            }            
        }


        // Button Update the product
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                int id = int.Parse(BoxIdUpdate.Text);
                string product = BoxNameUpdate.Text;
                int quantity = int.Parse(BoxQuantityUpdate.Text);
                System.DateTime date = dateTimeUpdate.Value;
                productController.convertToModelProdut(id, product, quantity, date, idTable);
                MessageBox.Show("Producto Actualizado con éxito", "Valid", MessageBoxButtons.OK);
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
              

        private void BoxIdProduct_TextChanged(object sender, EventArgs e)
        {
            BoxIdUpdate.Text = "";
            BoxNameUpdate.Text = "";
            BoxQuantityUpdate.Text = "";
            dateTimeUpdate.Value = DateTime.Now;
            disabledButton();

        }

        private void disabledButton() {
            BoxIdUpdate.Enabled = false;
            BoxNameUpdate.Enabled = false;
            BoxQuantityUpdate.Enabled = false;
            dateTimeUpdate.Enabled = false;
                }

        private void enabledButton()      
        {           
            BoxIdUpdate.Enabled = true;
            BoxNameUpdate.Enabled = true;
            BoxQuantityUpdate.Enabled = true;
            dateTimeUpdate.Enabled = true;
        }

        private void BoxIdProduct_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxIdProduct.Text);
            this.errorProvider.SetError(BoxIdProduct, "Digita el id del producto");
        }

        private void BoxIdProduct_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxIdProduct, "");
        }



        private void BoxIdUpdate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxIdUpdate.Text);
            this.errorProvider.SetError(BoxIdUpdate, "Digita el id del producto");
        }

        private void BoxIdUpdate_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxIdUpdate, "");
        }




        private void BoxNameUpdate_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxNameUpdate, "");
        }

        private void BoxNameUpdate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxNameUpdate.Text);
            this.errorProvider.SetError(BoxNameUpdate, "Digita el nombre del producto");
        }



        private void BoxQuantityUpdate_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxQuantityUpdate, "");
        }

        private void BoxQuantityUpdate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxQuantityUpdate.Text);
            this.errorProvider.SetError(BoxQuantityUpdate, "Digita la cantidad del producto");
        }

        private void cleanFields()
        {
            BoxIdProduct.Text = "";
            BoxIdUpdate.Text = "";
            BoxQuantityUpdate.Text = "";
            BoxNameUpdate.Text = "";
            errorProvider.Clear();
        }

        
        



        
       
    }
}
