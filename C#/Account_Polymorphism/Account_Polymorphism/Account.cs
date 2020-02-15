using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Polymorphism
{
    abstract class Account
    {
        private int _accno;
        private string _name;
        private double _balance;

        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }

        public void Deposite(double amt)
        {
            _balance = _balance + amt;
        }

        public abstract void Withdraw(double withdrawrqst);

        public int GetAccountNo
        {
            get
            {
                return _accno;
            }
        }

        public string GetName
        {
            get
            {
                return _name;
            }
        }

        public Double GetBalance
        {
            get
            {
                return _balance;
            }
        }

        
    }
}
