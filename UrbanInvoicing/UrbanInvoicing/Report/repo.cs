﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanInvoicing.Report
{
    public partial class repo : Form
    {
        public repo()
        {
            InitializeComponent();
        }

        private void repo_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "UrbanInvoicing.UrbanInvoicing.Report.rptInvoiceHeader.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
