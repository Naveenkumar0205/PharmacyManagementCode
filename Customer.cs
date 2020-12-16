using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    class Customer
    {
        private string _customerName;
        private string _customerPhone;
        private string _customerEmail;
        private string _customerCity;
        private int _customerBalance;

        public Customer()
        {

        }

        public Customer(string customerName, string customerPhone, string customerEmail, string customerCity, int customerBalance)
        {
            this._customerName = customerName;
            this._customerPhone = customerPhone;
            this._customerEmail = customerEmail;
            this._customerCity = customerCity;
            this._customerBalance = customerBalance;
        }

        public string CustomerName
        {
            get
            {
                return this._customerName;
            }
            set
            {
                this._customerName = value;
            }
        }
        public string CustomerPhone
        {
            get
            {
                return this._customerPhone;
            }
            set
            {
                this._customerPhone = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                return this._customerEmail;
            }
            set
            {
                this._customerEmail = value;
            }
        }
        public string CustomerCity
        {
            get
            {
                return this._customerCity;
            }
            set
            {
                this._customerCity = value;
            }
        }
        public int CustomerBalance
        {
            get
            {
                return this._customerBalance;
            }
            set
            {
                this._customerBalance = value;
            }
        }
        public override string ToString()
        {
            return string.Format("\n Customer Name : {0} \n Customer Phoneno : {1} \n Customer EmailId : {2} \n Customer City : {3} \n Customer Balance : {4}",
                                 this._customerName, this._customerPhone, this._customerEmail, this._customerCity, this._customerBalance);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Customer c = (Customer)obj;
                return (_customerName == c._customerName)
                        && (_customerPhone == c._customerPhone)
                        && (_customerEmail == c._customerEmail)
                        && (_customerCity == c._customerCity)
                        && (_customerBalance == c._customerBalance);
            }
        }
        public override int GetHashCode()
        {
            Customer c1 = new Customer("Naveen", "9494749492", "naveenbhageradhi@gmail.com", "chittoor", 5000);
            Customer c2 = new Customer();
            if (c1.Equals(c2))
            {
                return 1;
            }
            return 0;
        }
    }
}