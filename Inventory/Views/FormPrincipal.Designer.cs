namespace Inventory.Views
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenuCrud = new System.Windows.Forms.Button();
            this.btnMenuQueries = new System.Windows.Forms.Button();
            this.panelmagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSubItemMenu = new System.Windows.Forms.Panel();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.btnItemCreate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelmagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSubItemMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panelMenu.Controls.Add(this.btnMenuCrud);
            this.panelMenu.Controls.Add(this.btnMenuQueries);
            this.panelMenu.Controls.Add(this.panelmagen);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(716, 55);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMenuCrud
            // 
            this.btnMenuCrud.FlatAppearance.BorderSize = 0;
            this.btnMenuCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCrud.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCrud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuCrud.Location = new System.Drawing.Point(123, -1);
            this.btnMenuCrud.Name = "btnMenuCrud";
            this.btnMenuCrud.Size = new System.Drawing.Size(160, 55);
            this.btnMenuCrud.TabIndex = 3;
            this.btnMenuCrud.Text = "Registros";
            this.btnMenuCrud.UseVisualStyleBackColor = true;
            this.btnMenuCrud.Click += new System.EventHandler(this.btnMenuCrud_Click);
            // 
            // btnMenuQueries
            // 
            this.btnMenuQueries.FlatAppearance.BorderSize = 0;
            this.btnMenuQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuQueries.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQueries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuQueries.Location = new System.Drawing.Point(278, 0);
            this.btnMenuQueries.Name = "btnMenuQueries";
            this.btnMenuQueries.Size = new System.Drawing.Size(160, 55);
            this.btnMenuQueries.TabIndex = 2;
            this.btnMenuQueries.Text = "Consultas";
            this.btnMenuQueries.UseVisualStyleBackColor = true;
            this.btnMenuQueries.Click += new System.EventHandler(this.btnMenuQueries_Click);
            // 
            // panelmagen
            // 
            this.panelmagen.BackColor = System.Drawing.Color.White;
            this.panelmagen.Controls.Add(this.pictureBox1);
            this.panelmagen.Location = new System.Drawing.Point(23, 4);
            this.panelmagen.Name = "panelmagen";
            this.panelmagen.Size = new System.Drawing.Size(51, 50);
            this.panelmagen.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSubItemMenu
            // 
            this.panelSubItemMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelSubItemMenu.Controls.Add(this.btnItemDelete);
            this.panelSubItemMenu.Controls.Add(this.btnItemUpdate);
            this.panelSubItemMenu.Controls.Add(this.btnItemCreate);
            this.panelSubItemMenu.Location = new System.Drawing.Point(124, 55);
            this.panelSubItemMenu.Name = "panelSubItemMenu";
            this.panelSubItemMenu.Size = new System.Drawing.Size(154, 155);
            this.panelSubItemMenu.TabIndex = 1;
            this.panelSubItemMenu.Visible = false;
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.FlatAppearance.BorderSize = 0;
            this.btnItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDelete.Location = new System.Drawing.Point(1, 97);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(153, 40);
            this.btnItemDelete.TabIndex = 2;
            this.btnItemDelete.Text = "Eliminar";
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.FlatAppearance.BorderSize = 0;
            this.btnItemUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemUpdate.Location = new System.Drawing.Point(1, 51);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(153, 40);
            this.btnItemUpdate.TabIndex = 1;
            this.btnItemUpdate.Text = "Actualizar";
            this.btnItemUpdate.UseVisualStyleBackColor = true;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // btnItemCreate
            // 
            this.btnItemCreate.FlatAppearance.BorderSize = 0;
            this.btnItemCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCreate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemCreate.Location = new System.Drawing.Point(1, 0);
            this.btnItemCreate.Name = "btnItemCreate";
            this.btnItemCreate.Size = new System.Drawing.Size(153, 40);
            this.btnItemCreate.TabIndex = 0;
            this.btnItemCreate.Text = "Crear";
            this.btnItemCreate.UseVisualStyleBackColor = true;
            this.btnItemCreate.Click += new System.EventHandler(this.btnItemCreate_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 482);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(716, 22);
            this.panelFooter.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(716, 504);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSubItemMenu);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "MANEJO DE INVENTARIOS";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelmagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSubItemMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelmagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuQueries;
        private System.Windows.Forms.Button btnMenuCrud;
        private System.Windows.Forms.Panel panelSubItemMenu;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button btnItemCreate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelFooter;
    }
}