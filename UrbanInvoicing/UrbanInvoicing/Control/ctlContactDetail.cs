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
        private clsCustomer _Customer { get; set; }
        private List<string> _CountryList { get; set; }
        public ctlContactDetail()
        {
            InitializeComponent();

        }

        public void LoadOrCreateCustomer(clsCustomer pCustomer = null)
        {
            if (pCustomer == null)
            {
                this.labelNew.Visible = true;
                this._Customer = new clsCustomer();
                this.bindingSourceCustomer.DataSource = this._Customer;
            }
            else
            {
                this.labelNew.Visible = false;
                this._Customer = pCustomer;
                this.bindingSourceCustomer.DataSource = pCustomer;
            }
            this.Refresh();
        }

        private void checkBoxOtherInvoiceAdress_CheckedChanged(object sender, EventArgs e)
        {
            bool tmpVisible = !this.checkBoxOtherInvoiceAdress.Checked;

            this.textBoxInvoiceCity.ReadOnly = tmpVisible;
            this.textBoxInvoiceName.ReadOnly = tmpVisible;
            this.textBoxInvoiceSurname.ReadOnly = tmpVisible;
            this.textBoxInvoicePostcode.ReadOnly = tmpVisible;
            this.textBoxInvoiceStreet.ReadOnly = tmpVisible;
            this.comboBoxInvoiceLandcode.Enabled = !tmpVisible;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            clsCustomer tmpCustomer = (this.bindingSourceCustomer.DataSource as clsCustomer);
            if (tmpCustomer != null)
            {
                if (!clsCustomer.NameOnDb(tmpCustomer.name))
                {
                    try
                    {
                        tmpCustomer.comment = "";
                        if (!tmpCustomer.useOtherAdress)
                        {
                            tmpCustomer.invoiceName = tmpCustomer.name;
                            tmpCustomer.invoiceLastName = tmpCustomer.lastName;
                            tmpCustomer.invoiceCity = tmpCustomer.city;
                            tmpCustomer.invoiceStreet = tmpCustomer.street;
                            tmpCustomer.invoiceLand = tmpCustomer.land;
                            tmpCustomer.invoiceEmail = tmpCustomer.email;
                            tmpCustomer.invoicePlz = tmpCustomer.plz;
                            tmpCustomer.invoiceTelefax = tmpCustomer.telefax;
                            tmpCustomer.invoiceTelefone = tmpCustomer.telefone;
                        }
                        if (tmpCustomer.Save())
                        {
                            MessageBox.Show("Daten wurden erfolgreich gespeichert", "Gespeichert", MessageBoxButtons.OK);

                            if (this.labelNew.Visible)
                                this.labelNew.Visible = false;
                        }
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
            clsCustomer tmpCustomer = (this.bindingSourceCustomer.DataSource as clsCustomer);
            if (tmpCustomer.id> 0)
            {
                DialogResult tmpResult = MessageBox.Show("Sind Sie sich sicher diesen Kunden zu löschen? ", "Löschen", MessageBoxButtons.YesNo);
                if (tmpResult == DialogResult.Yes)
                {
                    

                    if (tmpCustomer != null)
                    {
                        tmpCustomer.DeleteOnDb();
                        this._Customer = new clsCustomer();
                        this.bindingSourceCustomer.DataSource = this._Customer;
                        MessageBox.Show("Erfolgreich gelöscht", "Erfolg", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void checkBoxCompany_CheckedChanged(object sender, EventArgs e)
        {
            this.labelSurname.Visible = !this.checkBoxCompany.Checked;
            this.textBoxSurname.Visible = !this.checkBoxCompany.Checked;
            this.labelInvoiceSurname.Visible = !this.checkBoxCompany.Checked;
            this.textBoxInvoiceSurname.Visible = !this.checkBoxCompany.Checked;

            if(this.checkBoxCompany.Checked)
            {
                this.labelFirstName.Text = "Name:";
                this.labelInvoiceFirstname.Text = "Name:";
            }
            else
            {
                this.labelFirstName.Text = "Vorname:";
                this.labelInvoiceFirstname.Text = "Vorname:";
            }
        }
    }
}
