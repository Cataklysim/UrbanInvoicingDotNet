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
    public partial class ctlContactDetail : UserControl
    {
        private List<clsCustomer> _Customer { get; set; }
        private List<string> _CountryList { get; set; }
        public ctlContactDetail()
        {
            this._Customer = new List<clsCustomer>();
            this._Customer.Add(new clsCustomer());
            this.bindingSourceCustomer = new BindingSource();
            this.bindingSourceCustomer.DataSource = this._Customer;
            InitializeComponent();
        }

        public ctlContactDetail(clsCustomer pCustomer)
        {
            this._Customer = new List<clsCustomer>();
            this._Customer.Add(pCustomer);
            InitializeComponent();
            this.bindingSourceCustomer.DataSource = pCustomer;
        }

        private void checkBoxOtherInvoiceAdress_CheckedChanged(object sender, EventArgs e)
        {
            bool tmpVisible = !this.checkBoxOtherInvoiceAdress.Checked;

            this.textBoxInvoiceCity.ReadOnly = tmpVisible;
            this.textBoxInvoiceName.ReadOnly = tmpVisible;
            this.textBoxInvoicePostcode.ReadOnly = tmpVisible;
            this.textBoxInvoiceStreet.ReadOnly = tmpVisible;
            this.comboBoxInvoiceLandcode.Enabled = !tmpVisible;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<clsCustomer> tmpList = (List<clsCustomer>)this.bindingSourceCustomer.DataSource;
            clsCustomer tmpCustomer = tmpList.FirstOrDefault();
            if (tmpCustomer != null)
            {
                if (!clsCustomer.NameOnDb(tmpCustomer.name))
                {
                    try
                    {
                        tmpCustomer.Save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Es gab einen Fehler beim Speichern der Adresse. Fehler: " + ex.Message, "Fehler beim Speichern", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Es gibt bereits einen Kunden mit diesem Namen im Adressbuch.\r\nBitte bearbeiten Sie diesen oder nehmen Sie einen anderen Namen.", "Name bereits vorhanden", MessageBoxButtons.OK);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this._Customer.FirstOrDefault().Id > 0)
            {
                DialogResult tmpResult = MessageBox.Show("Sind Sie sich sicher diesen Kunden zu löschen? ", "Löschen", MessageBoxButtons.YesNo);
                if (tmpResult == DialogResult.Yes)
                {
                    List<clsCustomer> tmpList = (List<clsCustomer>)this.bindingSourceCustomer.DataSource;
                    clsCustomer tmpCustomer = tmpList.FirstOrDefault();
                    if (tmpCustomer != null)
                    {
                        tmpCustomer.DeleteOnDb();
                        this._Customer = new List<clsCustomer>();
                    }
                }
            }
        }

        private void checkBoxCompany_CheckedChanged(object sender, EventArgs e)
        {
            this.labelSurname.Visible = this.checkBoxCompany.Checked;
            this.textBoxSurname.Visible = this.checkBoxCompany.Checked;
            this.labelInvoiceSurname.Visible = this.checkBoxCompany.Checked;
            this.textBoxInvoiceSurname.Visible = this.checkBoxCompany.Checked;
        }
    }
}
