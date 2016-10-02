using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.BL;

namespace WindowsFormsApplication.PL
{
    public partial class CashierOrder : MetroForm
    {

        int orderID;
        public CashierOrder()
        {
            InitializeComponent();
        }

        //load all orders
        private void CashierOrder_Load(object sender, EventArgs e)
        {
            labelOrderDetails.Hide();
            metroGridOrderDetails.Hide();
            try
            {
                CashierOrderBL o = new CashierOrderBL();
                metroGridOrders.DataSource = o.GetAllOrders();


            }
            catch
            {
                MessageBox.Show("Error Occurred while retrieving");
            }
        }

        //get specific order details
        private void metroGridOrders_MouseClick(object sender, MouseEventArgs e)
        {
            if (metroGridOrders.Rows.Count > 0)
           {
               
                labelOrderDetails.Show();

                DataGridViewRow dr = metroGridOrders.SelectedRows[0];

                if (Convert.ToInt32(dr.Cells[1].Value) != 0)
                { 
                CashierOrderBL o = new CashierOrderBL();
                orderID = Convert.ToInt32(dr.Cells[0].Value);
                metroGridOrderDetails.DataSource = o.GetOrder(Convert.ToInt32(dr.Cells[0].Value));
                metroGridOrderDetails.Show();
            }

            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                CashierOrderBL o = new CashierOrderBL();
                o.Status = "Done";
                o.OrderID = orderID;

                if (o.UpdateOrder(o))
                {
                    this.metroGridOrderDetails.DataSource = o.GetOrder(orderID);
                    MessageBox.Show("Updated successfully");
                }
                else
                {
                    MessageBox.Show("Updation failed");
                }

            }
            catch
            {
                MessageBox.Show("Error Occurred while updating");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderReport report = new OrderReport();
            report.Show();
        }

    }
}
