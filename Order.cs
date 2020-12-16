using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    public class Order
    {
        private int _orderId;
        private string _tabletName;
        private int _tabletCount;
        private int _tabletCost;
        private int _totalAmount;
        private string _date;

        public Order()
        {

        }

        public Order(int orderId, string tabletName, int tabletCount, int tabletCost, int totalAmount, string date)
        {
            this._orderId = orderId;
            this._tabletName = tabletName;
            this._tabletCount = tabletCount;
            this._tabletCost = tabletCost;
            this._totalAmount = totalAmount;
            this._date = date;
        }

        public int OrderId
        {
            get
            {
                return this._orderId;
            }
            set
            {
                this._orderId = value;
            }
        }
        public string TabletName
        {
            get
            {
                return this._tabletName;
            }
            set
            {
                this._tabletName = value;
            }
        }
        public int TabletCount
        {
            get
            {
                return this._tabletCount;
            }
            set
            {
                this._tabletCount = value;
            }
        }
        public int TabletCost
        {
            get
            {
                return this._tabletCost;
            }
            set
            {
                this._tabletCost = value;
            }
        }
        public int TotalAmount
        {
            get
            {
                return this._totalAmount;
            }
            set
            {
                this._totalAmount = value;
            }
        }
        public string Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        public override string ToString()
        {
            return string.Format("\n {0} \t    {1} \t\t {2} \t\t {3} \t\t{4} \t      {5}",
                                 this._orderId, this._tabletName, this._tabletCount, this._tabletCost, this._totalAmount, this._date);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Order c = (Order)obj;
                return (_orderId == c._orderId)
                        && (_tabletName == c._tabletName)
                        && (_tabletCount == c._tabletCount)
                        && (_tabletCost == c._tabletCost)
                        && (_totalAmount == c._totalAmount)
                        && (_date == c._date);
            }
        }
        public override int GetHashCode()
        {
            Order c1 = new Order(101, "Lyrica", 2, 10, 20, "12/12/2020");
            Order c2 = new Order();
            if (c1.Equals(c2))
            {
                return 1;
            }
            return 0;
        }
    }
}