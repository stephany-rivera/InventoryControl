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
    public partial class FormQueries : Form
    {
        QueriesController productController = new QueriesController();
        public FormQueries()
        {
            InitializeComponent();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            System.DateTime dateInit = dateTimeDateInit.Value;
            System.DateTime dateFinish = dateTimeFinish.Value;
            dataListView.DataSource = "";
            dataListView.DataSource = productController.GetListDate(dateInit, dateFinish);
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                dataListView.DataSource = "";
                dataListView.DataSource = productController.GetListName(BoxSearchName.Text);
            }
        }

        private void btnSearchByQuantity_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(BoxQuantity.Text);
            dataListView.DataSource = "";
            dataListView.DataSource = productController.GetListQuantity(quantity);
        }

        private void FormQueries_Load(object sender, EventArgs e)
        {
            comboBoxFiltros.SelectedIndex = 0;
        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int index = comboBoxFiltros.SelectedIndex;

                if (index == 0)
                {                    
                    panelSearchByName.Visible = false;
                    panelSearchByQuantity.Visible = false;
                    panelSearchByName.Visible = false;
                    dataListView.DataSource = "";
                    dataListView.DataSource = productController.GetListAll();
                }

                if (index == 1)
                {
                    panelSearchByDate.Visible = true;
                    panelSearchByName.Visible = false;
                    panelSearchByQuantity.Visible = false;
                    dataListView.DataSource = "";
                }

                if (index == 2)
                {
                    panelSearchByDate.Visible = false;
                    panelSearchByQuantity.Visible = false;
                    panelSearchByName.Visible = true;
                    dataListView.DataSource = "";
                }

                if (index == 3)
                {
                    panelSearchByDate.Visible = false;
                    panelSearchByName.Visible = false;
                    panelSearchByQuantity.Visible = true;
                    dataListView.DataSource = "";

                }
            }

        }

        private void BoxSearchName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(BoxSearchName, "");
        }

        private void BoxSearchName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(BoxSearchName.Text);
            this.errorProvider.SetError(BoxSearchName, "Digita el nombre del producto");
        }

      
    }
}
