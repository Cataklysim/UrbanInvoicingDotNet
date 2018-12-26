using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanInvoicing.Classes;


/*ToDo: Wenn nach dem Kauf teile der Rechnung zurückgegeben werden müssen 
wir das Implementieren, dass die Rechnung rückwirkend geändert werden kann. */
namespace UrbanInvoicing.Forms
{
    public partial class frmImport : Form
    {
        static int _CellValueChangedEventCounter;
        public frmImport()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                clsInvoice tmpNewInvoice = new clsInvoice()
                {
                    customerId = (int)this.comboBoxCustomers.SelectedValue,
                    date = this.dateTimePicker.Value,
                    Id = 1,
                    sumBrutto = Convert.ToDouble(this.labelSumGross.Text),
                    sumNetto = Convert.ToDouble(this.labelSumNet.Text),
                    sumMwst = Convert.ToDouble(this.labelVatSum.Text),
                    invoiceNumber = this.textBoxInvoiceNumber.Text,
                    IsExport= false,
                };

                tmpNewInvoice.invoicePositions = new List<clsInvoicePosition>();
                this.dataGridViewInvoicePositions.EndEdit();
                foreach (clsInvoicePosition tmpItem in this.bindingSourcePositions.List)
                {
                    tmpNewInvoice.invoicePositions.Add(tmpItem);
                }

                if (tmpNewInvoice.Save())
                {
                    MessageBox.Show("Rechnung gespeichert!", "Gespeichert", MessageBoxButtons.OK);
                    this.Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Speichern Fehlgeschlagen", "Fehler", MessageBoxButtons.OK);
                Debug.WriteLine("Error while save in frmImport: " + ex.Message + " \r\n" + ex.StackTrace);
            }
        }

        private void Reset()
        {
            this.comboBoxCustomers.SelectedIndex = 0;
            this.bindingSourcePositions.Clear();
            this.labelSumGross.Text = "0";
            this.labelSumNet.Text = "0";
            this.labelVatSum.Text = "0";
            this.dateTimePicker.Value = DateTime.Now;
            this.textBoxInvoiceNumber.Text = "";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewInvoicePositions.SelectedRows.Count == 1)
            {
                DataGridViewRow tmpSelectedRow = this.dataGridViewInvoicePositions.CurrentRow;
                if (tmpSelectedRow != null)
                    this.dataGridViewInvoicePositions.Rows.Remove(tmpSelectedRow);
            }
        }

        private void dataGridViewInvoicePositions_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            // Needed? -F


            // Change sum in labels

            //clsInvoicePosition tmpTestInvoicePosition = new clsInvoicePosition();
            //tmpTestInvoicePosition.Brutto = Convert.ToDouble(e.Row.Cells["bruttoDataGridViewTextBoxColumn"]);
            //tmpTestInvoicePosition.Netto = Convert.ToDouble(e.Row.Cells["nettoDataGridViewTextBoxColumn"]);
            //tmpTestInvoicePosition.MwSt = Convert.ToDouble(e.Row.Cells["mwStDataGridViewTextBoxColumn"]);
            //tmpTestInvoicePosition.Rabatt = Convert.ToDouble(e.Row.Cells["rabattDataGridViewTextBoxColumn"]);




            ////Put some logical code in here with smart math stuff

            //this.labelSumGross.Text = tmpTestInvoicePosition.Brutto.ToString();
            //this.labelSumNet.Text = tmpTestInvoicePosition.Netto.ToString();
            //this.labelVatSum.Text = tmpTestInvoicePosition.MwSt.ToString();
        }

        private void dataGridViewInvoicePositions_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.calcSums();
        }

        private void dataGridViewInvoicePositions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewInvoicePositions.Columns[e.ColumnIndex].Name == "comboBoxArticle")
                this.dataGridViewInvoicePositions["mwStDataGridViewTextBoxColumn", e.RowIndex].Value = clsArticle.GetMwst(this.dataGridViewInvoicePositions[e.ColumnIndex, e.RowIndex].FormattedValue.ToString());
            this.calcSums();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            this.bindingSourceCustomers.DataSource = clsCustomer.GetCustomerFromDB();
            this.bindingSourceArtikel.DataSource = clsArticle.GetArticlesFromDB();
            this.bindingSourceTypen.DataSource = clsType.GetTypesFromDB();
            this.dateTimePicker.Value = DateTime.Now;
            this.LoadRepositories();
        }

        public void RefreshDataSources()
        {
            this.bindingSourceCustomers.DataSource = clsCustomer.GetCustomerFromDB();
            this.bindingSourceArtikel.DataSource = clsArticle.GetArticlesFromDB();
            this.bindingSourceTypen.DataSource = clsType.GetTypesFromDB();
        }

        public void LoadRepositories()
        {
            List<clsArticle> tmpArticles = new List<clsArticle>();
            List<clsType> tmpTypes = new List<clsType>();
            DataGridViewComboBoxColumn tmpComboBoxArticle = new DataGridViewComboBoxColumn()
            {
                DataSource = this.bindingSourceArtikel,
                DisplayMember = "name",
                ValueMember = "id",
                HeaderText = "Artikel",
                Name = "comboBoxArticle",
            };
            DataGridViewComboBoxColumn tmpComboBoxType = new DataGridViewComboBoxColumn()
            {
                DataSource = this.bindingSourceTypen,
                DisplayMember = "name",
                ValueMember = "id",
                HeaderText = "Typ",
                Name = "comboBoxType",
            };
            int tmpArtikelIndex = this.dataGridViewInvoicePositions.Columns["artikelIdDataGridViewTextBoxColumn"].DisplayIndex;
            tmpComboBoxArticle.DataPropertyName = this.dataGridViewInvoicePositions.Columns["artikelIdDataGridViewTextBoxColumn"].DataPropertyName;
            int tmpTypIndex = this.dataGridViewInvoicePositions.Columns["typeIdDataGridViewTextBoxColumn"].DisplayIndex;
            tmpComboBoxType.DataPropertyName = this.dataGridViewInvoicePositions.Columns["typeIdDataGridViewTextBoxColumn"].DataPropertyName;
            tmpComboBoxArticle.DisplayIndex = tmpArtikelIndex;
            tmpComboBoxArticle.AutoComplete = true;
            tmpComboBoxType.DisplayIndex = tmpTypIndex;
            tmpComboBoxType.AutoComplete = true;
            this.dataGridViewInvoicePositions.Columns.Add(tmpComboBoxArticle);
            this.dataGridViewInvoicePositions.Columns.Add(tmpComboBoxType);
        }

        public void calcSums()
        {
            if (this.dataGridViewInvoicePositions.RowCount > 0)
            {
                for (int i = 0; this.dataGridViewInvoicePositions.ColumnCount > i; i++)
                {
                    if (this.dataGridViewInvoicePositions.Columns[i].Name == "bruttoDataGridViewTextBoxColumn" ||
                        this.dataGridViewInvoicePositions.Columns[i].Name == "nettoDataGridViewTextBoxColumn" ||
                        this.dataGridViewInvoicePositions.Columns[i].Name == "rabattDataGridViewTextBoxColumn")
                    {
                        double tmpCalc = 0;

                        for (int j = 0; this.dataGridViewInvoicePositions.RowCount > j; j++)
                        {
                            if (this.dataGridViewInvoicePositions[i, j].Value != null)
                            {
                                tmpCalc += Math.Round(Convert.ToDouble(this.dataGridViewInvoicePositions[i, j].Value), 2);
                            }
                        }
                        if (this.dataGridViewInvoicePositions.Columns[i].Name == "bruttoDataGridViewTextBoxColumn")
                        {
                            this.labelSumGross.Text = tmpCalc.ToString();
                        }
                        if (this.dataGridViewInvoicePositions.Columns[i].Name == "nettoDataGridViewTextBoxColumn")
                        {
                            this.labelSumNet.Text = tmpCalc.ToString();
                        }
                        if (this.dataGridViewInvoicePositions.Columns[i].Name == "rabattDataGridViewTextBoxColumn")
                        {
                            //Rabatto kann noch gemacht werden wird aber nichtmal angezeigt
                        }
                    }

                    if (this.dataGridViewInvoicePositions.Columns[i].Name == "mwStDataGridViewTextBoxColumn" && (this.labelSumGross.Text != "0" || this.labelSumNet.Text != "0"))
                    {
                        double tmpMwSt = 0;
                        for (int j = 0; j < this.dataGridViewInvoicePositions.RowCount - 1; j++)
                        {
                            if (this.dataGridViewInvoicePositions[i, j].Value != null && this.dataGridViewInvoicePositions["mwStDataGridViewTextBoxColumn", j].Value != null)
                            {
                                if (this.labelSumGross.Text != "0")
                                    tmpMwSt += Math.Round(Convert.ToDouble(this.dataGridViewInvoicePositions["mwStDataGridViewTextBoxColumn", j].Value) / 100 * Convert.ToDouble(this.dataGridViewInvoicePositions["nettoDataGridViewTextBoxColumn", j].Value), 2);
                            }
                        }
                        this.labelVatSum.Text = tmpMwSt.ToString();
                    }
                }
            }
        }

        public void calcRow(int pRow)
        {
            double[] tmpValues = getBruttoNettoMwStFromDatagridRow(pRow);

            //MwSt Calc
            if (tmpValues[0] > 0 && tmpValues[1] > 0 && tmpValues[2] == 0)
            {
                this.dataGridViewInvoicePositions["mwStDataGridViewTextBoxColumn", pRow].Value = Math.Round(((tmpValues[0] - tmpValues[1]) * 100) / (tmpValues[1]), 2);
            }
            //Netto Calc
            if (tmpValues[0] > 0 && tmpValues[1] == 0)
            {
                if (tmpValues[2] > 0)
                    //this.dataGridViewInvoicePositions["nettoDataGridViewTextBoxColumn", pRow].Value = Math.Round((tmpValues[0] - ((tmpValues[0] / 100) * tmpValues[2])), 2);
                    this.dataGridViewInvoicePositions["nettoDataGridViewTextBoxColumn", pRow].Value = Math.Round(tmpValues[0] - ((tmpValues[0] * tmpValues[2]) / (100 + tmpValues[2])), 2);
                else
                    this.dataGridViewInvoicePositions["nettoDataGridViewTextBoxColumn", pRow].Value = Math.Round(tmpValues[0], 2);
            }
            //Brutto Calc
            if (tmpValues[0] == 0 && tmpValues[1] > 0)
            {
                if (tmpValues[2] > 0)
                    this.dataGridViewInvoicePositions["bruttoDataGridViewTextBoxColumn", pRow].Value = Math.Round(tmpValues[1] * (1 + (tmpValues[2] / 100)), 2);
                else
                    this.dataGridViewInvoicePositions["bruttoDataGridViewTextBoxColumn", pRow].Value = Math.Round(tmpValues[0], 2);
            }

        }

        /// <summary>
        /// Fills List with 
        /// brutto
        /// netto 
        /// mwst
        /// (in this order)
        /// </summary>
        /// <param name="pRow"></param>
        /// <returns>Array with brutto && netto && mwst from selected row</returns>
        public double[] getBruttoNettoMwStFromDatagridRow(int pRow)
        {
            double[] tmpResult = { 0, 0, 0 };
            for (int i = 0; this.dataGridViewInvoicePositions.ColumnCount > i; i++)
            {
                if (this.dataGridViewInvoicePositions.Columns[i].Name.Equals("bruttoDataGridViewTextBoxColumn"))
                    if (this.dataGridViewInvoicePositions["bruttoDataGridViewTextBoxColumn", pRow].Value != null)
                    {
                        tmpResult[0] = (Convert.ToDouble(this.dataGridViewInvoicePositions["bruttoDataGridViewTextBoxColumn", pRow].Value));
                    }
                    else tmpResult[0] = 0.00;
                if (this.dataGridViewInvoicePositions.Columns[i].Name.Equals("nettoDataGridViewTextBoxColumn"))
                    if (this.dataGridViewInvoicePositions["nettoDataGridViewTextBoxColumn", pRow].Value != null)
                    {
                        tmpResult[1] = (Convert.ToDouble(this.dataGridViewInvoicePositions["nettoDataGridViewTextBoxColumn", pRow].Value));
                    }
                    else tmpResult[1] = 0.00;
                if (this.dataGridViewInvoicePositions.Columns[i].Name.Equals("mwStDataGridViewTextBoxColumn"))
                    if (this.dataGridViewInvoicePositions["mwStDataGridViewTextBoxColumn", pRow].Value != null)
                    {
                        tmpResult[2] = (Convert.ToDouble(this.dataGridViewInvoicePositions["mwStDataGridViewTextBoxColumn", pRow].Value));
                    }
                    else tmpResult[2] = 0.00;
            }
            return tmpResult;
        }

        private void dataGridViewInvoicePositions_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewInvoicePositions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool tmpIsValid = true;
            DataGridViewColumn tmpCurrentColumn = this.dataGridViewInvoicePositions.Columns[e.ColumnIndex];

            if (e.RowIndex >= 0)
            {
                object tmpCurrentValue = this.dataGridViewInvoicePositions[e.ColumnIndex, e.RowIndex].Value;
                string tmpCaption = "Caption", tmpMessage = "Message";

                if (tmpCurrentColumn != null)
                {

                    if (tmpCurrentColumn.Name == "bemerkungDataGridViewTextBoxColumn")
                    {
                        //if (tmpIsValid)
                        //    this.dataGridViewInvoicePositions.CancelEdit();
                    }
                    else if (tmpCurrentColumn.Name == "comboBoxArticle")
                    {
                        if (this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells[tmpCurrentColumn.Name].Value != null)
                        {
                            IBindingList tmpList = this.bindingSourceArtikel;

                            //  get property descriptions
                            //PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(new clsInvoice());
                            ////  get specific descriptor
                            //PropertyDescriptor property = properties.Find("id", false);

                            //var tmpIndex = tmpList.Find(property, (int)this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells[tmpCurrentColumn.Name].Value);
                            //if (tmpIndex != null)
                            //{
                            //    clsArticle tmpArticle = tmpIndex.ToString();
                            //    if (tmpArticle != null)
                            //        if (this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells["mwStDataGridViewTextBoxColumn"].Value != null && this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells["mwStDataGridViewTextBoxColumn"].Value.ToString() == "0")
                            //            this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells["mwStDataGridViewTextBoxColumn"].Value = tmpArticle.vatRate;
                            //}
                        }
                        //if (tmpIsValid)
                        //    this.dataGridViewInvoicePositions.CancelEdit();
                    }
                    else if (tmpCurrentColumn.Name == "comboBoxType")
                    {
                        if ((sender is DataGridCell))
                        {

                        }
                        //if (tmpIsValid)
                        //    this.dataGridViewInvoicePositions.CancelEdit();
                    }
                    else if (tmpCurrentColumn.Name == "bruttoDataGridViewTextBoxColumn")
                    {
                        if (tmpCurrentValue != null)
                        {
                            double tmpBrutto = 0.0;
                            tmpBrutto = Convert.ToDouble(tmpCurrentValue);
                            {
                                if (!(tmpBrutto >= 0.0))
                                {
                                    tmpIsValid = false;
                                    tmpCaption = "Error im Brutto Wert.";
                                    tmpMessage = "Der Bruttowert ist nicht richtig." + Environment.NewLine + "Er muss z.B. von der Form: 16.3 sein";
                                }
                            }
                        }
                        else
                            tmpIsValid = false;
                    }
                    else if (tmpCurrentColumn.Name == "mwStDataGridViewTextBoxColumn")
                    {
                        if (tmpCurrentValue != null)
                        {
                            double tmpBrutto = 0.0;
                            tmpBrutto = Convert.ToDouble(tmpCurrentValue);
                            {
                                if (!(tmpBrutto >= 0.0))
                                {
                                    tmpIsValid = false;
                                    tmpCaption = "Error im Mehrwertsteuersatz.";
                                    tmpMessage = "Der Wert im Mehrwertsteuersatz ist nicht richtig." + Environment.NewLine + "Er muss z.B. von der Form: 16.3 sein";
                                }
                            }
                        }
                        else
                            tmpIsValid = false;
                    }
                    else if (tmpCurrentColumn.Name == "rabattDataGridViewTextBoxColumn")
                    {
                        if (tmpCurrentValue != null)
                        {
                            double tmpMwst = 0.0;
                            tmpMwst = Convert.ToDouble(tmpCurrentValue);
                            {
                                if (!(tmpMwst >= 0.0))
                                {
                                    tmpIsValid = false;
                                    tmpCaption = "Error im Rabatt Wert.";
                                    tmpMessage = "Der Wert in Rabatt ist nicht richtig." + Environment.NewLine + "Er muss z.B. von der Form: 16.3 sein";
                                }
                            }
                        }
                        else
                            tmpIsValid = false;
                    }
                    else if (tmpCurrentColumn.Name == "nettoDataGridViewTextBoxColumn")
                    {
                        if (tmpCurrentValue != null)
                        {
                            double tmoNetto = 0.0;
                            tmoNetto = Convert.ToDouble(tmpCurrentValue);
                            {
                                if (!(tmoNetto >= 0.0))
                                {
                                    tmpIsValid = false;
                                    tmpCaption = "Error im Netto Wert.";
                                    tmpMessage = "Der Wert im Netto ist nicht richtig." + Environment.NewLine + "Er muss z.B. von der Form: 16.3 sein";
                                }
                            }
                        }
                        else
                            tmpIsValid = false;
                    }

                    if (!tmpIsValid)
                    {
                        MessageBox.Show(tmpMessage, tmpCaption, MessageBoxButtons.OK);
                    }
                    else
                    {
                        calcRow(e.RowIndex);
                    }
                }
            }
        }

        private void dataGridViewInvoicePositions_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn tmpCurrentColumn = this.dataGridViewInvoicePositions.Columns[e.ColumnIndex];

            if (e.RowIndex >= 0)
            {
                object tmpCurrentValue = this.dataGridViewInvoicePositions[e.ColumnIndex, e.RowIndex].Value;

                if (tmpCurrentColumn != null)
                {
                    if (tmpCurrentColumn.Name == "comboBoxArticle")
                    {
                    }
                    else if (tmpCurrentColumn.Name == "comboBoxType")
                    {
                    }
                }
            }
        }

        private void dataGridViewInvoicePositions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Dont do shit

            if (this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells["comboBoxArticle"].Value == null)
                this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells["comboBoxArticle"].Value = 1;
            if (this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells["comboBoxType"].Value == null)
                this.dataGridViewInvoicePositions.Rows[e.RowIndex].Cells["comboBoxType"].Value = 1;
        }

        private void buttonCreateArticle_Click(object sender, EventArgs e)
        {
            frmUserInput tmpUserInput = new frmUserInput(true);
            tmpUserInput.Show();
            //ToDo: Läd nicht neu  Oder jetzt doch? 
            this.bindingSourceArtikel.DataSource = clsArticle.GetArticlesFromDB();

            RefreshDataSources();
        }

        private void buttonCreateType_Click(object sender, EventArgs e)
        {
            frmUserInput tmpUserInput = new frmUserInput(false);
            tmpUserInput.Show();
            //ToDo: Läd nicht neu  oder jetzt doch? :D 
            this.bindingSourceTypen.DataSource = clsType.GetTypesFromDB();
            Reset();
            RefreshDataSources();
        }
    }
}
