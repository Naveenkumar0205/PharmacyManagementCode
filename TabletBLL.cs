using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    public class TabletBLL
    {
        static List<Tablet> tablet = new List<Tablet>();

        public static Tablet[] showTablet(List<Tablet> tablet)
        {
            List<Tablet> tablet1 = new List<Tablet>();
            foreach (var t in tablet)
            {
                tablet1.Add(t);
            }
            return tablet1.ToArray();
        }
        public static string addTablet(int tabId, string tabName, int tabCost, int tabStock, List<Tablet> tablet)
        {
            tablet.Add(new Tablet(tabId, tabName, tabCost, tabStock));
            return "Your tablet  " + tabName + " is sucessfully added !";
        }
        public static string updateStock(int tabId, int tabStock, List<Tablet> tablet)
        {
            string tabletName = " ";
            foreach (var t in tablet)
            {
                if (t.TabletNo == tabId)
                {
                    tabletName = t.TabletName;
                    t.TabletStock = t.TabletStock + tabStock;
                }
            }
            return "Your Stock of tablet " + tabletName + " is sucessfully updated with : " + tabStock;
        }
        public static int order1(string tabName, List<Tablet> tablet)
        {
            int cost = 0;
            foreach (var t in tablet)
            {
                if (t.TabletName == tabName)
                {
                    cost = t.TabletCost;
                }
            }
            return cost;
        }
        public static string updateStock1(string tabName, int tabStock, List<Tablet> tablet)
        {
            //string tabletName = " ";
            foreach (var t in tablet)
            {
                if (t.TabletName == tabName)
                {
                    t.TabletStock = t.TabletStock - tabStock;
                }
            }
            return "Done";
        }
    }
}