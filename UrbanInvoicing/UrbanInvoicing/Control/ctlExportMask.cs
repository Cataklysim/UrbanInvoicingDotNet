using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace UrbanInvoicing.Control
{
    public partial class ctlExportMask : UserControl
    {
        public ctlExportMask()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.BindGrid(this.dateTimePickerFrom.Value, this.dateTimePickerTo.Value, this.checkBoxExport.Checked);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog savefile = new SaveFileDialog())
                {
                    // set a default file name
                    savefile.FileName = "Export.csv";
                    // set filters - this can be done in properties as well
                    savefile.Filter = "CSV|*.csv";

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (System.IO.StreamWriter csvFileWriter = new StreamWriter(savefile.FileName, false))
                        {
                            var sb = new StringBuilder();

                            var headers = this.dataGridView1.Columns.Cast<DataGridViewColumn>();
                            sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                            foreach (DataGridViewRow row in this.dataGridView1.Rows)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>();
                                sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                            }

                            csvFileWriter.WriteLine(sb);

                            csvFileWriter.Flush();
                            csvFileWriter.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Während dem Export ist ein Fehler aufgetreten. Möglicherweise befindet sich die Datei zurzeit in Bearbeitung. \r\nFehler:\r\n\r\nEX: " + ex.Message, "Fehler beim Exportieren der Ansicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctlExportMask_Load(object sender, EventArgs e)
        {
            this.dateTimePickerFrom.Value = DateTime.Today;
            this.dateTimePickerTo.Value = DateTime.Today;
            this.BindGrid(this.dateTimePickerFrom.Value, this.dateTimePickerTo.Value, this.checkBoxExport.Checked);
        }

        private void BindGrid(DateTime pFrom, DateTime pTo, bool pIsExport)
        {
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT * FROM vwInvoiceExport WHERE (belegdatum BETWEEN @From AND @To) AND IsExport = @Export", tmpConnection);
                    tmpCommand.Parameters.AddWithValue("@From", pFrom);
                    tmpCommand.Parameters.AddWithValue("@To", pTo);
                    tmpCommand.Parameters.AddWithValue("@Export", pIsExport);
                    tmpCommand.Connection.Open();

                    //System.Data.CommandBehavior.CloseConnection
                    //using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    //{
                    using (MySqlDataAdapter tmpDataAdapter = new MySqlDataAdapter())
                        {
                            tmpDataAdapter.SelectCommand = tmpCommand;
                            using (DataTable tmpTable = new DataTable())
                            {
                               
                                tmpDataAdapter.Fill(tmpTable);
                                this.dataGridView1.DataSource = tmpTable;
                            }
                        }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler während dem Laden des Inhalts aufgetreten. \r\nFehler:\r\n\r\n" + ex.Message, "Fehler beim Laden der Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
