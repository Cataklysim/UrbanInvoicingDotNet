﻿namespace UrbanInvoicing.Forms
{
    partial class frmImport
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.labelPositions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSumGross = new System.Windows.Forms.Label();
            this.labelVatSum = new System.Windows.Forms.Label();
            this.labelSumNet = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewInvoicePositions = new System.Windows.Forms.DataGridView();
            this.artikelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MwStCalculated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabattDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bemerkungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePositions = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.buttonCreateArticle = new System.Windows.Forms.Button();
            this.buttonCreateType = new System.Windows.Forms.Button();
            this.bindingSourceArtikel = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTypen = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicePositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArtikel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Controls.Add(this.labelCustomer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCustomers, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPositions, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelSumGross, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelVatSum, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelSumNet, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewInvoicePositions, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonClose, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemove, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInvoiceNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCreateArticle, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonCreateType, 5, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelCustomer
            // 
            this.labelCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(135, 73);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(70, 20);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Lieferant:";
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.DataSource = this.bindingSourceCustomers;
            this.comboBoxCustomers.DisplayMember = "displayName";
            this.comboBoxCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxCustomers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(211, 76);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(282, 28);
            this.comboBoxCustomers.TabIndex = 2;
            this.comboBoxCustomers.ValueMember = "id";
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // labelPositions
            // 
            this.labelPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPositions.AutoSize = true;
            this.labelPositions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositions.Location = new System.Drawing.Point(125, 109);
            this.labelPositions.Name = "labelPositions";
            this.labelPositions.Size = new System.Drawing.Size(80, 20);
            this.labelPositions.TabIndex = 3;
            this.labelPositions.Text = "Positionen:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(905, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Summe Brutto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(965, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "MwSt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1018, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "________________";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(909, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Summe Netto";
            // 
            // labelSumGross
            // 
            this.labelSumGross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumGross.AutoSize = true;
            this.labelSumGross.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumGross.Location = new System.Drawing.Point(1106, 371);
            this.labelSumGross.Name = "labelSumGross";
            this.labelSumGross.Size = new System.Drawing.Size(17, 20);
            this.labelSumGross.TabIndex = 11;
            this.labelSumGross.Text = "0";
            // 
            // labelVatSum
            // 
            this.labelVatSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVatSum.AutoSize = true;
            this.labelVatSum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVatSum.Location = new System.Drawing.Point(1106, 391);
            this.labelVatSum.Name = "labelVatSum";
            this.labelVatSum.Size = new System.Drawing.Size(17, 20);
            this.labelVatSum.TabIndex = 12;
            this.labelVatSum.Text = "0";
            // 
            // labelSumNet
            // 
            this.labelSumNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumNet.AutoSize = true;
            this.labelSumNet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumNet.Location = new System.Drawing.Point(1106, 431);
            this.labelSumNet.Name = "labelSumNet";
            this.labelSumNet.Size = new System.Drawing.Size(17, 20);
            this.labelSumNet.TabIndex = 13;
            this.labelSumNet.Text = "0";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1018, 76);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 30);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewInvoicePositions
            // 
            this.dataGridViewInvoicePositions.AutoGenerateColumns = false;
            this.dataGridViewInvoicePositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoicePositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelIdDataGridViewTextBoxColumn,
            this.MwStCalculated,
            this.typeIdDataGridViewTextBoxColumn,
            this.mwStDataGridViewTextBoxColumn,
            this.bruttoDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.rabattDataGridViewTextBoxColumn,
            this.bemerkungDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewInvoicePositions.DataSource = this.bindingSourcePositions;
            this.dataGridViewInvoicePositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoicePositions.Location = new System.Drawing.Point(211, 112);
            this.dataGridViewInvoicePositions.Name = "dataGridViewInvoicePositions";
            this.dataGridViewInvoicePositions.Size = new System.Drawing.Size(801, 256);
            this.dataGridViewInvoicePositions.StandardTab = true;
            this.dataGridViewInvoicePositions.TabIndex = 3;
            this.dataGridViewInvoicePositions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoicePositions_CellEndEdit);
            this.dataGridViewInvoicePositions.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoicePositions_CellEnter);
            this.dataGridViewInvoicePositions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoicePositions_CellValueChanged);
            this.dataGridViewInvoicePositions.CurrentCellChanged += new System.EventHandler(this.dataGridViewInvoicePositions_CurrentCellChanged);
            this.dataGridViewInvoicePositions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewInvoicePositions_DataError);
            this.dataGridViewInvoicePositions.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoicePositions_RowLeave);
            this.dataGridViewInvoicePositions.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewInvoicePositions_UserAddedRow);
            this.dataGridViewInvoicePositions.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewInvoicePositions_UserDeletedRow);
            // 
            // artikelIdDataGridViewTextBoxColumn
            // 
            this.artikelIdDataGridViewTextBoxColumn.DataPropertyName = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "Artikel";
            this.artikelIdDataGridViewTextBoxColumn.Name = "artikelIdDataGridViewTextBoxColumn";
            this.artikelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // MwStCalculated
            // 
            this.MwStCalculated.DataPropertyName = "MwStCalculated";
            this.MwStCalculated.HeaderText = "MwStCalculated";
            this.MwStCalculated.Name = "MwStCalculated";
            this.MwStCalculated.Visible = false;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // mwStDataGridViewTextBoxColumn
            // 
            this.mwStDataGridViewTextBoxColumn.DataPropertyName = "MwSt";
            this.mwStDataGridViewTextBoxColumn.HeaderText = "MwSt";
            this.mwStDataGridViewTextBoxColumn.Name = "mwStDataGridViewTextBoxColumn";
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
            // rabattDataGridViewTextBoxColumn
            // 
            this.rabattDataGridViewTextBoxColumn.DataPropertyName = "Rabatt";
            this.rabattDataGridViewTextBoxColumn.HeaderText = "Rabatt";
            this.rabattDataGridViewTextBoxColumn.Name = "rabattDataGridViewTextBoxColumn";
            this.rabattDataGridViewTextBoxColumn.Visible = false;
            // 
            // bemerkungDataGridViewTextBoxColumn
            // 
            this.bemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung";
            this.bemerkungDataGridViewTextBoxColumn.MaxInputLength = 300;
            this.bemerkungDataGridViewTextBoxColumn.Name = "bemerkungDataGridViewTextBoxColumn";
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
            // bindingSourcePositions
            // 
            this.bindingSourcePositions.DataSource = typeof(UrbanInvoicing.Classes.clsInvoicePosition);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(211, 454);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(205, 30);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Zurück zum Hauptmenü";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(1018, 112);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(105, 30);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Entfernen";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePicker.Location = new System.Drawing.Point(211, 45);
            this.dateTimePicker.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(282, 27);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(79, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rechnungsdatum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label6.Location = new System.Drawing.Point(63, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rechnungsnummer: ";
            // 
            // textBoxInvoiceNumber
            // 
            this.textBoxInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxInvoiceNumber.Location = new System.Drawing.Point(211, 16);
            this.textBoxInvoiceNumber.MaxLength = 50;
            this.textBoxInvoiceNumber.Name = "textBoxInvoiceNumber";
            this.textBoxInvoiceNumber.Size = new System.Drawing.Size(282, 27);
            this.textBoxInvoiceNumber.TabIndex = 0;
            // 
            // buttonCreateArticle
            // 
            this.buttonCreateArticle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonCreateArticle.Location = new System.Drawing.Point(1129, 76);
            this.buttonCreateArticle.Name = "buttonCreateArticle";
            this.buttonCreateArticle.Size = new System.Drawing.Size(151, 30);
            this.buttonCreateArticle.TabIndex = 6;
            this.buttonCreateArticle.Text = "Artikel erstellen";
            this.buttonCreateArticle.UseVisualStyleBackColor = true;
            this.buttonCreateArticle.Click += new System.EventHandler(this.buttonCreateArticle_Click);
            // 
            // buttonCreateType
            // 
            this.buttonCreateType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonCreateType.Location = new System.Drawing.Point(1129, 112);
            this.buttonCreateType.Name = "buttonCreateType";
            this.buttonCreateType.Size = new System.Drawing.Size(151, 30);
            this.buttonCreateType.TabIndex = 7;
            this.buttonCreateType.Text = "Typ erstellen";
            this.buttonCreateType.UseVisualStyleBackColor = true;
            this.buttonCreateType.Click += new System.EventHandler(this.buttonCreateType_Click);
            // 
            // bindingSourceArtikel
            // 
            this.bindingSourceArtikel.DataSource = typeof(UrbanInvoicing.Classes.clsArticle);
            // 
            // bindingSourceTypen
            // 
            this.bindingSourceTypen.DataSource = typeof(UrbanInvoicing.Classes.clsType);
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmImport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eingangsrechnung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicePositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArtikel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.Label labelPositions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSumGross;
        private System.Windows.Forms.Label labelVatSum;
        private System.Windows.Forms.Label labelSumNet;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.BindingSource bindingSourcePositions;
        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private System.Windows.Forms.DataGridView dataGridViewInvoicePositions;
        private System.Windows.Forms.BindingSource bindingSourceArtikel;
        private System.Windows.Forms.BindingSource bindingSourceTypen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInvoiceNumber;
        private System.Windows.Forms.Button buttonCreateArticle;
        private System.Windows.Forms.Button buttonCreateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MwStCalculated;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabattDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bemerkungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}