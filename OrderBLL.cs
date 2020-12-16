using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    public class OrderBLL
    {
        static List<Order> order = new List<Order>();

        public static Order[] showOrder(List<Order> order)
        {
            List<Order> order1 = new List<Order>();
            foreach (var o in order)
            {
                order1.Add(o);
            }
            return order1.ToArray();
        }
        public static string orderTablet(int orderId, string tabName1, int count, int cst, int amount, string date, List<Order> order)
        {
            order.Add(new Order(orderId, tabName1, count, cst, amount, date));
            return "Your tablet  " + tabName1 + " is sucessfully added !";
            //return "successful";
        }
        public static string cancelOrd(int orderId, List<Order> order)
        {
            string orderDate = " ";
            foreach (var o in order)
            {
                if (o.OrderId == orderId)
                {
                    orderDate = o.Date;
                }
            }
            return orderDate;
        }
        public static Order[] cancelOrd1(int orderId, List<Order> order)
        {
            //string orderDate = " ";
            List<Order> order2 = new List<Order>();
            foreach (var o in order)
            {
                if (o.OrderId != orderId)
                {
                    order2.Add(o);
                }
            }
            return order2.ToArray();
        }
 

    }
}