using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanInvoicing.Classes
{
    public class clsInvoice : clsDatabaseObject
    {

        public int id;

        public int customerId;

        public DateTime date;

        bool printed;

        public double sumBrutto;

        public double sumNetto;

        public double sumMwst;

        public List<clsInvoicePosition> invoicePositions = new List<clsInvoicePosition>();

        public clsInvoice()
        {

        }

        override public void Load()
        {

        }

        override public bool Save()
        {
            bool result = false;
            String tmpDate = (new SimpleDateFormat("yyyy-MM-dd HH:mm:ss") + format(this.date));
            String tmpCommand = ("INSERT INTO tbInvoice (customer_id, belegdatum, printed, summeBrutto, summeNetto, summeMwst, systemst" +
            "atus_id) VALUES ("
                        + (this.customerId + (", \'"
                        + (tmpDate + ("\', false, "
                        + (this.sumBrutto + (","
                        + (this.sumNetto + (","
                        + (this.sumMwst + ",1)"))))))))));

            try
            {
                using (var mysqlconnection = new MySqlConnection(m_strMySQLConnectionString))
                {
                    mysqlconnection.Open();
                    using (MySqlCommand cmd = mysqlconnection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 300;
                        cmd.CommandText = strQuery;

                        object objValue = cmd.ExecuteScalar();
                        if (objValue == null)
                        {
                            cmd.Dispose();
                            return string.Empty;
                        }
                        else
                        {
                            strData = (string)cmd.ExecuteScalar();
                            cmd.Dispose();
                        }

                        mysqlconnection.Close();
                    }
                }
                PreparedStatement ps = connection.prepareStatement(tmpCommand, Statement.RETURN_GENERATED_KEYS);
                result = ps.execute();
                ResultSet rs = ps.getGeneratedKeys();
                while (rs.next())
                {
                    this.id = rs.getInt(1);
                }

                foreach (clsInvoicePosition pos in this.invoicePositionArrayList)
                {
                    pos.SetInvoiceId(this.id);
                    pos.Save();
                }

                result = true;


            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        public static int GetId(clsInvoice pInvoice)
        {
            return 1;
        }
    }
}

