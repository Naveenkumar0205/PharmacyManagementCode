using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program mainObj = new Program();
            Console.WriteLine("-----Welcome to Our Pharmacy-----");
            Console.WriteLine("1.customer login");
            Console.WriteLine("2.shopkeeper login");
            Console.WriteLine("  ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    mainObj.Custlogin();
                    break;
                case 2:
                    mainObj.Shoplogin();
                    break;
            }


            /*Customer cr = new Customer("Naveen", "9494749492", "naveenbhageradhi@gmail.com", "chittoor", 5000);
            Console.WriteLine(cr.ToString());

            Tablet tb = new Tablet(1, "citrizen", 5, 500);
            Console.WriteLine(tb.ToString());

            cr.CustomerName = "Pavan";
            Console.WriteLine(cr.CustomerName);

            Console.WriteLine("Enter tablet to order");
            String tablet = Console.ReadLine();
            Console.WriteLine("Enter no. of tablets");
            int count = Convert.ToInt32(Console.ReadLine());
            order o = new order();
            o.OrderDetails(tablet, count);*/

        }
        public void Shoplogin()
        {
            Vlogin vli = new Vlogin("pppp", "dot");
            Console.WriteLine(".......Enter your name.......");
            string vname = Console.ReadLine();
            Console.WriteLine(".......Enter your password.......");
            string vpass = Console.ReadLine();
            if (vli.VuserName == vname && vli.Vpass == vpass)
            {
                Console.WriteLine("### Login Successful ###");
                Console.WriteLine(vli.ToString());
                Console.WriteLine("-----------------------");
                Console.WriteLine("1.Add tablet to stock");
                Console.WriteLine("2.update tablet stock");
                Console.WriteLine("3.view order history");
                Console.WriteLine("4.Exit");
                Console.WriteLine("-----------------------");
                shopop();
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Invalid credentials");
                Console.WriteLine("-----------------------");
                Shoplogin();
            }
        }
        private void shopop()
        {
            int chh = Convert.ToInt32(Console.ReadLine());
            switch (chh)
            {
                case 1:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Add the tablet");
                    Console.WriteLine("-----------------------");
                    AddTablet();
                    Console.WriteLine("-----------------------");
                    break;
                case 2:
                    Console.WriteLine("update the cost of the tablet");
                    UpdateStock();
                    break;
                case 3:
                    Console.WriteLine("orders history");
                    ViewOrders();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter a valid values");
                    shopop();
                    break;
            }
        }
        public void Custlogin()
        {
            Login li = new Login("abcd","dot");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter your name");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string cpass = Console.ReadLine();

            if (li.UserName == cname && li.Pass == cpass)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("### Login Successful ###");
                Console.WriteLine("-----------------------");
                Console.WriteLine("  ");
                Console.WriteLine(li.ToString());
                Console.WriteLine("1.view the medicine list");
                Console.WriteLine("2.Place order");
                Console.WriteLine("3.Cancel Order");
                Console.WriteLine("4.Exit");
                custop();
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Invalid credentials");
                Console.WriteLine("-----------------------");
                Custlogin();
            }
        }
        private void custop()
        {
            int chh = Convert.ToInt32(Console.ReadLine());
            switch (chh)
            {
                case 1:
                    Console.WriteLine("Medicine list");
                    TabletDetails();
                    break;
                case 2:
                    Console.WriteLine("place order");
                    Ordertablet();
                    break;
                case 3:
                    Console.WriteLine("Cancel Order");
                    CancelOrder();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter a valid input....");
                    custop();
                    break;
            }
        }
        public void TabletDetails()
        {
            List<Tablet> tablet = new List<Tablet>();
            tablet.Add(new Tablet(1, "citrizen", 5, 500));
            tablet.Add(new Tablet(2, "paracetamol", 10, 200));
            tablet.Add(new Tablet(3, "ativan", 7, 300));
            tablet.Add(new Tablet(4, "colpal", 8, 500));

            Tablet[] tabletInfo = TabletBLL.showTablet(tablet);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Tablet ID  Tablet Name  Tablet Price  Tablet Stock");
            Console.WriteLine("-----------------------");
            foreach (var t in tabletInfo)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine("Please choose from below if you wish to continue with other services");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.view the medicine list");
            Console.WriteLine("2.Place order");
            Console.WriteLine("3.View order details");
            Console.WriteLine("4.Exit");
            custop();
        }
        public void AddTablet()
        {
            List<Tablet> tablet = new List<Tablet>();
            tablet.Add(new Tablet(1, "citrizen", 5, 500));
            tablet.Add(new Tablet(2, "paracetamol", 10, 200));
            tablet.Add(new Tablet(3, "ativan", 7, 300));
            tablet.Add(new Tablet(4, "colpal", 8, 500));
            Tablet[] tabletInfo = TabletBLL.showTablet(tablet);
            foreach (var t in tabletInfo)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("The above mentioned this are the available medicine stock");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.Write("Tablet Id:");
            int tid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tablet Name:");
            string tname = Console.ReadLine();
            Console.Write("Tablet Cost:");
            int tcost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tablet Stock:");
            int tstock = Convert.ToInt32(Console.ReadLine());
            string tab = TabletBLL.addTablet(tid, tname, tcost, tstock, tablet);
            Console.WriteLine(tab);
            Tablet[] tabletInfo1 = TabletBLL.showTablet(tablet);
            foreach (var t in tabletInfo1)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine("Please choose from below if you wish to continue with other services");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.Add tablet to stock");
            Console.WriteLine("2.update tablet stock");
            Console.WriteLine("3.view order history");
            Console.WriteLine("4.Exit");
            shopop();
        }
        public void Ordertablet()
        {
            Console.WriteLine("Available tablets");
            Console.WriteLine("-----------------------");
            List<Tablet> tablet = new List<Tablet>();
            tablet.Add(new Tablet(1, "citrizen", 5, 500));
            tablet.Add(new Tablet(2, "paracetamol", 10, 200));
            tablet.Add(new Tablet(3, "ativan", 7, 300));
            tablet.Add(new Tablet(4, "colpal", 8, 500));
            Tablet[] tabletInfo = TabletBLL.showTablet(tablet);
            foreach (var t in tabletInfo)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("-----------------------");
            List<Order> order = new List<Order>();
            Console.WriteLine("Enter tablet to order");
            String tabName1 = Console.ReadLine();
            Console.WriteLine("Enter no. of tablets");
            int count = Convert.ToInt32(Console.ReadLine());
            int cst = TabletBLL.order1(tabName1, tablet);
            int amount = count * cst;
            Console.WriteLine("Total Amount payable:" + amount);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Press 1 to place order");
            Console.WriteLine("press 2 to exit from current order");
            int b = Convert.ToInt32(Console.ReadLine());
            switch(b)
            {
                case 1:
                    Random rand = new Random();
                    const int maxValue = 99;
                    int ordId = rand.Next(maxValue + 1);

                    DateTime dateTime = DateTime.Now;
                    string DateValue = dateTime.ToShortDateString();
                    //Console.WriteLine(amount);
                    Console.WriteLine("  ");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("your order is successful");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("  ");
                    string updStk = TabletBLL.updateStock1(tabName1, count, tablet);
                    /*foreach (var t in tabletInfo)
                    {
                        Console.WriteLine(t.ToString());
                    }*/
                    //Console.WriteLine("your order is :" + tabName1);
                    /*int tabId = 1;
                    string date = "12/12/2020"*/
                    Console.WriteLine("Press 1 to view order history");
                    Console.WriteLine("Press 2 to place another order");

                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("view orders history");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Order ID    Tablet Name    No.of Tablets    Tablet Cost    Total Amount    Date of order");
                            string ord = OrderBLL.orderTablet(ordId, tabName1, count, cst, amount, DateValue, order);
                            //Console.WriteLine(ord);
                            Order[] orderInfo = OrderBLL.showOrder(order);
                            foreach (var o in orderInfo)
                            {
                                Console.WriteLine(o.ToString());
                            }
                            break;
                        //Console.ReadLine();
                        case 2:
                            Ordertablet();
                            break;
                        default:
                            Console.WriteLine(" Invalid Choice");
                            Console.WriteLine("Please choose from below if you wish to continue with other services");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("1.view the medicine list");
                            Console.WriteLine("2.Place order");
                            Console.WriteLine("3.View order details");
                            Console.WriteLine("4.Exit");
                            custop();
                            break;
                    }
                    break;
                case 2:
                    Ordertablet();
                    break;
                default:
                    Console.WriteLine(" Invalid Choice");
                    Console.WriteLine("Please choose from below if you wish to continue with other services");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1.view the medicine list");
                    Console.WriteLine("2.Place order");
                    Console.WriteLine("3.View order details");
                    Console.WriteLine("4.Exit");
                    custop();
                    break;
            }

            
        }
        public void ViewOrders()
        {
            Console.WriteLine("welcome");
            List<Order> order = new List<Order>();
            Console.WriteLine("Order ID    Tablet Name    No.of Tablets    Tablet Cost    Total Amount    Date of order");
            string ord = OrderBLL.orderTablet(11, "alpha", 5, 25, 125, "12/12/2020", order);
            string ord1 = OrderBLL.orderTablet(12, "aspirin", 10, 20, 200, "08/10/2020", order);
            string ord2 = OrderBLL.orderTablet(13, "beta", 7, 8, 56, "25/09/2020", order);
            string ord3 = OrderBLL.orderTablet(14, "Vit-B", 20, 40, 800, "15/05/2020", order);

            //Console.WriteLine(ord);
            Order[] orderInfo = OrderBLL.showOrder(order);
            foreach (var o in orderInfo)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine("Please choose from below if you wish to continue with other services");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.Add tablet to stock");
            Console.WriteLine("2.update tablet stock");
            Console.WriteLine("3.view order history");
            Console.WriteLine("4.Exit");
            shopop();
        }
        public void CancelOrder()
        {
            List<Order> order = new List<Order>();
            string ord = OrderBLL.orderTablet(11, "alpha", 5, 25, 125, "12/13/2020", order);
            string ord1 = OrderBLL.orderTablet(12, "aspirin", 10, 20, 200, "08/10/2020", order);
            string ord2 = OrderBLL.orderTablet(13, "beta", 7, 8, 56, "25/09/2020", order);
            string ord3 = OrderBLL.orderTablet(14, "Vit-B", 20, 40, 800, "15/05/2020", order);
            Order[] orderInfo = OrderBLL.showOrder(order);
            foreach (var o in orderInfo)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("Enter Order ID to cancel");
            int canVar = Convert.ToInt32(Console.ReadLine());
            String dat = OrderBLL.cancelOrd(canVar, order);
            DateTime date1 = DateTime.Parse(dat);
            Console.WriteLine(dat);
            Console.WriteLine(date1);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            int value = (dateTime - date1).Days;
            Console.WriteLine(value);
            if (value >=0 && value <2)
            {
                Order[] dat1 = OrderBLL.cancelOrd1(canVar, order);
                foreach (var d in dat1)
                {
                    Console.WriteLine(d.ToString());
                }

            }
            else
            {
                Console.WriteLine("Order cannot be cancelled");
            }
            Console.WriteLine();
            Console.WriteLine("Please choose from below if you wish to continue with other services");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.view the medicine list");
            Console.WriteLine("2.Place order");
            Console.WriteLine("3.View order details");
            Console.WriteLine("4.Exit");
            custop();

            /*Order[] orderInfo1 = OrderBLL.showOrder(order);
            foreach (var o in orderInfo1)
            {
                Console.WriteLine(o.ToString());
            }*/

        }
        public void UpdateStock()
        {
            List<Tablet> tablet = new List<Tablet>();
            tablet.Add(new Tablet(1, "citrizen", 5, 500));
            tablet.Add(new Tablet(2, "paracetamol", 10, 200));
            tablet.Add(new Tablet(3, "ativan", 7, 300));
            tablet.Add(new Tablet(4, "colpal", 8, 500));
            Tablet[] tabletInfo = TabletBLL.showTablet(tablet);
            foreach (var t in tabletInfo)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter tablet Id to update stock");
            int tId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter stock");
            int tstock = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (tstock > 0)
                {
                    string tab = TabletBLL.updateStock(tId, tstock, tablet);
                    foreach (var t in tabletInfo)
                    {
                        Console.WriteLine(t.ToString());
                    }
                }
                else
                {
                    throw (new NegativeStockException("Tablet Stock cannot be less than zero "));
                }
            }
            catch (NegativeStockException e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();
            }
            Console.WriteLine("Please choose from below if you wish to continue with other services");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.Add tablet to stock");
            Console.WriteLine("2.update tablet stock");
            Console.WriteLine("3.view order history");
            Console.WriteLine("4.Exit");
            shopop();
        }

    }
    public class NegativeStockException : Exception
    {
        public NegativeStockException(string message)
            : base(message)
        {
        }
    }
}