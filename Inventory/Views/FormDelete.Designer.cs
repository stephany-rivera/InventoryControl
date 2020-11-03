namespace Inventory.Views
{
    partial class FormDelete
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDelete));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDataDelete = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.dateTimeDelete = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BoxQuantityDelete = new System.Windows.Forms.TextBox();
            this.BoxNameDelete = new System.Windows.Forms.TextBox();
            this.BoxIdDelete = new System.Windows.Forms.TextBox();
            this.labelQuantityDelete = new System.Windows.Forms.Label();
            this.labelIdDelete = new System.Windows.Forms.Label();
            this.labelNameDelete = new System.Windows.Forms.Label();
            this.labelDateDelete = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.btnSearchDelete = new System.Windows.Forms.Button();
            this.BoxIdProduct = new System.Windows.Forms.TextBox();
            this.labelIdProduct = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitle.SuspendLayout();
            this.panelDataDelete.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Location = new System.Drawing.Point(1, 12);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(468, 45);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Eliminar un producto :";
            // 
            // panelDataDelete
            // 
            this.panelDataDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataDelete.Controls.Add(this.panelData);
            this.panelDataDelete.Controls.Add(this.btnSearchDelete);
            this.panelDataDelete.Controls.Add(this.BoxIdProduct);
            this.panelDataDelete.Controls.Add(this.labelIdProduct);
            this.panelDataDelete.Location = new System.Drawing.Point(1, 63);
            this.panelDataDelete.Name = "panelDataDelete";
            this.panelDataDelete.Size = new System.Drawing.Size(466, 283);
            this.panelDataDelete.TabIndex = 1;
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.dateTimeDelete);
            this.panelData.Controls.Add(this.btnDelete);
            this.panelData.Controls.Add(this.BoxQuantityDelete);
            this.panelData.Controls.Add(this.BoxNameDelete);
            this.panelData.Controls.Add(this.BoxIdDelete);
            this.panelData.Controls.Add(this.labelQuantityDelete);
            this.panelData.Controls.Add(this.labelIdDelete);
            this.panelData.Controls.Add(this.labelNameDelete);
            this.panelData.Controls.Add(this.labelDateDelete);
            this.panelData.Controls.Add(this.labelTitle1);
            this.panelData.Location = new System.Drawing.Point(6, 45);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(455, 233);
            this.panelData.TabIndex = 3;
            this.panelData.Visible = false;
            // 
            // dateTimeDelete
            // 
            this.dateTimeDelete.Location = new System.Drawing.Point(231, 153);
            this.dateTimeDelete.Name = "dateTimeDelete";
            this.dateTimeDelete.Size = new System.Drawing.Size(191, 20);
            this.dateTimeDelete.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(145, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BoxQuantityDelete
            // 
            this.BoxQuantityDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQuantityDelete.Location = new System.Drawing.Point(231, 114);
            this.BoxQuantityDelete.Name = "BoxQuantityDelete";
            this.BoxQuantityDelete.Size = new System.Drawing.Size(192, 23);
            this.BoxQuantityDelete.TabIndex = 8;
            // 
            // BoxNameDelete
            // 
            this.BoxNameDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNameDelete.Location = new System.Drawing.Point(231, 78);
            this.BoxNameDelete.Name = "BoxNameDelete";
            this.BoxNameDelete.Size = new System.Drawing.Size(192, 23);
            this.BoxNameDelete.TabIndex = 7;
            // 
            // BoxIdDelete
            // 
            this.BoxIdDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxIdDelete.Location = new System.Drawing.Point(231, 43);
            this.BoxIdDelete.Name = "BoxIdDelete";
            this.BoxIdDelete.Size = new System.Drawing.Size(192, 23);
            this.BoxIdDelete.TabIndex = 6;
            // 
            // labelQuantityDelete
            // 
            this.labelQuantityDelete.AutoSize = true;
            this.labelQuantityDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityDelete.Location = new System.Drawing.Point(3, 114);
            this.labelQuantityDelete.Name = "labelQuantityDelete";
            this.labelQuantityDelete.Size = new System.Drawing.Size(142, 21);
            this.labelQuantityDelete.TabIndex = 5;
            this.labelQuantityDelete.Text = "Cantidad Producto:";
            // 
            // labelIdDelete
            // 
            this.labelIdDelete.AutoSize = true;
            this.labelIdDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdDelete.Location = new System.Drawing.Point(3, 45);
            this.labelIdDelete.Name = "labelIdDelete";
            this.labelIdDelete.Size = new System.Drawing.Size(95, 21);
            this.labelIdDelete.TabIndex = 4;
            this.labelIdDelete.Text = "ID Producto:";
            // 
            // labelNameDelete
            // 
            this.labelNameDelete.AutoSize = true;
            this.labelNameDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameDelete.Location = new System.Drawing.Point(3, 78);
            this.labelNameDelete.Name = "labelNameDelete";
            this.labelNameDelete.Size = new System.Drawing.Size(138, 21);
            this.labelNameDelete.TabIndex = 3;
            this.labelNameDelete.Text = "Nombre Producto:";
            // 
            // labelDateDelete
            // 
            this.labelDateDelete.AutoSize = true;
            this.labelDateDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDelete.Location = new System.Drawing.Point(3, 146);
            this.labelDateDelete.Name = "labelDateDelete";
            this.labelDateDelete.Size = new System.Drawing.Size(146, 21);
            this.labelDateDelete.TabIndex = 2;
            this.labelDateDelete.Text = "Fecha Modificación:";
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(3, 10);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(237, 21);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "Información Producto a eliminar:";
            // 
            // btnSearchDelete
            // 
            this.btnSearchDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSearchDelete.FlatAppearance.BorderSize = 0;
            this.btnSearchDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDelete.Location = new System.Drawing.Point(297, 6);
            this.btnSearchDelete.Name = "btnSearchDelete";
            this.btnSearchDelete.Size = new System.Drawing.Size(133, 31);
            this.btnSearchDelete.TabIndex = 2;
            this.btnSearchDelete.Text = "Buscar";
            this.btnSearchDelete.UseVisualStyleBackColor = false;
            this.btnSearchDelete.Click += new System.EventHandler(this.btnSearchDelete_Click);
            // 
            // BoxIdProduct
            // 
            this.BoxIdProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxIdProduct.Location = new System.Drawing.Point(111, 11);
            this.BoxIdProduct.Name = "BoxIdProduct";
            this.BoxIdProduct.Size = new System.Drawing.Size(146, 23);
            this.BoxIdProduct.TabIndex = 1;
            this.BoxIdProduct.TextChanged += new System.EventHandler(this.BoxIdProduct_TextChanged);
            this.BoxIdProduct.Validating += new System.ComponentModel.CancelEventHandler(this.BoxIdProduct_Validating);
            this.BoxIdProduct.Validated += new System.EventHandler(this.BoxIdProduct_Validated);
            // 
            // labelIdProduct
            // 
            this.labelIdProduct.AutoSize = true;
            this.labelIdProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdProduct.Location = new System.Drawing.Point(10, 13);
            this.labelIdProduct.Name = "labelIdProduct";
            this.labelIdProduct.Size = new System.Drawing.Size(95, 21);
            this.labelIdProduct.TabIndex = 0;
            this.labelIdProduct.Text = "ID Producto:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 392);
            this.Controls.Add(this.panelDataDelete);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormDelete";
            this.Text = "ELIMINAR PRODUCTOS";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDataDelete.ResumeLayout(false);
            this.panelDataDelete.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDataDelete;
        private System.Windows.Forms.Label labelIdProduct;
        private System.Windows.Forms.Button btnSearchDelete;
        private System.Windows.Forms.TextBox BoxIdProduct;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelIdDelete;
        private System.Windows.Forms.Label labelNameDelete;
        private System.Windows.Forms.Label labelDateDelete;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelQuantityDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox BoxQuantityDelete;
        private System.Windows.Forms.TextBox BoxNameDelete;
        private System.Windows.Forms.TextBox BoxIdDelete;
        private System.Windows.Forms.DateTimePicker dateTimeDelete;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}