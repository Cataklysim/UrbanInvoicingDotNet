﻿using System;
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
    public partial class frmImport : Form
    {
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
            clsInvoice tmpNewInvoice = new clsInvoice()
            {

            };
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
            // Change sum in labels 
        }

        private void dataGridViewInvoicePositions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool tmpIsValid = true;
            DataGridViewColumn tmpCurrentColumn = this.dataGridViewInvoicePositions.Columns[e.ColumnIndex];
            if (tmpCurrentColumn != null)
            {
                if (tmpCurrentColumn.Name == "bemerkungDataGridViewTextBoxColumn")
                {
                    if (tmpIsValid)
                        this.dataGridViewInvoicePositions.CancelEdit();
                }
                else if (tmpCurrentColumn.Name == "artikelIdDataGridViewTextBoxColumn")
                {
                    if (tmpIsValid)
                        this.dataGridViewInvoicePositions.CancelEdit();
                }
                else if (tmpCurrentColumn.Name == "typeIdDataGridViewTextBoxColumn")
                {
                    if (tmpIsValid)
                        this.dataGridViewInvoicePositions.CancelEdit();
                }
                else if (tmpCurrentColumn.Name == "bruttoDataGridViewTextBoxColumn")
                {
                    if (tmpIsValid)
                        this.dataGridViewInvoicePositions.CancelEdit();
                }
                else if (tmpCurrentColumn.Name == "mwStDataGridViewTextBoxColumn")
                {
                    if (tmpIsValid)
                        this.dataGridViewInvoicePositions.CancelEdit();
                }
                else if (tmpCurrentColumn.Name == "rabattDataGridViewTextBoxColumn")
                {
                    if (tmpIsValid)
                        this.dataGridViewInvoicePositions.CancelEdit();
                }
                else if (tmpCurrentColumn.Name == "nettoDataGridViewTextBoxColumn")
                {
                    if (tmpIsValid)
                        this.dataGridViewInvoicePositions.CancelEdit();
                }
            }
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            this.bindingSourceCustomers.DataSource = clsCustomer.GetCustomerFromDB();
            this.bindingSourceArtikel.DataSource = clsArticle.GetArticlesFromDB();
            this.bindingSourceTypen.DataSource = clsType.GetTypesFromDB();
            this.dateTimePicker.Value = DateTime.Now;
            this.LoadRepositories();
        }

        public void LoadRepositories()
        {
            List<clsArticle> tmpArticles = new List<clsArticle>();
            List<clsType> tmpTypes = new List<clsType>();
            if (Properties.Settings.Default.DevBuild)
            {
                tmpArticles.Add(new clsArticle() { name = "Test", id = 1 });
                tmpTypes.Add(new clsType() { name = "Test", id = 1 });
                this.bindingSourceArtikel.DataSource = tmpArticles;
                this.bindingSourceTypen.DataSource = tmpTypes;
            }
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
            int tmpTypIndex = this.dataGridViewInvoicePositions.Columns["typeIdDataGridViewTextBoxColumn"].DisplayIndex;
            tmpComboBoxArticle.DisplayIndex = tmpArtikelIndex;
            tmpComboBoxType.DisplayIndex = tmpTypIndex;
            this.dataGridViewInvoicePositions.Columns.Add(tmpComboBoxArticle);
            this.dataGridViewInvoicePositions.Columns.Add(tmpComboBoxType);
        }
    }
}
