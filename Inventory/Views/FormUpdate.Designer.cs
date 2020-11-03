namespace Inventory.Views
{
    partial class FormUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdate));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDataUpdate = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.BoxQuantityUpdate = new System.Windows.Forms.TextBox();
            this.BoxNameUpdate = new System.Windows.Forms.TextBox();
            this.BoxIdUpdate = new System.Windows.Forms.TextBox();
            this.labelQuantityUpdate = new System.Windows.Forms.Label();
            this.labelIdUpdate = new System.Windows.Forms.Label();
            this.labelNameUpdate = new System.Windows.Forms.Label();
            this.labelDateUpdate = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            this.BoxIdProduct = new System.Windows.Forms.TextBox();
            this.labelIdProduct = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitle.SuspendLayout();
            this.panelDataUpdate.SuspendLayout();
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
            this.labelTitle.Size = new System.Drawing.Size(235, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Actualizar un producto existente:";
            // 
            // panelDataUpdate
            // 
            this.panelDataUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataUpdate.Controls.Add(this.panelData);
            this.panelDataUpdate.Controls.Add(this.btnSearchUpdate);
            this.panelDataUpdate.Controls.Add(this.BoxIdProduct);
            this.panelDataUpdate.Controls.Add(this.labelIdProduct);
            this.panelDataUpdate.Location = new System.Drawing.Point(1, 63);
            this.panelDataUpdate.Name = "panelDataUpdate";
            this.panelDataUpdate.Size = new System.Drawing.Size(466, 283);
            this.panelDataUpdate.TabIndex = 1;
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.dateTimeUpdate);
            this.panelData.Controls.Add(this.btnUpdate);
            this.panelData.Controls.Add(this.BoxQuantityUpdate);
            this.panelData.Controls.Add(this.BoxNameUpdate);
            this.panelData.Controls.Add(this.BoxIdUpdate);
            this.panelData.Controls.Add(this.labelQuantityUpdate);
            this.panelData.Controls.Add(this.labelIdUpdate);
            this.panelData.Controls.Add(this.labelNameUpdate);
            this.panelData.Controls.Add(this.labelDateUpdate);
            this.panelData.Controls.Add(this.labelTitle1);
            this.panelData.Location = new System.Drawing.Point(6, 45);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(455, 233);
            this.panelData.TabIndex = 3;
            this.panelData.Visible = false;
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.Location = new System.Drawing.Point(231, 153);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(191, 20);
            this.dateTimeUpdate.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(145, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BoxQuantityUpdate
            // 
            this.BoxQuantityUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQuantityUpdate.Location = new System.Drawing.Point(231, 114);
            this.BoxQuantityUpdate.Name = "BoxQuantityUpdate";
            this.BoxQuantityUpdate.Size = new System.Drawing.Size(192, 23);
            this.BoxQuantityUpdate.TabIndex = 8;
            this.BoxQuantityUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.BoxQuantityUpdate_Validating);
            this.BoxQuantityUpdate.Validated += new System.EventHandler(this.BoxQuantityUpdate_Validated);
            // 
            // BoxNameUpdate
            // 
            this.BoxNameUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNameUpdate.Location = new System.Drawing.Point(231, 78);
            this.BoxNameUpdate.Name = "BoxNameUpdate";
            this.BoxNameUpdate.Size = new System.Drawing.Size(192, 23);
            this.BoxNameUpdate.TabIndex = 7;
            this.BoxNameUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.BoxNameUpdate_Validating);
            this.BoxNameUpdate.Validated += new System.EventHandler(this.BoxNameUpdate_Validated);
            // 
            // BoxIdUpdate
            // 
            this.BoxIdUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxIdUpdate.Location = new System.Drawing.Point(231, 43);
            this.BoxIdUpdate.Name = "BoxIdUpdate";
            this.BoxIdUpdate.Size = new System.Drawing.Size(192, 23);
            this.BoxIdUpdate.TabIndex = 6;
            this.BoxIdUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.BoxIdUpdate_Validating);
            this.BoxIdUpdate.Validated += new System.EventHandler(this.BoxIdUpdate_Validated);
            // 
            // labelQuantityUpdate
            // 
            this.labelQuantityUpdate.AutoSize = true;
            this.labelQuantityUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityUpdate.Location = new System.Drawing.Point(3, 114);
            this.labelQuantityUpdate.Name = "labelQuantityUpdate";
            this.labelQuantityUpdate.Size = new System.Drawing.Size(142, 21);
            this.labelQuantityUpdate.TabIndex = 5;
            this.labelQuantityUpdate.Text = "Cantidad Producto:";
            // 
            // labelIdUpdate
            // 
            this.labelIdUpdate.AutoSize = true;
            this.labelIdUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdUpdate.Location = new System.Drawing.Point(3, 45);
            this.labelIdUpdate.Name = "labelIdUpdate";
            this.labelIdUpdate.Size = new System.Drawing.Size(95, 21);
            this.labelIdUpdate.TabIndex = 4;
            this.labelIdUpdate.Text = "ID Producto:";
            // 
            // labelNameUpdate
            // 
            this.labelNameUpdate.AutoSize = true;
            this.labelNameUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUpdate.Location = new System.Drawing.Point(3, 78);
            this.labelNameUpdate.Name = "labelNameUpdate";
            this.labelNameUpdate.Size = new System.Drawing.Size(138, 21);
            this.labelNameUpdate.TabIndex = 3;
            this.labelNameUpdate.Text = "Nombre Producto:";
            // 
            // labelDateUpdate
            // 
            this.labelDateUpdate.AutoSize = true;
            this.labelDateUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateUpdate.Location = new System.Drawing.Point(3, 146);
            this.labelDateUpdate.Name = "labelDateUpdate";
            this.labelDateUpdate.Size = new System.Drawing.Size(146, 21);
            this.labelDateUpdate.TabIndex = 2;
            this.labelDateUpdate.Text = "Fecha Modificación:";
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(3, 10);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(179, 21);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "Información a actualizar:";
            // 
            // btnSearchUpdate
            // 
            this.btnSearchUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSearchUpdate.FlatAppearance.BorderSize = 0;
            this.btnSearchUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUpdate.Location = new System.Drawing.Point(296, 6);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.Size = new System.Drawing.Size(133, 31);
            this.btnSearchUpdate.TabIndex = 2;
            this.btnSearchUpdate.Text = "Buscar";
            this.btnSearchUpdate.UseVisualStyleBackColor = false;
            this.btnSearchUpdate.Click += new System.EventHandler(this.btnSearchUpdate_Click);
            // 
            // BoxIdProduct
            // 
            this.BoxIdProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxIdProduct.Location = new System.Drawing.Point(111, 11);
            this.BoxIdProduct.Name = "BoxIdProduct";
            this.BoxIdProduct.Size = new System.Drawing.Size(139, 23);
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
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 392);
            this.Controls.Add(this.panelDataUpdate);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormUpdate";
            this.Text = "ACTUALIZAR PRODUCTOS";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDataUpdate.ResumeLayout(false);
            this.panelDataUpdate.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDataUpdate;
        private System.Windows.Forms.Label labelIdProduct;
        private System.Windows.Forms.Button btnSearchUpdate;
        private System.Windows.Forms.TextBox BoxIdProduct;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelIdUpdate;
        private System.Windows.Forms.Label labelNameUpdate;
        private System.Windows.Forms.Label labelDateUpdate;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelQuantityUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox BoxQuantityUpdate;
        private System.Windows.Forms.TextBox BoxNameUpdate;
        private System.Windows.Forms.TextBox BoxIdUpdate;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}