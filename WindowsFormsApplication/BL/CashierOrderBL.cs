using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.DA;

namespace WindowsFormsApplication.BL
{
    class CashierOrderBL
    {
        int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        int foodId;

        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }
        int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        string foodName;

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
        string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        //get all orders
        public DataTable GetAllOrders()
        {
            try
            {
                CashierOrderDA objdal = new CashierOrderDA();
                return objdal.GetAllOrders();
            }
            catch
            {
                throw;
            }
        }

        //get specific user
        public DataTable GetOrder(int ID)
        {
            try
            {
                CashierOrderDA objdal = new CashierOrderDA();
                return objdal.GetOrder(ID);
            }
            catch
            {
                throw;
            }
        }

        //update order
        public bool UpdateOrder(CashierOrderBL order)
        {
            try
            {
                CashierOrderDA objdal = new CashierOrderDA();
                return objdal.Update(order);
            }
            catch
            {
                throw;
            }
        }



    }
}
