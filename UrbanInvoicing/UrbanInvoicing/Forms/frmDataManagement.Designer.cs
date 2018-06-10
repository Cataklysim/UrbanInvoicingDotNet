namespace UrbanInvoicing.Forms
{
    partial class frmDataManagement
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInvoice = new System.Windows.Forms.TabPage();
            this.tabPageContacts = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingSourceInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceInvoicePosition = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.dataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.bindingSourceArtikel = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceType = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.bemerkungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabattDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMwstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInvoicePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArtikel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1924, 906);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInvoice);
            this.tabControl1.Controls.Add(this.tabPageContacts);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(209, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1678, 891);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageInvoice
            // 
            this.tabPageInvoice.Controls.Add(this.splitContainer1);
            this.tabPageInvoice.Location = new System.Drawing.Point(4, 29);
            this.tabPageInvoice.Name = "tabPageInvoice";
            this.tabPageInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInvoice.Size = new System.Drawing.Size(1670, 858);
            this.tabPageInvoice.TabIndex = 0;
            this.tabPageInvoice.Text = "Rechnungen";
            this.tabPageInvoice.UseVisualStyleBackColor = true;
            // 
            // tabPageContacts
            // 
            this.tabPageContacts.Location = new System.Drawing.Point(4, 29);
            this.tabPageContacts.Name = "tabPageContacts";
            this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContacts.Size = new System.Drawing.Size(1670, 858);
            this.tabPageContacts.TabIndex = 1;
            this.tabPageContacts.Text = "Adressen";
            this.tabPageContacts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 891);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bindingSourceInvoice
            // 
            this.bindingSourceInvoice.DataSource = typeof(UrbanInvoicing.Classes.clsInvoice);
            // 
            // bindingSourceInvoicePosition
            // 
            this.bindingSourceInvoicePosition.DataSource = typeof(UrbanInvoicing.Classes.clsInvoicePosition);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewInvoice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewPositions);
            this.splitContainer1.Size = new System.Drawing.Size(1664, 852);
            this.splitContainer1.SplitterDistance = 554;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.AutoGenerateColumns = false;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.customerIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sumBruttoDataGridViewTextBoxColumn,
            this.sumNettoDataGridViewTextBoxColumn,
            this.sumMwstDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridViewInvoice.DataSource = this.bindingSourceInvoice;
            this.dataGridViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvoice.MultiSelect = false;
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowTemplate.Height = 28;
            this.dataGridViewInvoice.RowTemplate.ReadOnly = true;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(1664, 554);
            this.dataGridViewInvoice.TabIndex = 0;
            this.dataGridViewInvoice.SelectionChanged += new System.EventHandler(this.dataGridViewInvoice_SelectionChanged);
            // 
            // dataGridViewPositions
            // 
            this.dataGridViewPositions.AllowUserToAddRows = false;
            this.dataGridViewPositions.AllowUserToDeleteRows = false;
            this.dataGridViewPositions.AutoGenerateColumns = false;
            this.dataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bemerkungDataGridViewTextBoxColumn,
            this.bruttoDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.mwStDataGridViewTextBoxColumn,
            this.rabattDataGridViewTextBoxColumn,
            this.artikelIdDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewPositions.DataSource = this.bindingSourceInvoicePosition;
            this.dataGridViewPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPositions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPositions.MultiSelect = false;
            this.dataGridViewPositions.Name = "dataGridViewPositions";
            this.dataGridViewPositions.RowTemplate.Height = 28;
            this.dataGridViewPositions.RowTemplate.ReadOnly = true;
            this.dataGridViewPositions.Size = new System.Drawing.Size(1664, 294);
            this.dataGridViewPositions.TabIndex = 0;
            // 
            // bindingSourceArtikel
            // 
            this.bindingSourceArtikel.DataSource = typeof(UrbanInvoicing.Classes.clsArticle);
            // 
            // bindingSourceType
            // 
            this.bindingSourceType.DataSource = typeof(UrbanInvoicing.Classes.clsType);
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // bemerkungDataGridViewTextBoxColumn
            // 
            this.bemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.Name = "bemerkungDataGridViewTextBoxColumn";
            // 
            // bruttoDataGridViewTextBoxColumn
            // 
            this.bruttoDataGridViewTextBoxColumn.DataPropertyName = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.HeaderText = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.Name = "bruttoDataGridViewTextBoxColumn";
            // 
            // nettoDataGridViewTextBoxColumn
            // 
            this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
            this.nettoDataGridViewTextBoxColumn.HeaderText = "Netto";
            this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
            // 
            // mwStDataGridViewTextBoxColumn
            // 
            this.mwStDataGridViewTextBoxColumn.DataPropertyName = "MwSt";
            this.mwStDataGridViewTextBoxColumn.HeaderText = "MwSt";
            this.mwStDataGridViewTextBoxColumn.Name = "mwStDataGridViewTextBoxColumn";
            // 
            // rabattDataGridViewTextBoxColumn
            // 
            this.rabattDataGridViewTextBoxColumn.DataPropertyName = "Rabatt";
            this.rabattDataGridViewTextBoxColumn.HeaderText = "Rabatt";
            this.rabattDataGridViewTextBoxColumn.Name = "rabattDataGridViewTextBoxColumn";
            // 
            // artikelIdDataGridViewTextBoxColumn
            // 
            this.artikelIdDataGridViewTextBoxColumn.DataPropertyName = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "Artikel";
            this.artikelIdDataGridViewTextBoxColumn.Name = "artikelIdDataGridViewTextBoxColumn";
            this.artikelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Kunde";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Rechnungsdatum";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // sumBruttoDataGridViewTextBoxColumn
            // 
            this.sumBruttoDataGridViewTextBoxColumn.DataPropertyName = "sumBrutto";
            this.sumBruttoDataGridViewTextBoxColumn.HeaderText = "Summe Brutto";
            this.sumBruttoDataGridViewTextBoxColumn.Name = "sumBruttoDataGridViewTextBoxColumn";
            // 
            // sumNettoDataGridViewTextBoxColumn
            // 
            this.sumNettoDataGridViewTextBoxColumn.DataPropertyName = "sumNetto";
            this.sumNettoDataGridViewTextBoxColumn.HeaderText = "Summe Netto";
            this.sumNettoDataGridViewTextBoxColumn.Name = "sumNettoDataGridViewTextBoxColumn";
            // 
            // sumMwstDataGridViewTextBoxColumn
            // 
            this.sumMwstDataGridViewTextBoxColumn.DataPropertyName = "sumMwst";
            this.sumMwstDataGridViewTextBoxColumn.HeaderText = "Summe MwSt";
            this.sumMwstDataGridViewTextBoxColumn.Name = "sumMwstDataGridViewTextBoxColumn";
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "invoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "Rechnungsnummer";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // frmDataManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 906);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDataManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDataManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDataManagement_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInvoicePosition)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArtikel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInvoice;
        private System.Windows.Forms.TabPage tabPageContacts;
        private System.Windows.Forms.BindingSource bindingSourceInvoice;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.DataGridView dataGridViewPositions;
        private System.Windows.Forms.BindingSource bindingSourceInvoicePosition;
        private System.Windows.Forms.BindingSource bindingSourceArtikel;
        private System.Windows.Forms.BindingSource bindingSourceType;
        private System.Windows.Forms.BindingSource bindingSourceCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumBruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMwstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bemerkungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabattDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}