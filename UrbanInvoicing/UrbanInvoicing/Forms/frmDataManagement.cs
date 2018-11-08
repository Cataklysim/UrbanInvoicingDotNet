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


/*ToDo: Das wird sie Überfordern. Wir müssen es als eine Ansicht für Eingangsrechnung und
 * eine für Ausgangsrechnungen, sowie die Extra maske für die Adressübersicht machen*/
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
                        this._LocalInboundControl.Parent = this;
                        this.Text = "Eingehende Rechnungen";
                        break;
                    case "outbound":
                        this._LocalOutboundControl.Parent = this;
                        this.Text = "Ausgehende Rechnungen";
                        break;
                    default:
                        this.Dispose();
                        break;
                }
            }
        }
    }
}
