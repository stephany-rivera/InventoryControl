using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuCrud_Click(object sender, EventArgs e)
        {
            panelSubItemMenu.Visible = true;
        }

        
        private void btnMenuQueries_Click(object sender, EventArgs e)
        {
            panelSubItemMenu.Visible = false;
            FormQueries newMDIChild = new FormQueries
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            newMDIChild.Show();
        }



        // Open window to create record
        private void btnItemCreate_Click(object sender, EventArgs e)
        {
            panelSubItemMenu.Visible = false;
            FormCreate newMDIChild = new FormCreate
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            newMDIChild.Show();
        }



        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            panelSubItemMenu.Visible = false;
            FormUpdate newMDIChild = new FormUpdate
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            newMDIChild.Show();
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            panelSubItemMenu.Visible = false;
            FormDelete newMDIChild = new FormDelete
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            newMDIChild.Show();

        }



        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            //Change color MDIClient
            MdiClient oMDI;            
            foreach (Control ctl in this.Controls)
            {
                try
                {                    
                    oMDI = (MdiClient)ctl;                    
                    oMDI.BackColor = Color.White;
                }
                catch (InvalidCastException exc)
                {
                   
                }
            }
        }

        

        

       
         

        

        

       
    }
}
