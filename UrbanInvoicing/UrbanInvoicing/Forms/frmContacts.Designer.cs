namespace UrbanInvoicing.Forms
{
    partial class frmContacts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonNewAddress = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicePlzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTelefaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonHome);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNewAddress);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDetails);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCustomer);
            this.splitContainer1.Size = new System.Drawing.Size(1403, 690);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(1159, 354);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(169, 25);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "Zurück zum Hauptmenü";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonNewAddress
            // 
            this.buttonNewAddress.Location = new System.Drawing.Point(1159, 15);
            this.buttonNewAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNewAddress.Name = "buttonNewAddress";
            this.buttonNewAddress.Size = new System.Drawing.Size(169, 25);
            this.buttonNewAddress.TabIndex = 2;
            this.buttonNewAddress.Text = "Neuer Kontakt";
            this.buttonNewAddress.UseVisualStyleBackColor = true;
            this.buttonNewAddress.Click += new System.EventHandler(this.buttonNewAddress_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Location = new System.Drawing.Point(9, 8);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDetails.Size = new System.Drawing.Size(1135, 408);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(1159, 73);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(169, 25);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Details";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AllowUserToOrderColumns = true;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Id,
            this.lastNameDataGridViewTextBoxColumn,
            this.plzDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.landDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.telefaxDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.invoiceNameDataGridViewTextBoxColumn,
            this.invoiceLastNameDataGridViewTextBoxColumn,
            this.invoicePlzDataGridViewTextBoxColumn,
            this.invoiceStreetDataGridViewTextBoxColumn,
            this.invoiceCityDataGridViewTextBoxColumn,
            this.invoiceLandDataGridViewTextBoxColumn,
            this.invoiceTelefoneDataGridViewTextBoxColumn,
            this.invoiceTelefaxDataGridViewTextBoxColumn,
            this.invoiceEmailDataGridViewTextBoxColumn,
            this.invoiceCommentDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.bindingSourceCustomer;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCustomer.MultiSelect = false;
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.Height = 28;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1403, 343);
            this.dataGridViewCustomer.TabIndex = 0;
            this.dataGridViewCustomer.SelectionChanged += new System.EventHandler(this.dataGridViewCustomer_SelectionChanged);
            this.dataGridViewCustomer.DoubleClick += new System.EventHandler(this.dataGridViewCustomer_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 85;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 95;
            // 
            // plzDataGridViewTextBoxColumn
            // 
            this.plzDataGridViewTextBoxColumn.DataPropertyName = "plz";
            this.plzDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.plzDataGridViewTextBoxColumn.Name = "plzDataGridViewTextBoxColumn";
            this.plzDataGridViewTextBoxColumn.Width = 53;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Straße";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 70;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Stadt";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 63;
            // 
            // landDataGridViewTextBoxColumn
            // 
            this.landDataGridViewTextBoxColumn.DataPropertyName = "land";
            this.landDataGridViewTextBoxColumn.HeaderText = "Land";
            this.landDataGridViewTextBoxColumn.Name = "landDataGridViewTextBoxColumn";
            this.landDataGridViewTextBoxColumn.Width = 61;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 75;
            // 
            // telefaxDataGridViewTextBoxColumn
            // 
            this.telefaxDataGridViewTextBoxColumn.DataPropertyName = "telefax";
            this.telefaxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.telefaxDataGridViewTextBoxColumn.Name = "telefaxDataGridViewTextBoxColumn";
            this.telefaxDataGridViewTextBoxColumn.Width = 52;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 70;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Bemerkung";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 98;
            // 
            // invoiceNameDataGridViewTextBoxColumn
            // 
            this.invoiceNameDataGridViewTextBoxColumn.DataPropertyName = "invoiceName";
            this.invoiceNameDataGridViewTextBoxColumn.HeaderText = "Vorname auf Rechnung";
            this.invoiceNameDataGridViewTextBoxColumn.Name = "invoiceNameDataGridViewTextBoxColumn";
            this.invoiceNameDataGridViewTextBoxColumn.Width = 153;
            // 
            // invoiceLastNameDataGridViewTextBoxColumn
            // 
            this.invoiceLastNameDataGridViewTextBoxColumn.DataPropertyName = "invoiceLastName";
            this.invoiceLastNameDataGridViewTextBoxColumn.HeaderText = "Nachname auf Rechnung";
            this.invoiceLastNameDataGridViewTextBoxColumn.Name = "invoiceLastNameDataGridViewTextBoxColumn";
            this.invoiceLastNameDataGridViewTextBoxColumn.Width = 162;
            // 
            // invoicePlzDataGridViewTextBoxColumn
            // 
            this.invoicePlzDataGridViewTextBoxColumn.DataPropertyName = "invoicePlz";
            this.invoicePlzDataGridViewTextBoxColumn.HeaderText = "PLZ auf Rechnung";
            this.invoicePlzDataGridViewTextBoxColumn.Name = "invoicePlzDataGridViewTextBoxColumn";
            this.invoicePlzDataGridViewTextBoxColumn.Width = 124;
            // 
            // invoiceStreetDataGridViewTextBoxColumn
            // 
            this.invoiceStreetDataGridViewTextBoxColumn.DataPropertyName = "invoiceStreet";
            this.invoiceStreetDataGridViewTextBoxColumn.HeaderText = "Straße auf Rechnung";
            this.invoiceStreetDataGridViewTextBoxColumn.Name = "invoiceStreetDataGridViewTextBoxColumn";
            this.invoiceStreetDataGridViewTextBoxColumn.Width = 140;
            // 
            // invoiceCityDataGridViewTextBoxColumn
            // 
            this.invoiceCityDataGridViewTextBoxColumn.DataPropertyName = "invoiceCity";
            this.invoiceCityDataGridViewTextBoxColumn.HeaderText = "Stadt auf Rechnung";
            this.invoiceCityDataGridViewTextBoxColumn.Name = "invoiceCityDataGridViewTextBoxColumn";
            this.invoiceCityDataGridViewTextBoxColumn.Width = 133;
            // 
            // invoiceLandDataGridViewTextBoxColumn
            // 
            this.invoiceLandDataGridViewTextBoxColumn.DataPropertyName = "invoiceLand";
            this.invoiceLandDataGridViewTextBoxColumn.HeaderText = "Land auf Rechnung";
            this.invoiceLandDataGridViewTextBoxColumn.Name = "invoiceLandDataGridViewTextBoxColumn";
            this.invoiceLandDataGridViewTextBoxColumn.Width = 132;
            // 
            // invoiceTelefoneDataGridViewTextBoxColumn
            // 
            this.invoiceTelefoneDataGridViewTextBoxColumn.DataPropertyName = "invoiceTelefone";
            this.invoiceTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefon auf Rechnung";
            this.invoiceTelefoneDataGridViewTextBoxColumn.Name = "invoiceTelefoneDataGridViewTextBoxColumn";
            this.invoiceTelefoneDataGridViewTextBoxColumn.Width = 144;
            // 
            // invoiceTelefaxDataGridViewTextBoxColumn
            // 
            this.invoiceTelefaxDataGridViewTextBoxColumn.DataPropertyName = "invoiceTelefax";
            this.invoiceTelefaxDataGridViewTextBoxColumn.HeaderText = "Fax auf Rechnung";
            this.invoiceTelefaxDataGridViewTextBoxColumn.Name = "invoiceTelefaxDataGridViewTextBoxColumn";
            this.invoiceTelefaxDataGridViewTextBoxColumn.Width = 123;
            // 
            // invoiceEmailDataGridViewTextBoxColumn
            // 
            this.invoiceEmailDataGridViewTextBoxColumn.DataPropertyName = "invoiceEmail";
            this.invoiceEmailDataGridViewTextBoxColumn.HeaderText = "E-Mail auf Rechnung";
            this.invoiceEmailDataGridViewTextBoxColumn.Name = "invoiceEmailDataGridViewTextBoxColumn";
            this.invoiceEmailDataGridViewTextBoxColumn.Width = 140;
            // 
            // invoiceCommentDataGridViewTextBoxColumn
            // 
            this.invoiceCommentDataGridViewTextBoxColumn.DataPropertyName = "invoiceComment";
            this.invoiceCommentDataGridViewTextBoxColumn.HeaderText = "Bemerkung auf Rechnung";
            this.invoiceCommentDataGridViewTextBoxColumn.Name = "invoiceCommentDataGridViewTextBoxColumn";
            this.invoiceCommentDataGridViewTextBoxColumn.Width = 114;
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 690);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmContacts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmContacts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceCustomer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Button buttonNewAddress;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicePlzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceLandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTelefaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceCommentDataGridViewTextBoxColumn;
    }
}