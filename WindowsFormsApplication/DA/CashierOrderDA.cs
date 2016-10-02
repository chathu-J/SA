using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.BL;

namespace WindowsFormsApplication.DA
{
    class CashierOrderDA
    {
        public string ConString = "Data Source=DC;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();

        //get all orders
        public DataTable GetAllOrders()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Payement", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        //get specific order
        public DataTable GetOrder(int Id)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders where Oid= " + Id + "", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        //update order
        public bool Update(CashierOrderBL order)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("update Orders set Status='" + order.Status + "' where ID='" + order.OrderID + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                throw;
            }
        }
    }
}
