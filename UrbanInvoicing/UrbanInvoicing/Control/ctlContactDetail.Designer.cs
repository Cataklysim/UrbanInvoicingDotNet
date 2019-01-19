namespace UrbanInvoicing.Forms
{
    partial class ctlContactDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.comboBoxLandcode = new System.Windows.Forms.ComboBox();
            this.comboBoxInvoiceLandcode = new System.Windows.Forms.ComboBox();
            this.textBoxInvoiceCity = new System.Windows.Forms.TextBox();
            this.textBoxInvoicePostcode = new System.Windows.Forms.TextBox();
            this.textBoxInvoiceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxOtherInvoiceAdress = new System.Windows.Forms.CheckBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxInvoiceSurname = new System.Windows.Forms.TextBox();
            this.labelInvoiceSurname = new System.Windows.Forms.Label();
            this.textBoxInvoiceStreet = new System.Windows.Forms.TextBox();
            this.checkBoxCompany = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(35, 8);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(13, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vorname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Straße, Hausnr: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PLZ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Land: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ort:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "street", true));
            this.textBoxStreet.Location = new System.Drawing.Point(109, 86);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(229, 20);
            this.textBoxStreet.TabIndex = 7;
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(UrbanInvoicing.Classes.clsCustomer);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "name", true));
            this.textBoxName.Location = new System.Drawing.Point(109, 30);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(229, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "plz", true));
            this.textBoxPostcode.Location = new System.Drawing.Point(109, 116);
            this.textBoxPostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(68, 20);
            this.textBoxPostcode.TabIndex = 9;
            // 
            // textBoxCity
            // 
            this.textBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "city", true));
            this.textBoxCity.Location = new System.Drawing.Point(109, 148);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(229, 20);
            this.textBoxCity.TabIndex = 10;
            // 
            // comboBoxLandcode
            // 
            this.comboBoxLandcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "land", true));
            this.comboBoxLandcode.FormattingEnabled = true;
            this.comboBoxLandcode.Items.AddRange(new object[] {
            "AF",
            "AX",
            "AL",
            "DZ",
            "AS",
            "AD",
            "AO",
            "AI",
            "AQ",
            "AG",
            "AR",
            "AM",
            "AW",
            "AU",
            "AT",
            "AZ",
            "BS",
            "BH",
            "BD",
            "BB",
            "BY",
            "BE",
            "BZ",
            "BJ",
            "BM",
            "BT",
            "BO",
            "BQ",
            "BA",
            "BW",
            "BV",
            "BR",
            "IO",
            "VG",
            "BN",
            "BG",
            "BF",
            "BI",
            "KH",
            "CM",
            "CA",
            "CV",
            "KY",
            "CF",
            "TD",
            "CL",
            "CN",
            "CX",
            "CC",
            "CO",
            "KM",
            "CK",
            "CR",
            "HR",
            "CU",
            "CW",
            "CY",
            "CZ",
            "CD",
            "DK",
            "DJ",
            "DM",
            "DO",
            "TL",
            "EC",
            "EG",
            "SV",
            "GQ",
            "ER",
            "EE",
            "ET",
            "FK",
            "FO",
            "FJ",
            "FI",
            "FR",
            "GF",
            "PF",
            "TF",
            "GA",
            "GM",
            "GE",
            "DE",
            "GH",
            "GI",
            "GR",
            "GL",
            "GD",
            "GP",
            "GU",
            "GT",
            "GG",
            "GN",
            "GW",
            "GY",
            "HT",
            "HM",
            "HN",
            "HK",
            "HU",
            "IS",
            "IN",
            "ID",
            "IR",
            "IQ",
            "IE",
            "IM",
            "IL",
            "IT",
            "CI",
            "JM",
            "JP",
            "JE",
            "JO",
            "KZ",
            "KE",
            "KI",
            "XK",
            "KW",
            "KG",
            "LA",
            "LV",
            "LB",
            "LS",
            "LR",
            "LY",
            "LI",
            "LT",
            "LU",
            "MO",
            "MK",
            "MG",
            "MW",
            "MY",
            "MV",
            "ML",
            "MT",
            "MH",
            "MQ",
            "MR",
            "MU",
            "YT",
            "MX",
            "FM",
            "MD",
            "MC",
            "MN",
            "ME",
            "MS",
            "MA",
            "MZ",
            "MM",
            "NA",
            "NR",
            "NP",
            "NL",
            "AN",
            "NC",
            "NZ",
            "NI",
            "NE",
            "NG",
            "NU",
            "NF",
            "KP",
            "MP",
            "NO",
            "OM",
            "PK",
            "PW",
            "PS",
            "PA",
            "PG",
            "PY",
            "PE",
            "PH",
            "PN",
            "PL",
            "PT",
            "PR",
            "QA",
            "CG",
            "RE",
            "RO",
            "RU",
            "RW",
            "BL",
            "SH",
            "KN",
            "LC",
            "MF",
            "PM",
            "VC",
            "WS",
            "SM",
            "ST",
            "SA",
            "SN",
            "RS",
            "CS",
            "SC",
            "SL",
            "SG",
            "SX",
            "SK",
            "SI",
            "SB",
            "SO",
            "ZA",
            "GS",
            "KR",
            "SS",
            "ES",
            "LK",
            "SD",
            "SR",
            "SJ",
            "SZ",
            "SE",
            "CH",
            "SY",
            "TW",
            "TJ",
            "TZ",
            "TH",
            "TG",
            "TK",
            "TO",
            "TT",
            "TN",
            "TR",
            "TM",
            "TC",
            "TV",
            "VI",
            "UG",
            "UA",
            "AE",
            "GB",
            "US",
            "UM",
            "UY",
            "UZ",
            "VU",
            "VA",
            "VE",
            "VN",
            "WF",
            "EH",
            "YE",
            "ZM",
            "ZW"});
            this.comboBoxLandcode.Location = new System.Drawing.Point(109, 180);
            this.comboBoxLandcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLandcode.Name = "comboBoxLandcode";
            this.comboBoxLandcode.Size = new System.Drawing.Size(45, 21);
            this.comboBoxLandcode.TabIndex = 11;
            // 
            // comboBoxInvoiceLandcode
            // 
            this.comboBoxInvoiceLandcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "invoiceLand", true));
            this.comboBoxInvoiceLandcode.Enabled = false;
            this.comboBoxInvoiceLandcode.FormattingEnabled = true;
            this.comboBoxInvoiceLandcode.Items.AddRange(new object[] {
            "AF",
            "AX",
            "AL",
            "DZ",
            "AS",
            "AD",
            "AO",
            "AI",
            "AQ",
            "AG",
            "AR",
            "AM",
            "AW",
            "AU",
            "AT",
            "AZ",
            "BS",
            "BH",
            "BD",
            "BB",
            "BY",
            "BE",
            "BZ",
            "BJ",
            "BM",
            "BT",
            "BO",
            "BQ",
            "BA",
            "BW",
            "BV",
            "BR",
            "IO",
            "VG",
            "BN",
            "BG",
            "BF",
            "BI",
            "KH",
            "CM",
            "CA",
            "CV",
            "KY",
            "CF",
            "TD",
            "CL",
            "CN",
            "CX",
            "CC",
            "CO",
            "KM",
            "CK",
            "CR",
            "HR",
            "CU",
            "CW",
            "CY",
            "CZ",
            "CD",
            "DK",
            "DJ",
            "DM",
            "DO",
            "TL",
            "EC",
            "EG",
            "SV",
            "GQ",
            "ER",
            "EE",
            "ET",
            "FK",
            "FO",
            "FJ",
            "FI",
            "FR",
            "GF",
            "PF",
            "TF",
            "GA",
            "GM",
            "GE",
            "DE",
            "GH",
            "GI",
            "GR",
            "GL",
            "GD",
            "GP",
            "GU",
            "GT",
            "GG",
            "GN",
            "GW",
            "GY",
            "HT",
            "HM",
            "HN",
            "HK",
            "HU",
            "IS",
            "IN",
            "ID",
            "IR",
            "IQ",
            "IE",
            "IM",
            "IL",
            "IT",
            "CI",
            "JM",
            "JP",
            "JE",
            "JO",
            "KZ",
            "KE",
            "KI",
            "XK",
            "KW",
            "KG",
            "LA",
            "LV",
            "LB",
            "LS",
            "LR",
            "LY",
            "LI",
            "LT",
            "LU",
            "MO",
            "MK",
            "MG",
            "MW",
            "MY",
            "MV",
            "ML",
            "MT",
            "MH",
            "MQ",
            "MR",
            "MU",
            "YT",
            "MX",
            "FM",
            "MD",
            "MC",
            "MN",
            "ME",
            "MS",
            "MA",
            "MZ",
            "MM",
            "NA",
            "NR",
            "NP",
            "NL",
            "AN",
            "NC",
            "NZ",
            "NI",
            "NE",
            "NG",
            "NU",
            "NF",
            "KP",
            "MP",
            "NO",
            "OM",
            "PK",
            "PW",
            "PS",
            "PA",
            "PG",
            "PY",
            "PE",
            "PH",
            "PN",
            "PL",
            "PT",
            "PR",
            "QA",
            "CG",
            "RE",
            "RO",
            "RU",
            "RW",
            "BL",
            "SH",
            "KN",
            "LC",
            "MF",
            "PM",
            "VC",
            "WS",
            "SM",
            "ST",
            "SA",
            "SN",
            "RS",
            "CS",
            "SC",
            "SL",
            "SG",
            "SX",
            "SK",
            "SI",
            "SB",
            "SO",
            "ZA",
            "GS",
            "KR",
            "SS",
            "ES",
            "LK",
            "SD",
            "SR",
            "SJ",
            "SZ",
            "SE",
            "CH",
            "SY",
            "TW",
            "TJ",
            "TZ",
            "TH",
            "TG",
            "TK",
            "TO",
            "TT",
            "TN",
            "TR",
            "TM",
            "TC",
            "TV",
            "VI",
            "UG",
            "UA",
            "AE",
            "GB",
            "US",
            "UM",
            "UY",
            "UZ",
            "VU",
            "VA",
            "VE",
            "VN",
            "WF",
            "EH",
            "YE",
            "ZM",
            "ZW"});
            this.comboBoxInvoiceLandcode.Location = new System.Drawing.Point(553, 180);
            this.comboBoxInvoiceLandcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxInvoiceLandcode.Name = "comboBoxInvoiceLandcode";
            this.comboBoxInvoiceLandcode.Size = new System.Drawing.Size(45, 21);
            this.comboBoxInvoiceLandcode.TabIndex = 21;
            // 
            // textBoxInvoiceCity
            // 
            this.textBoxInvoiceCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "invoiceCity", true));
            this.textBoxInvoiceCity.Location = new System.Drawing.Point(553, 148);
            this.textBoxInvoiceCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInvoiceCity.Name = "textBoxInvoiceCity";
            this.textBoxInvoiceCity.ReadOnly = true;
            this.textBoxInvoiceCity.Size = new System.Drawing.Size(229, 20);
            this.textBoxInvoiceCity.TabIndex = 20;
            // 
            // textBoxInvoicePostcode
            // 
            this.textBoxInvoicePostcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "invoicePlz", true));
            this.textBoxInvoicePostcode.Location = new System.Drawing.Point(553, 116);
            this.textBoxInvoicePostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInvoicePostcode.Name = "textBoxInvoicePostcode";
            this.textBoxInvoicePostcode.ReadOnly = true;
            this.textBoxInvoicePostcode.Size = new System.Drawing.Size(68, 20);
            this.textBoxInvoicePostcode.TabIndex = 19;
            // 
            // textBoxInvoiceName
            // 
            this.textBoxInvoiceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "invoiceName", true));
            this.textBoxInvoiceName.Location = new System.Drawing.Point(553, 30);
            this.textBoxInvoiceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInvoiceName.Name = "textBoxInvoiceName";
            this.textBoxInvoiceName.ReadOnly = true;
            this.textBoxInvoiceName.Size = new System.Drawing.Size(229, 20);
            this.textBoxInvoiceName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ort:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Land: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "PLZ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Straße, Hausnr: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Vorname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(453, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Rechnungsadresse:";
            this.label12.Visible = false;
            // 
            // checkBoxOtherInvoiceAdress
            // 
            this.checkBoxOtherInvoiceAdress.AutoSize = true;
            this.checkBoxOtherInvoiceAdress.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCustomer, "useOtherAdress", true));
            this.checkBoxOtherInvoiceAdress.Location = new System.Drawing.Point(11, 247);
            this.checkBoxOtherInvoiceAdress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxOtherInvoiceAdress.Name = "checkBoxOtherInvoiceAdress";
            this.checkBoxOtherInvoiceAdress.Size = new System.Drawing.Size(155, 17);
            this.checkBoxOtherInvoiceAdress.TabIndex = 23;
            this.checkBoxOtherInvoiceAdress.Text = "Andere Rechnungsadresse";
            this.checkBoxOtherInvoiceAdress.UseVisualStyleBackColor = true;
            this.checkBoxOtherInvoiceAdress.CheckedChanged += new System.EventHandler(this.checkBoxOtherInvoiceAdress_CheckedChanged);
            // 
            // textBoxComment
            // 
            this.textBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "comment", true));
            this.textBoxComment.Location = new System.Drawing.Point(109, 402);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(229, 112);
            this.textBoxComment.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 402);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Bemerkung";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(891, 30);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 30);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(891, 66);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(105, 30);
            this.buttonRemove.TabIndex = 27;
            this.buttonRemove.Text = "Entfernen";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "telefone", true));
            this.textBoxPhone.Location = new System.Drawing.Point(109, 286);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(229, 20);
            this.textBoxPhone.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 288);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Telefon:";
            // 
            // textBoxFax
            // 
            this.textBoxFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "telefax", true));
            this.textBoxFax.Location = new System.Drawing.Point(109, 318);
            this.textBoxFax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(229, 20);
            this.textBoxFax.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 320);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Telefax:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "email", true));
            this.textBoxMail.Location = new System.Drawing.Point(109, 350);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(229, 20);
            this.textBoxMail.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 352);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "E-Mail:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "lastName", true));
            this.textBoxSurname.Location = new System.Drawing.Point(109, 51);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(229, 20);
            this.textBoxSurname.TabIndex = 36;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(9, 55);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 13);
            this.labelSurname.TabIndex = 35;
            this.labelSurname.Text = "Nachname";
            // 
            // textBoxInvoiceSurname
            // 
            this.textBoxInvoiceSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "invoiceLastName", true));
            this.textBoxInvoiceSurname.Location = new System.Drawing.Point(553, 51);
            this.textBoxInvoiceSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInvoiceSurname.Name = "textBoxInvoiceSurname";
            this.textBoxInvoiceSurname.ReadOnly = true;
            this.textBoxInvoiceSurname.Size = new System.Drawing.Size(229, 20);
            this.textBoxInvoiceSurname.TabIndex = 38;
            // 
            // labelInvoiceSurname
            // 
            this.labelInvoiceSurname.AutoSize = true;
            this.labelInvoiceSurname.Location = new System.Drawing.Point(453, 55);
            this.labelInvoiceSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInvoiceSurname.Name = "labelInvoiceSurname";
            this.labelInvoiceSurname.Size = new System.Drawing.Size(59, 13);
            this.labelInvoiceSurname.TabIndex = 37;
            this.labelInvoiceSurname.Text = "Nachname";
            // 
            // textBoxInvoiceStreet
            // 
            this.textBoxInvoiceStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "invoiceStreet", true));
            this.textBoxInvoiceStreet.Location = new System.Drawing.Point(553, 86);
            this.textBoxInvoiceStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInvoiceStreet.Name = "textBoxInvoiceStreet";
            this.textBoxInvoiceStreet.ReadOnly = true;
            this.textBoxInvoiceStreet.Size = new System.Drawing.Size(229, 20);
            this.textBoxInvoiceStreet.TabIndex = 17;
            // 
            // checkBoxCompany
            // 
            this.checkBoxCompany.AutoSize = true;
            this.checkBoxCompany.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCustomer, "isCompany", true));
            this.checkBoxCompany.Location = new System.Drawing.Point(11, 215);
            this.checkBoxCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCompany.Name = "checkBoxCompany";
            this.checkBoxCompany.Size = new System.Drawing.Size(51, 17);
            this.checkBoxCompany.TabIndex = 39;
            this.checkBoxCompany.Text = "Firma";
            this.checkBoxCompany.UseVisualStyleBackColor = true;
            this.checkBoxCompany.CheckedChanged += new System.EventHandler(this.checkBoxCompany_CheckedChanged);
            // 
            // ctlContactDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCompany);
            this.Controls.Add(this.textBoxInvoiceSurname);
            this.Controls.Add(this.labelInvoiceSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.checkBoxOtherInvoiceAdress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxInvoiceLandcode);
            this.Controls.Add(this.textBoxInvoiceCity);
            this.Controls.Add(this.textBoxInvoicePostcode);
            this.Controls.Add(this.textBoxInvoiceName);
            this.Controls.Add(this.textBoxInvoiceStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxLandcode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPostcode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ctlContactDetail";
            this.Size = new System.Drawing.Size(1074, 581);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.ComboBox comboBoxLandcode;
        private System.Windows.Forms.ComboBox comboBoxInvoiceLandcode;
        private System.Windows.Forms.TextBox textBoxInvoiceCity;
        private System.Windows.Forms.TextBox textBoxInvoicePostcode;
        private System.Windows.Forms.TextBox textBoxInvoiceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxOtherInvoiceAdress;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource bindingSourceCustomer;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxInvoiceSurname;
        private System.Windows.Forms.Label labelInvoiceSurname;
        private System.Windows.Forms.TextBox textBoxInvoiceStreet;
        private System.Windows.Forms.CheckBox checkBoxCompany;
    }
}