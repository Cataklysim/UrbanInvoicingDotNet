﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanInvoicing.Forms;
using UrbanInvoicing.Classes;

namespace UrbanInvoicing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Nichts anfassen hier!
            this.Text = Application.ProductName + " [" + Application.ProductVersion + "]";
            // Könnte man für ein paar coole Features benutzen
            if (Properties.Settings.Default.DevBuild)
            {
                this.Text += " DevBuild!    "+Properties.Settings.Default.ConnectionString.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmImport tmpImportForm = new frmImport();
            tmpImportForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmExport tmpExportForm = new frmExport();
            tmpExportForm.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmContacts tmpContactsForm = new frmContacts();
            tmpContactsForm.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDataManagement tmpDataManagement = new frmDataManagement("inbound");
            tmpDataManagement.ShowDialog(this);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmDataManagement tmpDataManagement = new frmDataManagement("outbound");
            tmpDataManagement.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report.repo tmpReportDesinger = new Report.repo();
            tmpReportDesinger.ShowDialog(this);
        }
    }
}
