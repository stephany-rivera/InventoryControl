namespace Inventory.Views
{
    partial class FormQueries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueries));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFiltrarBy = new System.Windows.Forms.Panel();
            this.comboBoxFiltros = new System.Windows.Forms.ComboBox();
            this.labelFiltrarBy = new System.Windows.Forms.Label();
            this.panelSearchByDate = new System.Windows.Forms.Panel();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.labelDateFinish = new System.Windows.Forms.Label();
            this.dateTimeDateInit = new System.Windows.Forms.DateTimePicker();
            this.labelDateInit = new System.Windows.Forms.Label();
            this.panelSearchByName = new System.Windows.Forms.Panel();
            this.BoxSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.panelSearchByQuantity = new System.Windows.Forms.Panel();
            this.BoxQuantity = new System.Windows.Forms.TextBox();
            this.btnSearchByQuantity = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.dataListView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitle.SuspendLayout();
            this.panelFiltrarBy.SuspendLayout();
            this.panelSearchByDate.SuspendLayout();
            this.panelSearchByName.SuspendLayout();
            this.panelSearchByQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Location = new System.Drawing.Point(1, 9);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(186, 43);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(11, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(154, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Consultar Productos:";
            // 
            // panelFiltrarBy
            // 
            this.panelFiltrarBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltrarBy.Controls.Add(this.comboBoxFiltros);
            this.panelFiltrarBy.Controls.Add(this.labelFiltrarBy);
            this.panelFiltrarBy.Location = new System.Drawing.Point(192, 8);
            this.panelFiltrarBy.Name = "panelFiltrarBy";
            this.panelFiltrarBy.Size = new System.Drawing.Size(506, 46);
            this.panelFiltrarBy.TabIndex = 1;
            // 
            // comboBoxFiltros
            // 
            this.comboBoxFiltros.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltros.FormattingEnabled = true;
            this.comboBoxFiltros.Items.AddRange(new object[] {
            "Todos",
            "Rango de Fechas",
            "Nombre Producto",
            "Cantidades"});
            this.comboBoxFiltros.Location = new System.Drawing.Point(91, 10);
            this.comboBoxFiltros.Name = "comboBoxFiltros";
            this.comboBoxFiltros.Size = new System.Drawing.Size(242, 24);
            this.comboBoxFiltros.TabIndex = 1;
            this.comboBoxFiltros.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltros_SelectedIndexChanged);
            // 
            // labelFiltrarBy
            // 
            this.labelFiltrarBy.AutoSize = true;
            this.labelFiltrarBy.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrarBy.Location = new System.Drawing.Point(3, 12);
            this.labelFiltrarBy.Name = "labelFiltrarBy";
            this.labelFiltrarBy.Size = new System.Drawing.Size(82, 21);
            this.labelFiltrarBy.TabIndex = 0;
            this.labelFiltrarBy.Text = "Filtrar Por:";
            // 
            // panelSearchByDate
            // 
            this.panelSearchByDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchByDate.Controls.Add(this.btnSearchDate);
            this.panelSearchByDate.Controls.Add(this.dateTimeFinish);
            this.panelSearchByDate.Controls.Add(this.labelDateFinish);
            this.panelSearchByDate.Controls.Add(this.dateTimeDateInit);
            this.panelSearchByDate.Controls.Add(this.labelDateInit);
            this.panelSearchByDate.Location = new System.Drawing.Point(3, 55);
            this.panelSearchByDate.Name = "panelSearchByDate";
            this.panelSearchByDate.Size = new System.Drawing.Size(695, 42);
            this.panelSearchByDate.TabIndex = 2;
            this.panelSearchByDate.Visible = false;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSearchDate.FlatAppearance.BorderSize = 0;
            this.btnSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(577, 8);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDate.TabIndex = 3;
            this.btnSearchDate.Text = "Buscar";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFinish.Location = new System.Drawing.Point(342, 10);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(217, 21);
            this.dateTimeFinish.TabIndex = 3;
            // 
            // labelDateFinish
            // 
            this.labelDateFinish.AutoSize = true;
            this.labelDateFinish.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFinish.Location = new System.Drawing.Point(292, 12);
            this.labelDateFinish.Name = "labelDateFinish";
            this.labelDateFinish.Size = new System.Drawing.Size(44, 16);
            this.labelDateFinish.TabIndex = 2;
            this.labelDateFinish.Text = "Hasta:";
            // 
            // dateTimeDateInit
            // 
            this.dateTimeDateInit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDateInit.Location = new System.Drawing.Point(58, 10);
            this.dateTimeDateInit.Name = "dateTimeDateInit";
            this.dateTimeDateInit.Size = new System.Drawing.Size(217, 21);
            this.dateTimeDateInit.TabIndex = 1;
            // 
            // labelDateInit
            // 
            this.labelDateInit.AutoSize = true;
            this.labelDateInit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateInit.Location = new System.Drawing.Point(7, 12);
            this.labelDateInit.Name = "labelDateInit";
            this.labelDateInit.Size = new System.Drawing.Size(48, 16);
            this.labelDateInit.TabIndex = 0;
            this.labelDateInit.Text = "Desde:";
            // 
            // panelSearchByName
            // 
            this.panelSearchByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchByName.Controls.Add(this.BoxSearchName);
            this.panelSearchByName.Controls.Add(this.btnSearchByName);
            this.panelSearchByName.Controls.Add(this.labelName);
            this.panelSearchByName.Location = new System.Drawing.Point(3, 55);
            this.panelSearchByName.Name = "panelSearchByName";
            this.panelSearchByName.Size = new System.Drawing.Size(695, 42);
            this.panelSearchByName.TabIndex = 3;
            this.panelSearchByName.Visible = false;
            // 
            // BoxSearchName
            // 
            this.BoxSearchName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSearchName.Location = new System.Drawing.Point(83, 11);
            this.BoxSearchName.Name = "BoxSearchName";
            this.BoxSearchName.Size = new System.Drawing.Size(164, 23);
            this.BoxSearchName.TabIndex = 4;
            this.BoxSearchName.Validating += new System.ComponentModel.CancelEventHandler(this.BoxSearchName_Validating);
            this.BoxSearchName.Validated += new System.EventHandler(this.BoxSearchName_Validated);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSearchByName.FlatAppearance.BorderSize = 0;
            this.btnSearchByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.Location = new System.Drawing.Point(308, 7);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(81, 27);
            this.btnSearchByName.TabIndex = 3;
            this.btnSearchByName.Text = "Buscar";
            this.btnSearchByName.UseVisualStyleBackColor = false;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(7, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nombre:";
            // 
            // panelSearchByQuantity
            // 
            this.panelSearchByQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchByQuantity.Controls.Add(this.BoxQuantity);
            this.panelSearchByQuantity.Controls.Add(this.btnSearchByQuantity);
            this.panelSearchByQuantity.Controls.Add(this.labelQuantity);
            this.panelSearchByQuantity.Location = new System.Drawing.Point(3, 55);
            this.panelSearchByQuantity.Name = "panelSearchByQuantity";
            this.panelSearchByQuantity.Size = new System.Drawing.Size(695, 42);
            this.panelSearchByQuantity.TabIndex = 4;
            this.panelSearchByQuantity.Visible = false;
            // 
            // BoxQuantity
            // 
            this.BoxQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQuantity.Location = new System.Drawing.Point(83, 11);
            this.BoxQuantity.Name = "BoxQuantity";
            this.BoxQuantity.Size = new System.Drawing.Size(164, 23);
            this.BoxQuantity.TabIndex = 4;
            // 
            // btnSearchByQuantity
            // 
            this.btnSearchByQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSearchByQuantity.FlatAppearance.BorderSize = 0;
            this.btnSearchByQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByQuantity.Location = new System.Drawing.Point(267, 6);
            this.btnSearchByQuantity.Name = "btnSearchByQuantity";
            this.btnSearchByQuantity.Size = new System.Drawing.Size(81, 27);
            this.btnSearchByQuantity.TabIndex = 3;
            this.btnSearchByQuantity.Text = "Buscar";
            this.btnSearchByQuantity.UseVisualStyleBackColor = false;
            this.btnSearchByQuantity.Click += new System.EventHandler(this.btnSearchByQuantity_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(7, 12);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(75, 21);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Cantidad:";
            // 
            // dataListView
            // 
            this.dataListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListView.Location = new System.Drawing.Point(4, 104);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(694, 292);
            this.dataListView.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FormQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.dataListView);
            this.Controls.Add(this.panelSearchByName);
            this.Controls.Add(this.panelSearchByDate);
            this.Controls.Add(this.panelSearchByQuantity);
            this.Controls.Add(this.panelFiltrarBy);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormQueries";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "CONSULTAS";
            this.Load += new System.EventHandler(this.FormQueries_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelFiltrarBy.ResumeLayout(false);
            this.panelFiltrarBy.PerformLayout();
            this.panelSearchByDate.ResumeLayout(false);
            this.panelSearchByDate.PerformLayout();
            this.panelSearchByName.ResumeLayout(false);
            this.panelSearchByName.PerformLayout();
            this.panelSearchByQuantity.ResumeLayout(false);
            this.panelSearchByQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFiltrarBy;
        private System.Windows.Forms.Label labelFiltrarBy;
        private System.Windows.Forms.ComboBox comboBoxFiltros;
        private System.Windows.Forms.Panel panelSearchByDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.DateTimePicker dateTimeFinish;
        private System.Windows.Forms.Label labelDateFinish;
        private System.Windows.Forms.DateTimePicker dateTimeDateInit;
        private System.Windows.Forms.Label labelDateInit;
        private System.Windows.Forms.Panel panelSearchByName;
        private System.Windows.Forms.TextBox BoxSearchName;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelSearchByQuantity;
        private System.Windows.Forms.TextBox BoxQuantity;
        private System.Windows.Forms.Button btnSearchByQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.DataGridView dataListView;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}