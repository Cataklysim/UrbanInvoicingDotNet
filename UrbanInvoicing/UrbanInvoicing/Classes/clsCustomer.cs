using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanInvoicing.Classes
{
    class clsCustomer
    {

        public int id;
        public String name;
        public String lastName;
        public String plz;
        public String street;
        public String city;
        public String land;
        public String telefone;
        public String telefax;
        public String email;
        public String note;
        private bool isCompany;

        public clsCustomer()
        { }

        public static List<clsCustomer> GetCustomerFromDB()
        {
            List<clsCustomer> tmpResult = new List<clsCustomer>();
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT * FROM tbCustomer WHERE systemstatus_id = 1 AND isCompany = 1");
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            clsCustomer customer = new clsCustomer();
                            customer.id = Convert.ToInt32(tmpReader["id"]);
                            customer.name = tmpReader["name"].ToString();
                            tmpResult.Add(customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsCustomer - Failed to execute SQL: " + ex);
                return null;
            }
            return tmpResult;
        }

        public static int GetId(String pName)
        {
            int tmpResult = 0;
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT id FROM tbCustomer WHERE systemstatus_id = 1 AND isCompany = 1 AND name LIKE @Name");
                    tmpCommand.Parameters.AddWithValue("@Name", pName);
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            tmpResult = Convert.ToInt32(tmpReader["Id"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsCustomer - Failed to execute SQL: " + ex);
                return tmpResult;
            }
            return tmpResult;
        }
    }
}
