namespace Inventory.Views
{
    partial class FormCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContentData = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dateTimeProduct = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.BoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.BoxNameProduct = new System.Windows.Forms.TextBox();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.BoxIdProduct = new System.Windows.Forms.TextBox();
            this.labelIdProduct = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitle.SuspendLayout();
            this.panelContentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Location = new System.Drawing.Point(1, 9);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(460, 36);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(212, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Registrar un nuevo producto:";
            // 
            // panelContentData
            // 
            this.panelContentData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContentData.Controls.Add(this.btnCreate);
            this.panelContentData.Controls.Add(this.dateTimeProduct);
            this.panelContentData.Controls.Add(this.labelDate);
            this.panelContentData.Controls.Add(this.BoxQuantity);
            this.panelContentData.Controls.Add(this.labelQuantity);
            this.panelContentData.Controls.Add(this.BoxNameProduct);
            this.panelContentData.Controls.Add(this.labelNameProduct);
            this.panelContentData.Controls.Add(this.BoxIdProduct);
            this.panelContentData.Controls.Add(this.labelIdProduct);
            this.panelContentData.Location = new System.Drawing.Point(5, 56);
            this.panelContentData.Name = "panelContentData";
            this.panelContentData.Size = new System.Drawing.Size(456, 224);
            this.panelContentData.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(125, 175);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(149, 34);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Registrar";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dateTimeProduct
            // 
            this.dateTimeProduct.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeProduct.Location = new System.Drawing.Point(180, 137);
            this.dateTimeProduct.Name = "dateTimeProduct";
            this.dateTimeProduct.Size = new System.Drawing.Size(225, 20);
            this.dateTimeProduct.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(16, 136);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(142, 21);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Cantidad Producto:";
            // 
            // BoxQuantity
            // 
            this.BoxQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQuantity.Location = new System.Drawing.Point(180, 89);
            this.BoxQuantity.Name = "BoxQuantity";
            this.BoxQuantity.Size = new System.Drawing.Size(230, 23);
            this.BoxQuantity.TabIndex = 5;
            this.BoxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.BoxQuantity_Validating);
            this.BoxQuantity.Validated += new System.EventHandler(this.BoxQuantity_Validated);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(16, 95);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(142, 21);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Cantidad Producto:";
            // 
            // BoxNameProduct
            // 
            this.BoxNameProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNameProduct.Location = new System.Drawing.Point(180, 50);
            this.BoxNameProduct.Name = "BoxNameProduct";
            this.BoxNameProduct.Size = new System.Drawing.Size(230, 23);
            this.BoxNameProduct.TabIndex = 3;
            this.BoxNameProduct.Validating += new System.ComponentModel.CancelEventHandler(this.BoxNameProduct_Validating);
            this.BoxNameProduct.Validated += new System.EventHandler(this.BoxNameProduct_Validated);
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameProduct.Location = new System.Drawing.Point(16, 52);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(138, 21);
            this.labelNameProduct.TabIndex = 2;
            this.labelNameProduct.Text = "Nombre Producto:";
            // 
            // BoxIdProduct
            // 
            this.BoxIdProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxIdProduct.Location = new System.Drawing.Point(180, 9);
            this.BoxIdProduct.Name = "BoxIdProduct";
            this.BoxIdProduct.Size = new System.Drawing.Size(230, 23);
            this.BoxIdProduct.TabIndex = 1;
            this.BoxIdProduct.Validating += new System.ComponentModel.CancelEventHandler(this.BoxIdProduct_Validating);
            this.BoxIdProduct.Validated += new System.EventHandler(this.BoxIdProduct_Validated);
            // 
            // labelIdProduct
            // 
            this.labelIdProduct.AutoSize = true;
            this.labelIdProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdProduct.Location = new System.Drawing.Point(16, 15);
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
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 347);
            this.Controls.Add(this.panelContentData);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormCreate";
            this.Text = "CREAR NUEVO PRODUCTO";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelContentData.ResumeLayout(false);
            this.panelContentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContentData;
        private System.Windows.Forms.TextBox BoxIdProduct;
        private System.Windows.Forms.Label labelIdProduct;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dateTimeProduct;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox BoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox BoxNameProduct;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}