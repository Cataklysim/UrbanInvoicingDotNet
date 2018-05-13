using System;
using System.Collections.Generic;
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
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");

                String tmpCommand = "SELECT * FROM tbCustomer WHERE systemstatus_id = 1 AND isCompany = 1";
                Statement stm = connection.createStatement();
                ResultSet rs = stm.executeQuery(tmpCommand);
                while (rs.next())
                {
                    clsCustomer customer = new clsCustomer();
                    customer.id = rs.getInt("id");
                    customer.name = rs.getString("name");
                    tmpResult.add(customer);
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

        public static int getId(String pName)
        {
            int tmpResult = 1;
            try
            {
                Connection connection = DriverManager.getConnection("jdbc:mariadb://SQLSRV01:3307/urbanInvoicing?user=urbanInvoicing&password=urbanInvoicing");

                String tmpCommand = "SELECT id FROM tbCustomer WHERE systemstatus_id = 1 AND isCompany = 1 AND name like '" + pName + "'";
                Statement stm = connection.createStatement();
                ResultSet rs = stm.executeQuery(tmpCommand);
                while (rs.next())
                {
                    tmpResult = rs.getInt("id");
                }

            }
            catch (Exception e)
            {
                JOptionPane.showMessageDialog(null, e.getMessage(), "Error (Customer.getId)", JOptionPane.OK_CANCEL_OPTION);
                e.printStackTrace();
            }
            finally
            {
                return tmpResult;
            }
        }
    }
