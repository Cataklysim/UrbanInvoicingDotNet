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
            InitializeComponent();
            this.LoadList();
        }

        public ctlContactDetail(clsCustomer pCustomer)
        {
            this._Customer = new List<clsCustomer>();
            this._Customer.Add(pCustomer);
            this.bindingSourceCustomer.DataSource = this._Customer;
            InitializeComponent();
            this.LoadList();
            this.load();
        }

        private void load()
        {
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
        private void LoadList()
        {
            this._CountryList = new List<string>();
            this._CountryList.Add("B");
            this._CountryList.Add("BG");
            this._CountryList.Add("DK");
            this._CountryList.Add("D");
            this._CountryList.Add("EST");
            this._CountryList.Add("FIN");
            this._CountryList.Add("F");
            this._CountryList.Add("GR");
            this._CountryList.Add("IRL");
            this._CountryList.Add("I");
            this._CountryList.Add("HR");
            this._CountryList.Add("LV");
            this._CountryList.Add("LT");
            this._CountryList.Add("L");
            this._CountryList.Add("M");
            this._CountryList.Add("NL");
            this._CountryList.Add("A");
            this._CountryList.Add("PL");
            this._CountryList.Add("P");
            this._CountryList.Add("RO");
            this._CountryList.Add("S");
            this._CountryList.Add("SK");
            this._CountryList.Add("SLO");
            this._CountryList.Add("E");
            this._CountryList.Add("CZ");
            this._CountryList.Add("H");
            this._CountryList.Add("GB");
            this._CountryList.Add("Z");
            this.bindingSourceCountryList.DataSource = this._CountryList;
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

        private void checkBoxCompany_CheckedChanged(object sender, EventArgs e)
        {
            this.labelSurname.Visible = this.checkBoxCompany.Checked;
            this.textBoxSurname.Visible = this.checkBoxCompany.Checked;
            this.labelInvoiceSurname.Visible = this.checkBoxCompany.Checked;
            this.textBoxInvoiceSurname.Visible = this.checkBoxCompany.Checked;
        }
    }
}
