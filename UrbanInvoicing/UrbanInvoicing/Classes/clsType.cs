using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace UrbanInvoicing.Classes
{
    class clsType
    {
        int id;
        int multiplier;
        String name;
        bool isSquarmeterRelevant;
        bool isRoomRelevant;

        public clsType()
        { }

        public static List<String> GetTypesFromDB()
        {
            List<String> tmpResult = new List<String>();
            try
            {
                String tmpComStr = "Select name FROM tbType WHERE systemstatus_id = 1";
                using (MySqlConnection tmpCon = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var tmpCmd = new MySqlCommand(tmpComStr, tmpCon))
                    {
                        tmpCon.Open();
                        using (var tmpReader = tmpCmd.ExecuteReader())
                        {
                            while (tmpReader.Read())
                            {
                                tmpResult.Add(tmpReader["name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return tmpResult;
        }

        public static int GetId(String pName)
        {
            int tmpResult = 1;
            try
            {
                String tmpComStr = "Select id FROM tbType WHERE name like '" + pName + "'";
                using (MySqlConnection tmpCon = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var tmpCmd = new MySqlCommand(tmpComStr, tmpCon))
                    {
                        tmpCon.Open();
                        using (var tmpReader = tmpCmd.ExecuteReader())
                        {
                            while (tmpReader.Read())
                            {
                                tmpResult = Convert.ToInt32(tmpReader["name"]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return tmpResult;
        }
    }
}