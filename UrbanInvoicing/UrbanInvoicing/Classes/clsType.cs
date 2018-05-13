using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");

                String tmpCommand = "Select name FROM tbType WHERE systemstatus_id = 1";
                Statement stm = connection.createStatement();
                ResultSet rs = stm.executeQuery(tmpCommand);
                while (rs.next())
                {
                    tmpResult.Add(rs.getString(1));
                }

            }
            catch (Exception e)
            {
                
            }
            finally
            {
            }
                return tmpResult;
        }

        public static int GetId(String pName)
        {
            int tmpResult = 1;
            try
            {
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");

                String tmpCommand = "Select id FROM tbType WHERE name like '" + pName + "'";
                Statement stm = connection.createStatement();
                ResultSet rs = stm.executeQuery(tmpCommand);
                while (rs.next())
                {
                    tmpResult = rs.getInt("id");
                }

            }
            catch (Exception e)
            {
                
            }
            finally
            {
            }
            return tmpResult;
        }
    }
}