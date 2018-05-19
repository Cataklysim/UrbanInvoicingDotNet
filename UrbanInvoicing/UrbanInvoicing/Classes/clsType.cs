using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace UrbanInvoicing.Classes
{
    public class clsType
    {
        public int id { get; set; }
        public int multiplier { get; set; }
        public String name { get; set; }
        public bool isSquarmeterRelevant { get; set; }
        public bool isRoomRelevant { get; set; }

        public clsType()
        {

        }

        public static List<String> GetTypesFromDB()
        {
            List<String> tmpResult = new List<String>();
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("Select name FROM tbType WHERE systemstatus_id = 1");
                    tmpCommand.Connection = tmpConnection;
                    tmpCommand.Connection.Open();
                    using (MySqlDataReader tmpReader = tmpCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (tmpReader.Read())
                        {
                            tmpResult.Add(tmpReader["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("# " + DateTime.Now + "clsType - Failed to execute SQL: " + ex);
                return null;
            }
            return tmpResult;
        }

        public static int GetId(String pName)
        {
            int tmpResult = 1;
            try
            {
                using (MySqlConnection tmpConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand tmpCommand = new MySqlCommand("SELECT ID FROM tbType WHERE name LIKE @Name");
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
                Debug.WriteLine("# " + DateTime.Now + "clsType - Failed to execute SQL: " + ex);
                return 0;
            }
            finally
            {
            }
            return tmpResult;
        }
    }
}