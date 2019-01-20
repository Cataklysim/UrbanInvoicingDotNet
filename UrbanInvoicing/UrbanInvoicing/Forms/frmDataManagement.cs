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
using UrbanInvoicing.Control;

namespace UrbanInvoicing.Forms
{
    public partial class frmDataManagement : Form
    {
        private string LoadTag { get; set; }

        public frmDataManagement(string pTag)
        {
            InitializeComponent();
            this.LoadTag = pTag;
            try
            {
                this._LocalInboundControl = new ctlDataManagementInbound();
                this._LocalOutboundControl = new ctlDataManagementOutbound();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Achtung", "Fehler beim Laden der Daten:\r\n" + ex.Message);
                this.Dispose();
            }
        }

        private ctlDataManagementInbound _LocalInboundControl { get; set; }
        private ctlDataManagementOutbound _LocalOutboundControl { get; set; }

        private void frmDataManagement_Load(object sender, EventArgs e)
        {
            if (this._LocalInboundControl != null && this._LocalOutboundControl != null)
            {
                this._LocalInboundControl.Parent = null;
                this._LocalOutboundControl.Parent = null;

                switch (this.LoadTag)
                {
                    case "inbound":
                        this._LocalInboundControl.Parent = this.splitContainer1.Panel1;
                        this.Text = "Eingehende Rechnungen";
                        this._LocalInboundControl.RefreshDataSources();
                        this._LocalInboundControl.Dock = DockStyle.Fill;
                        this._LocalInboundControl.Refresh();
                        break;
                    case "outbound":
                        this._LocalOutboundControl.Parent = this.splitContainer1.Panel1;
                        this.Text = "Ausgehende Rechnungen";
                        this._LocalOutboundControl.RefreshDataSources();
                        this._LocalOutboundControl.Dock = DockStyle.Fill;
                        this._LocalOutboundControl.Refresh();
                        break;
                    default:
                        this.Dispose();
                        break;
                }
                this.splitContainer1.Refresh();
            }
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this._LocalInboundControl = null;
            this._LocalOutboundControl = null;
            this.Dispose();
        }

        private void frmDataManagement_ResizeEnd(object sender, EventArgs e)
        {
            this.splitContainer1.Refresh();
        }

        private void frmDataManagement_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void frmDataManagement_SizeChanged(object sender, EventArgs e)
        {
            this.splitContainer1.Refresh();
        }
    }
}
