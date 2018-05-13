using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanInvoicing.Classes
{
    public class clsArticle : clsDatabaseObject
    {

        int id;

        public String name;

        public double vatRate;

        public double price;

        public double squareMeter;

        public void clsArticel()
        {

        }

        public static List<String> GetArticlesFromDB()
        {
            List<String> tmpResult = new List<String>();
            try
            {
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");
                String tmpCommand = "SELECT name FROM tbArtikel WHERE systemstatus_id = 1";
                Statement stm = connection.createStatement();
                ResultSet rs = stm.executeQuery(tmpCommand);
                while (rs.next())
                {
                    tmpResult.add(rs.getString("name"));
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

        public static int GetId(String pArticleName)
        {
            int tmpResult = 1;
            try
            {
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");
                String tmpCommand = ("Select id FROM tbArtikel WHERE systemstatus_id = 1 AND name Like \'"
                            + (pArticleName + "\'"));
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

        public static Double GetMwst(String pArticleName)
        {
            Double tmpResult = 0;
            try
            {
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");
                String tmpCommand = ("Select mwstSatz FROM tbArtikel WHERE systemstatus_id = 1 AND name Like \'"
                            + (pArticleName + "\'"));
                Statement stm = connection.createStatement();
                ResultSet rs = stm.executeQuery(tmpCommand);
                while (rs.next())
                {
                    tmpResult = rs.getDouble("mwstSatz");
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

        public bool save()
        {
            bool result = false;
            try
            {
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");
                String tmpCommand = ("INSERT INTO tbArtikel (name, mwstSatz, systemstatus_id) VALUES (\'"
                            + (this.name + ("\', "
                            + (this.vatRate + ",1)"))));
                PreparedStatement ps = connection.prepareStatement(tmpCommand);
                result = ps.execute();
            }
            catch (Exception e)
            {
                result = false;
            }
            finally
            {
            }
                return result;

        }

        void load()
        {

        }
    }
}
}
