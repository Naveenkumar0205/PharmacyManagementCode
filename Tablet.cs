using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    public class Tablet
    {
        private int _tabletNo;
        private string _tabletName;
        private int _tabletCost;
        private int _tabletStock;

        public Tablet()
        {

        }

        public Tablet(int tabletNo, string tabletName, int tabletCost, int tabletStock)
        {
            this._tabletNo = tabletNo;
            this._tabletName = tabletName;
            this._tabletCost = tabletCost;
            this._tabletStock = tabletStock;
        }
        public int TabletNo
        {
            get
            {
                return this._tabletNo;
            }
            set
            {
                this._tabletNo = value;
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
        public int TabletStock
        {
            get
            {
                return this._tabletStock;
            }
            set
            {
                this._tabletStock = value;
            }
        }
        public override string ToString()
        {
            return string.Format("\n {0} \t {1} \t {2} \t {3}",
                                 this._tabletNo, this._tabletName, this._tabletCost, this._tabletStock);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Tablet t = (Tablet)obj;
                return (_tabletNo == t._tabletNo)
                        && (_tabletName == t._tabletName)
                        && (_tabletCost == t._tabletCost)
                        && (_tabletStock == t._tabletStock);
            }
        }
        public override int GetHashCode()
        {
            Tablet t1 = new Tablet(1, "citrizen", 5, 500);
            Tablet t2 = new Tablet();
            if (t1.Equals(t2))
            {
                return 1;
            }
            return 0;
        }
    }
}