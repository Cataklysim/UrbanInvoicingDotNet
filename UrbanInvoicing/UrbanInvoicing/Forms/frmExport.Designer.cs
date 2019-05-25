namespace UrbanInvoicing.Forms
{
    partial class frmExport
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
            this.dataGridViewInvoicePositions = new System.Windows.Forms.DataGridView();
            this.artikelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MwStCalculated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabattDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bemerkungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePositions = new System.Windows.Forms.BindingSource(this.components);
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.textBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemoveRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSumNet = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSumGross = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.bindingSourceTypen = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceArtikel = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicePositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArtikel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewInvoicePositions, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelInvoiceNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInvoiceNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelInvoiceDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCustomer, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrint, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRecipient, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemoveRow, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelSumNet, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelVAT, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelSumGross, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.buttonBackToMenu, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerFrom, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerTo, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerPaymentDate, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 780);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewInvoicePositions
            // 
            this.dataGridViewInvoicePositions.AutoGenerateColumns = false;
            this.dataGridViewInvoicePositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoicePositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelIdDataGridViewTextBoxColumn,
            this.MwStCalculated,
            this.Count,
            this.mwStDataGridViewTextBoxColumn,
            this.bruttoDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.rabattDataGridViewTextBoxColumn,
            this.bemerkungDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewInvoicePositions.DataSource = this.bindingSourcePositions;
            this.dataGridViewInvoicePositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoicePositions.Location = new System.Drawing.Point(212, 272);
            this.dataGridViewInvoicePositions.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInvoicePositions.Name = "dataGridViewInvoicePositions";
            this.dataGridViewInvoicePositions.RowTemplate.Height = 28;
            this.dataGridViewInvoicePositions.Size = new System.Drawing.Size(804, 396);
            this.dataGridViewInvoicePositions.TabIndex = 8;
            this.dataGridViewInvoicePositions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoicePositions_CellEndEdit);
            this.dataGridViewInvoicePositions.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoicePositions_CellEnter);
            this.dataGridViewInvoicePositions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoicePositions_CellValueChanged);
            this.dataGridViewInvoicePositions.CurrentCellChanged += new System.EventHandler(this.dataGridViewInvoicePositions_CurrentCellChanged);
            this.dataGridViewInvoicePositions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewInvoicePositions_DataError);
            this.dataGridViewInvoicePositions.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewInvoicePositions_UserAddedRow);
            this.dataGridViewInvoicePositions.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewInvoicePositions_UserDeletedRow);
            // 
            // artikelIdDataGridViewTextBoxColumn
            // 
            this.artikelIdDataGridViewTextBoxColumn.DataPropertyName = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "Zimmer";
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
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Übernachtungen";
            this.Count.Name = "Count";
            this.Count.Width = 125;
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
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelInvoiceNumber.Location = new System.Drawing.Point(70, 14);
            this.labelInvoiceNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(138, 36);
            this.labelInvoiceNumber.TabIndex = 0;
            this.labelInvoiceNumber.Text = "Rechnungsnummer:";
            // 
            // textBoxInvoiceNumber
            // 
            this.textBoxInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxInvoiceNumber.Location = new System.Drawing.Point(212, 16);
            this.textBoxInvoiceNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInvoiceNumber.Name = "textBoxInvoiceNumber";
            this.textBoxInvoiceNumber.Size = new System.Drawing.Size(282, 27);
            this.textBoxInvoiceNumber.TabIndex = 1;
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelInvoiceDate.Location = new System.Drawing.Point(82, 50);
            this.labelInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(126, 28);
            this.labelInvoiceDate.TabIndex = 2;
            this.labelInvoiceDate.Text = "Rechnungsdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(110, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 68);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interne Notiz:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePicker.Location = new System.Drawing.Point(212, 52);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(282, 27);
            this.dateTimePicker.TabIndex = 5;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DataSource = this.bindingSourceCustomers;
            this.comboBoxCustomer.DisplayMember = "displayName";
            this.comboBoxCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(212, 80);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(282, 28);
            this.comboBoxCustomer.TabIndex = 6;
            this.comboBoxCustomer.ValueMember = "id";
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBox1.Location = new System.Drawing.Point(212, 204);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(355, 64);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonPrint.Location = new System.Drawing.Point(1020, 16);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(112, 32);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Drucken";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelRecipient
            // 
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRecipient.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelRecipient.Location = new System.Drawing.Point(122, 78);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(85, 31);
            this.labelRecipient.TabIndex = 3;
            this.labelRecipient.Text = "Empfänger:";
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSave.Location = new System.Drawing.Point(1136, 16);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 32);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemoveRow
            // 
            this.buttonRemoveRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonRemoveRow.Location = new System.Drawing.Point(1020, 272);
            this.buttonRemoveRow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveRow.Name = "buttonRemoveRow";
            this.buttonRemoveRow.Size = new System.Drawing.Size(112, 32);
            this.buttonRemoveRow.TabIndex = 11;
            this.buttonRemoveRow.Text = "Entfernen";
            this.buttonRemoveRow.UseVisualStyleBackColor = true;
            this.buttonRemoveRow.Click += new System.EventHandler(this.buttonRemoveRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(913, 670);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Summe Netto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(969, 699);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "MwSt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1020, 725);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "________________";
            // 
            // labelSumNet
            // 
            this.labelSumNet.AutoSize = true;
            this.labelSumNet.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSumNet.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelSumNet.Location = new System.Drawing.Point(1115, 670);
            this.labelSumNet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumNet.Name = "labelSumNet";
            this.labelSumNet.Size = new System.Drawing.Size(17, 29);
            this.labelSumNet.TabIndex = 15;
            this.labelSumNet.Text = "0";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelVAT.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelVAT.Location = new System.Drawing.Point(1115, 699);
            this.labelVAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(17, 26);
            this.labelVAT.TabIndex = 16;
            this.labelVAT.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(909, 752);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Summe Brutto";
            // 
            // labelSumGross
            // 
            this.labelSumGross.AutoSize = true;
            this.labelSumGross.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSumGross.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelSumGross.Location = new System.Drawing.Point(1115, 752);
            this.labelSumGross.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumGross.Name = "labelSumGross";
            this.labelSumGross.Size = new System.Drawing.Size(17, 27);
            this.labelSumGross.TabIndex = 18;
            this.labelSumGross.Text = "0";
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonBackToMenu.Location = new System.Drawing.Point(212, 781);
            this.buttonBackToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(205, 30);
            this.buttonBackToMenu.TabIndex = 19;
            this.buttonBackToMenu.Text = "Zurück zum Hauptmenü";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Aufenthalt von:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Aufenthalt bis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Zahlungsziel:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePickerFrom.Location = new System.Drawing.Point(213, 112);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(282, 27);
            this.dateTimePickerFrom.TabIndex = 23;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePickerTo.Location = new System.Drawing.Point(213, 143);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(282, 27);
            this.dateTimePickerTo.TabIndex = 24;
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePickerPaymentDate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(213, 174);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(282, 27);
            this.dateTimePickerPaymentDate.TabIndex = 25;
            // 
            // bindingSourceTypen
            // 
            this.bindingSourceTypen.DataSource = typeof(UrbanInvoicing.Classes.clsType);
            // 
            // bindingSourceArtikel
            // 
            this.bindingSourceArtikel.DataSource = typeof(UrbanInvoicing.Classes.clsArticle);
            this.bindingSourceArtikel.CurrentChanged += new System.EventHandler(this.bindingSourceArtikel_CurrentChanged);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 780);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmExport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ausgangsrechnung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicePositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArtikel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.TextBox textBoxInvoiceNumber;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridViewInvoicePositions;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemoveRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSumNet;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSumGross;
        private System.Windows.Forms.BindingSource bindingSourcePositions;
        private System.Windows.Forms.BindingSource bindingSourceTypen;
        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private System.Windows.Forms.BindingSource bindingSourceArtikel;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MwStCalculated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabattDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bemerkungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}