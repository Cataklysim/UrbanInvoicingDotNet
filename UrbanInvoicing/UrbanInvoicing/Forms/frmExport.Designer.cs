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
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labelSumGross = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSumNet = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewInvoicePositions, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelInvoiceNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInvoiceNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelInvoiceDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCustomer, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrint, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRecipient, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemoveRow, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelSumGross, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelVAT, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelSumNet, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.buttonBackToMenu, 2, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 1062);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewInvoicePositions
            // 
            this.dataGridViewInvoicePositions.AutoGenerateColumns = false;
            this.dataGridViewInvoicePositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoicePositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelIdDataGridViewTextBoxColumn,
            this.Count,
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
            this.dataGridViewInvoicePositions.Location = new System.Drawing.Point(317, 276);
            this.dataGridViewInvoicePositions.Name = "dataGridViewInvoicePositions";
            this.dataGridViewInvoicePositions.RowTemplate.Height = 28;
            this.dataGridViewInvoicePositions.Size = new System.Drawing.Size(1207, 609);
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
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "Artikel";
            this.artikelIdDataGridViewTextBoxColumn.Name = "artikelIdDataGridViewTextBoxColumn";
            this.artikelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Menge";
            this.Count.Name = "Count";
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "Type";
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
            this.labelInvoiceNumber.Location = new System.Drawing.Point(94, 22);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(217, 55);
            this.labelInvoiceNumber.TabIndex = 0;
            this.labelInvoiceNumber.Text = "Rechnungsnummer:";
            // 
            // textBoxInvoiceNumber
            // 
            this.textBoxInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxInvoiceNumber.Location = new System.Drawing.Point(317, 25);
            this.textBoxInvoiceNumber.Name = "textBoxInvoiceNumber";
            this.textBoxInvoiceNumber.Size = new System.Drawing.Size(421, 37);
            this.textBoxInvoiceNumber.TabIndex = 1;
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelInvoiceDate.Location = new System.Drawing.Point(113, 77);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(198, 43);
            this.labelInvoiceDate.TabIndex = 2;
            this.labelInvoiceDate.Text = "Rechnungsdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(160, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 105);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interne Notiz:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePicker.Location = new System.Drawing.Point(317, 80);
            this.dateTimePicker.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(421, 37);
            this.dateTimePicker.TabIndex = 5;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceCustomers, "id", true));
            this.comboBoxCustomer.DataSource = this.bindingSourceCustomers;
            this.comboBoxCustomer.DisplayMember = "name";
            this.comboBoxCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(317, 123);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(421, 39);
            this.comboBoxCustomer.TabIndex = 6;
            this.comboBoxCustomer.ValueMember = "id";
            this.comboBoxCustomer.SelectedValueChanged += new System.EventHandler(this.comboBoxCustomer_SelectedValueChanged);
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBox1.Location = new System.Drawing.Point(317, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(530, 99);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonPrint.Location = new System.Drawing.Point(1530, 25);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(168, 49);
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
            this.labelRecipient.Location = new System.Drawing.Point(179, 120);
            this.labelRecipient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(131, 48);
            this.labelRecipient.TabIndex = 3;
            this.labelRecipient.Text = "Empfänger:";
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSave.Location = new System.Drawing.Point(1704, 25);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(165, 49);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemoveRow
            // 
            this.buttonRemoveRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonRemoveRow.Location = new System.Drawing.Point(1530, 276);
            this.buttonRemoveRow.Name = "buttonRemoveRow";
            this.buttonRemoveRow.Size = new System.Drawing.Size(168, 49);
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
            this.label1.Location = new System.Drawing.Point(1360, 888);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Summe Brutto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1452, 933);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "MwSt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1530, 973);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "________________";
            // 
            // labelSumGross
            // 
            this.labelSumGross.AutoSize = true;
            this.labelSumGross.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSumGross.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelSumGross.Location = new System.Drawing.Point(1672, 888);
            this.labelSumGross.Name = "labelSumGross";
            this.labelSumGross.Size = new System.Drawing.Size(26, 45);
            this.labelSumGross.TabIndex = 15;
            this.labelSumGross.Text = "0";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelVAT.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelVAT.Location = new System.Drawing.Point(1672, 933);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(26, 40);
            this.labelVAT.TabIndex = 16;
            this.labelVAT.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1366, 1015);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "Summe Netto";
            // 
            // labelSumNet
            // 
            this.labelSumNet.AutoSize = true;
            this.labelSumNet.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSumNet.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelSumNet.Location = new System.Drawing.Point(1672, 1015);
            this.labelSumNet.Name = "labelSumNet";
            this.labelSumNet.Size = new System.Drawing.Size(26, 42);
            this.labelSumNet.TabIndex = 18;
            this.labelSumNet.Text = "0";
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonBackToMenu.Location = new System.Drawing.Point(317, 1060);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(308, 46);
            this.buttonBackToMenu.TabIndex = 19;
            this.buttonBackToMenu.Text = "Zurück zum Hauptmenü";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // bindingSourceTypen
            // 
            this.bindingSourceTypen.DataSource = typeof(UrbanInvoicing.Classes.clsType);
            // 
            // bindingSourceArtikel
            // 
            this.bindingSourceArtikel.DataSource = typeof(UrbanInvoicing.Classes.clsArticle);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmExport";
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
        private System.Windows.Forms.Label labelSumGross;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSumNet;
        private System.Windows.Forms.BindingSource bindingSourcePositions;
        private System.Windows.Forms.BindingSource bindingSourceTypen;
        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private System.Windows.Forms.BindingSource bindingSourceArtikel;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
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