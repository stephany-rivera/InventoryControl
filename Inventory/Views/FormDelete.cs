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
    public partial class FormDelete : Form
    {
        DeleteController deleteController = new DeleteController();
        UpdateController updateController = new UpdateController();
        private int idTable = 0;
        public FormDelete()
        {
            InitializeComponent();
        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                ProductViewModel product = new ProductViewModel();
                int id = int.Parse(BoxIdProduct.Text);
                product = updateController.update(id);
                BoxIdDelete.Text = product.IDProduct + "";
                BoxNameDelete.Text = product.Product;
                BoxQuantityDelete.Text = product.Quantity + "";
                dateTimeDelete.Value = product.Modified_date;
                idTable = 0;
                idTable = product.IDTable;
                panelData.Visible = true;
                if (!String.IsNullOrEmpty(BoxIdProduct.Text))
                {

                    idTable = product.IDTable;
                }
            }
            
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Quieres eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                deleteController.delete(idTable);
                MessageBox.Show("Producto Eliminado con éxito", "Valid", MessageBoxButtons.OK);
                cleanFields();


            }
        }

        private void BoxIdProduct_TextChanged(object sender, EventArgs e)
        {
            BoxIdDelete.Text = "";
            BoxNameDelete.Text = "";
            BoxQuantityDelete.Text = "";
            dateTimeDelete.Value = DateTime.Now;
            disabledButton();

        }

        private void disabledButton() {
            BoxIdDelete.Enabled = false;
            BoxNameDelete.Enabled = false;
            BoxQuantityDelete.Enabled = false;
            dateTimeDelete.Enabled = false;
          }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            disabledButton();
        }

        private void BoxIdProduct_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxIdProduct, "");
        }

        private void BoxIdProduct_Validating(object sender, CancelEventArgs e)
        {

            e.Cancel = string.IsNullOrEmpty(BoxIdProduct.Text);
            this.errorProvider.SetError(BoxIdProduct, "Digita el id del producto");
 
        }


        private void cleanFields()
        {
            BoxIdProduct.Text = "";
            BoxIdDelete.Text = "";
            BoxNameDelete.Text = "";
            BoxQuantityDelete.Text = "";
            dateTimeDelete.Value = DateTime.Now;
            errorProvider.Clear();

        }  
        



        
       
    }
}
