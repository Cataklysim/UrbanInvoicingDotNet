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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.buttonNewAddress = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Size = new System.Drawing.Size(2004, 1313);
            this.splitContainer1.SplitterDistance = 656;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(1739, 113);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(253, 39);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Details";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoGenerateColumns = false;
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
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.MultiSelect = false;
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.Height = 28;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(2004, 653);
            this.dataGridViewCustomer.TabIndex = 0;
            this.dataGridViewCustomer.SelectionChanged += new System.EventHandler(this.dataGridViewCustomer_SelectionChanged);
            this.dataGridViewCustomer.DoubleClick += new System.EventHandler(this.dataGridViewCustomer_DoubleClick);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Location = new System.Drawing.Point(13, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(1702, 628);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // buttonNewAddress
            // 
            this.buttonNewAddress.Location = new System.Drawing.Point(1739, 23);
            this.buttonNewAddress.Name = "buttonNewAddress";
            this.buttonNewAddress.Size = new System.Drawing.Size(253, 39);
            this.buttonNewAddress.TabIndex = 2;
            this.buttonNewAddress.Text = "Neuer Kontakt";
            this.buttonNewAddress.UseVisualStyleBackColor = true;
            this.buttonNewAddress.Click += new System.EventHandler(this.buttonNewAddress_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(1739, 544);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(253, 39);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "Zurück zum Hauptmenü";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // plzDataGridViewTextBoxColumn
            // 
            this.plzDataGridViewTextBoxColumn.DataPropertyName = "plz";
            this.plzDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.plzDataGridViewTextBoxColumn.Name = "plzDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Straße";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Stadt";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // landDataGridViewTextBoxColumn
            // 
            this.landDataGridViewTextBoxColumn.DataPropertyName = "land";
            this.landDataGridViewTextBoxColumn.HeaderText = "Land";
            this.landDataGridViewTextBoxColumn.Name = "landDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // telefaxDataGridViewTextBoxColumn
            // 
            this.telefaxDataGridViewTextBoxColumn.DataPropertyName = "telefax";
            this.telefaxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.telefaxDataGridViewTextBoxColumn.Name = "telefaxDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Bemerkung";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // invoiceNameDataGridViewTextBoxColumn
            // 
            this.invoiceNameDataGridViewTextBoxColumn.DataPropertyName = "invoiceName";
            this.invoiceNameDataGridViewTextBoxColumn.HeaderText = "Vorname auf Rechnung";
            this.invoiceNameDataGridViewTextBoxColumn.Name = "invoiceNameDataGridViewTextBoxColumn";
            // 
            // invoiceLastNameDataGridViewTextBoxColumn
            // 
            this.invoiceLastNameDataGridViewTextBoxColumn.DataPropertyName = "invoiceLastName";
            this.invoiceLastNameDataGridViewTextBoxColumn.HeaderText = "Nachname auf Rechnung";
            this.invoiceLastNameDataGridViewTextBoxColumn.Name = "invoiceLastNameDataGridViewTextBoxColumn";
            // 
            // invoicePlzDataGridViewTextBoxColumn
            // 
            this.invoicePlzDataGridViewTextBoxColumn.DataPropertyName = "invoicePlz";
            this.invoicePlzDataGridViewTextBoxColumn.HeaderText = "PLZ auf Rechnung";
            this.invoicePlzDataGridViewTextBoxColumn.Name = "invoicePlzDataGridViewTextBoxColumn";
            // 
            // invoiceStreetDataGridViewTextBoxColumn
            // 
            this.invoiceStreetDataGridViewTextBoxColumn.DataPropertyName = "invoiceStreet";
            this.invoiceStreetDataGridViewTextBoxColumn.HeaderText = "Straße auf Rechnung";
            this.invoiceStreetDataGridViewTextBoxColumn.Name = "invoiceStreetDataGridViewTextBoxColumn";
            // 
            // invoiceCityDataGridViewTextBoxColumn
            // 
            this.invoiceCityDataGridViewTextBoxColumn.DataPropertyName = "invoiceCity";
            this.invoiceCityDataGridViewTextBoxColumn.HeaderText = "Stadt auf Rechnung";
            this.invoiceCityDataGridViewTextBoxColumn.Name = "invoiceCityDataGridViewTextBoxColumn";
            // 
            // invoiceLandDataGridViewTextBoxColumn
            // 
            this.invoiceLandDataGridViewTextBoxColumn.DataPropertyName = "invoiceLand";
            this.invoiceLandDataGridViewTextBoxColumn.HeaderText = "Land auf Rechnung";
            this.invoiceLandDataGridViewTextBoxColumn.Name = "invoiceLandDataGridViewTextBoxColumn";
            // 
            // invoiceTelefoneDataGridViewTextBoxColumn
            // 
            this.invoiceTelefoneDataGridViewTextBoxColumn.DataPropertyName = "invoiceTelefone";
            this.invoiceTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefon auf Rechnung";
            this.invoiceTelefoneDataGridViewTextBoxColumn.Name = "invoiceTelefoneDataGridViewTextBoxColumn";
            // 
            // invoiceTelefaxDataGridViewTextBoxColumn
            // 
            this.invoiceTelefaxDataGridViewTextBoxColumn.DataPropertyName = "invoiceTelefax";
            this.invoiceTelefaxDataGridViewTextBoxColumn.HeaderText = "Fax auf Rechnung";
            this.invoiceTelefaxDataGridViewTextBoxColumn.Name = "invoiceTelefaxDataGridViewTextBoxColumn";
            // 
            // invoiceEmailDataGridViewTextBoxColumn
            // 
            this.invoiceEmailDataGridViewTextBoxColumn.DataPropertyName = "invoiceEmail";
            this.invoiceEmailDataGridViewTextBoxColumn.HeaderText = "E-Mail auf Rechnung";
            this.invoiceEmailDataGridViewTextBoxColumn.Name = "invoiceEmailDataGridViewTextBoxColumn";
            // 
            // invoiceCommentDataGridViewTextBoxColumn
            // 
            this.invoiceCommentDataGridViewTextBoxColumn.DataPropertyName = "invoiceComment";
            this.invoiceCommentDataGridViewTextBoxColumn.HeaderText = "Bemerkung auf Rechnung";
            this.invoiceCommentDataGridViewTextBoxColumn.Name = "invoiceCommentDataGridViewTextBoxColumn";
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2004, 1313);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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