using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEquadityApp
{
    public class Account
    {
        private string _custName;
        private string _acNo;
        private int _balance;
        private const int _minbal = 500;

        public Account(string CustName, string AcNo, int BalAmt)
        {
            _custName = CustName;
            _acNo = AcNo;
            _balance = BalAmt;
            Console.WriteLine("Account created");
        }

        public Account(string name, string account)
            : this(name, account, 500)
        {
        }

        public override string ToString()
        {

            return "Acno :" + _acNo + " Name :" + CustName + " Balance:" + _balance;
        }

        public override bool Equals(object obj)
        {
            Account second = (Account)obj;
            return second.AcNo.Equals(this.AcNo);
        }

        public void DepositeAmt(int depositeamt)
        {
            Console.WriteLine("Amount has been desposited:" + depositeamt);
            _balance = _balance + depositeamt;
        }

        public void WithrawAmt(int amount)
        {
            if ((_balance - amount) < _minbal)
            {
                Console.WriteLine("Maintain minimum balance 500rs Withdrwal Request has been denied");
                return;
            }

            _balance = _balance - amount;
        }

        public string CustName
        {
            get
            {
                return _custName;
            }
        }

        public string AcNo
        {
            get
            {
                return _acNo;
            }
        }

        public int BalAmt
        {
            get
            {
                return _balance;
            }

        }

    }
}
