﻿namespace UrbanInvoicing.Control
{
    partial class ctlDataManagementInbound
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridViewInboundInvoice = new System.Windows.Forms.DataGridView();
            this.bindingSourceInboundInvoices = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewInboundInvoicePosition = new System.Windows.Forms.DataGridView();
            this.bindingSourcePositions = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTypes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceArticles = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMwstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bemerkungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabattDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInboundInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInboundInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInboundInvoicePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dataGridViewInboundInvoice);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridViewInboundInvoicePosition);
            this.splitContainer.Size = new System.Drawing.Size(1593, 960);
            this.splitContainer.SplitterDistance = 531;
            this.splitContainer.TabIndex = 0;
            // 
            // dataGridViewInboundInvoice
            // 
            this.dataGridViewInboundInvoice.AllowUserToAddRows = false;
            this.dataGridViewInboundInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInboundInvoice.AutoGenerateColumns = false;
            this.dataGridViewInboundInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInboundInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customer,
            this.customerIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sumBruttoDataGridViewTextBoxColumn,
            this.sumNettoDataGridViewTextBoxColumn,
            this.sumMwstDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewInboundInvoice.DataSource = this.bindingSourceInboundInvoices;
            this.dataGridViewInboundInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInboundInvoice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInboundInvoice.MultiSelect = false;
            this.dataGridViewInboundInvoice.Name = "dataGridViewInboundInvoice";
            this.dataGridViewInboundInvoice.ReadOnly = true;
            this.dataGridViewInboundInvoice.RowTemplate.Height = 28;
            this.dataGridViewInboundInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInboundInvoice.Size = new System.Drawing.Size(1593, 531);
            this.dataGridViewInboundInvoice.TabIndex = 0;
            this.dataGridViewInboundInvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInboundInvoice_CellFormatting);
            this.dataGridViewInboundInvoice.SelectionChanged += new System.EventHandler(this.dataGridViewInboundInvoice_SelectionChanged);
            // 
            // bindingSourceInboundInvoices
            // 
            this.bindingSourceInboundInvoices.DataSource = typeof(UrbanInvoicing.Classes.clsInvoice);
            // 
            // dataGridViewInboundInvoicePosition
            // 
            this.dataGridViewInboundInvoicePosition.AllowUserToAddRows = false;
            this.dataGridViewInboundInvoicePosition.AllowUserToDeleteRows = false;
            this.dataGridViewInboundInvoicePosition.AutoGenerateColumns = false;
            this.dataGridViewInboundInvoicePosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInboundInvoicePosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bemerkungDataGridViewTextBoxColumn,
            this.article,
            this.Type,
            this.bruttoDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.mwStDataGridViewTextBoxColumn,
            this.rabattDataGridViewTextBoxColumn,
            this.artikelIdDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridViewInboundInvoicePosition.DataSource = this.bindingSourcePositions;
            this.dataGridViewInboundInvoicePosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInboundInvoicePosition.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInboundInvoicePosition.MultiSelect = false;
            this.dataGridViewInboundInvoicePosition.Name = "dataGridViewInboundInvoicePosition";
            this.dataGridViewInboundInvoicePosition.ReadOnly = true;
            this.dataGridViewInboundInvoicePosition.RowTemplate.Height = 28;
            this.dataGridViewInboundInvoicePosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInboundInvoicePosition.Size = new System.Drawing.Size(1593, 425);
            this.dataGridViewInboundInvoicePosition.TabIndex = 0;
            this.dataGridViewInboundInvoicePosition.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInboundInvoicePosition_CellFormatting);
            // 
            // bindingSourcePositions
            // 
            this.bindingSourcePositions.DataSource = typeof(UrbanInvoicing.Classes.clsInvoicePosition);
            // 
            // bindingSourceTypes
            // 
            this.bindingSourceTypes.DataSource = typeof(UrbanInvoicing.Classes.clsType);
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // bindingSourceArticles
            // 
            this.bindingSourceArticles.DataSource = typeof(UrbanInvoicing.Classes.clsArticle);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // customer
            // 
            this.customer.HeaderText = "Kunde";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumBruttoDataGridViewTextBoxColumn
            // 
            this.sumBruttoDataGridViewTextBoxColumn.DataPropertyName = "sumBrutto";
            this.sumBruttoDataGridViewTextBoxColumn.HeaderText = "Sum. Brutto";
            this.sumBruttoDataGridViewTextBoxColumn.Name = "sumBruttoDataGridViewTextBoxColumn";
            this.sumBruttoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumNettoDataGridViewTextBoxColumn
            // 
            this.sumNettoDataGridViewTextBoxColumn.DataPropertyName = "sumNetto";
            this.sumNettoDataGridViewTextBoxColumn.HeaderText = "Sum. Netto";
            this.sumNettoDataGridViewTextBoxColumn.Name = "sumNettoDataGridViewTextBoxColumn";
            this.sumNettoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumMwstDataGridViewTextBoxColumn
            // 
            this.sumMwstDataGridViewTextBoxColumn.DataPropertyName = "sumMwst";
            this.sumMwstDataGridViewTextBoxColumn.HeaderText = "Sum. Mwst";
            this.sumMwstDataGridViewTextBoxColumn.Name = "sumMwstDataGridViewTextBoxColumn";
            this.sumMwstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "invoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "Rechnungsnummer";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name?";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bemerkungDataGridViewTextBoxColumn
            // 
            this.bemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.Name = "bemerkungDataGridViewTextBoxColumn";
            this.bemerkungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // article
            // 
            this.article.HeaderText = "Artikel";
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Typ";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // bruttoDataGridViewTextBoxColumn
            // 
            this.bruttoDataGridViewTextBoxColumn.DataPropertyName = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.HeaderText = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.Name = "bruttoDataGridViewTextBoxColumn";
            this.bruttoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nettoDataGridViewTextBoxColumn
            // 
            this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
            this.nettoDataGridViewTextBoxColumn.HeaderText = "Netto";
            this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
            this.nettoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mwStDataGridViewTextBoxColumn
            // 
            this.mwStDataGridViewTextBoxColumn.DataPropertyName = "MwSt";
            this.mwStDataGridViewTextBoxColumn.HeaderText = "MwSt";
            this.mwStDataGridViewTextBoxColumn.Name = "mwStDataGridViewTextBoxColumn";
            this.mwStDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rabattDataGridViewTextBoxColumn
            // 
            this.rabattDataGridViewTextBoxColumn.DataPropertyName = "Rabatt";
            this.rabattDataGridViewTextBoxColumn.HeaderText = "Rabatt";
            this.rabattDataGridViewTextBoxColumn.Name = "rabattDataGridViewTextBoxColumn";
            this.rabattDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artikelIdDataGridViewTextBoxColumn
            // 
            this.artikelIdDataGridViewTextBoxColumn.DataPropertyName = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.Name = "artikelIdDataGridViewTextBoxColumn";
            this.artikelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.artikelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name?";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ctlDataManagementInbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "ctlDataManagementInbound";
            this.Size = new System.Drawing.Size(1593, 960);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInboundInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInboundInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInboundInvoicePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridViewInboundInvoice;
        private System.Windows.Forms.DataGridView dataGridViewInboundInvoicePosition;
        private System.Windows.Forms.BindingSource bindingSourceInboundInvoices;
        private System.Windows.Forms.BindingSource bindingSourcePositions;
        private System.Windows.Forms.BindingSource bindingSourceTypes;
        private System.Windows.Forms.BindingSource bindingSourceCustomer;
        private System.Windows.Forms.BindingSource bindingSourceArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumBruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMwstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bemerkungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabattDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}