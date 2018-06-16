using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanInvoicing.Classes;

namespace UrbanInvoicing.Forms
{
    public partial class frmContactDetail : Form
    {
        private clsCustomer _Customer;
        public frmContactDetail()
        {
            this._Customer = new clsCustomer();
            InitializeComponent();
        }

        public frmContactDetail(clsCustomer pCustomer)
        {
            this._Customer = pCustomer;
            InitializeComponent();
            load();
        }

        private void load()
        {
            this.textBoxCity.Text = _Customer.city;
            this.textBoxComment.Text = _Customer.comment;
            this.textBoxName.Text = _Customer.name;
            this.textBoxPostcode.Text = _Customer.plz;
            this.textBoxStreet.Text = _Customer.street;
            this.textBoxFax.Text = _Customer.telefax;
            this.textBoxPhone.Text = _Customer.telefone;
            this.textBoxMail.Text = _Customer.email;
            this.textBoxInvoiceCity.Text = _Customer.invoiceCity;
            this.textBoxInvoiceName.Text = _Customer.invoiceName;
            this.textBoxInvoicePostcode.Text = _Customer.invoicePlz;
            this.textBoxInvoiceStreet.Text = _Customer.invoiceStreet;

        }

        private void checkBoxOtherInvoiceAdress_CheckedChanged(object sender, EventArgs e)
        {
            bool tmpVisible = this.checkBoxOtherInvoiceAdress.Checked;

            this.label7.Visible = tmpVisible;
            this.label8.Visible = tmpVisible;
            this.label9.Visible = tmpVisible;
            this.label10.Visible = tmpVisible;
            this.label11.Visible = tmpVisible;
            this.label12.Visible = tmpVisible;
            this.textBoxInvoiceCity.Visible = tmpVisible;
            this.textBoxInvoiceName.Visible = tmpVisible;
            this.textBoxInvoicePostcode.Visible = tmpVisible;
            this.textBoxInvoiceStreet.Visible = tmpVisible;
            this.comboBoxInvoiceLandcode.Visible = tmpVisible;
        }

    }
}
