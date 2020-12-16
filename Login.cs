using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    class Login
    {
        public string _userName;
        public string _pass;

        public Login(string UserName, string pass)
        {
            this._userName = UserName;
            this._pass = pass;
        }
        public string Pass
        {
            get
            {
                return this._pass;
            }
            set
            {
                this._pass = value;
            }
        }
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Hi  " + _userName);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Login lo = (Login)obj;
                return (_userName == lo._userName) && (_pass == lo._pass);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Vlogin
    {
        public string _vuserName;
        public string _vpass;

        public Vlogin(string VuserName, string Vpass)
        {
            this._vuserName = VuserName;
            this._vpass = Vpass;
        }
        public string Vpass
        {
            get
            {
                return this._vpass;
            }
            set
            {
                this._vpass = value;
            }
        }
        public string VuserName
        {
            get
            {
                return this._vuserName;
            }
            set
            {
                this._vuserName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Hi  " + _vuserName);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Login lo = (Login)obj;
                return (_vuserName == lo._userName);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}