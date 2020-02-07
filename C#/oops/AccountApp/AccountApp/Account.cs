using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Account
    {
        private string _custName;
        private string _acNo;
        private int _balance;
        private int _deposit;

        public Account(string CustName, string AcNo, int BalAmt)
        {
            _custName = CustName;
            _acNo = AcNo;
            _balance = BalAmt;
            Console.WriteLine("Account created");
        }

        public Account(string account, string name)
            : this(account, name, 500)
        {
        }

        public string CustName()
        {
            return _custName;
        }

        public string AcNo()
        {
            return _acNo;
        }

        public int BalAmt()
        {
            return _balance;
        }

        public int Deposite()
        {
            return _deposit;
        }

        public int DepositeAmt(int DepositeAmt)
        {
            return _balance = _balance + DepositeAmt;
        }

        public void Withraw(int withdrwaning)
        {
            if (withdrwaning > _balance)
            {
                Console.WriteLine("Withdrwal Request denied");
            }
            else
            {
                _balance = _balance - withdrwaning;
            }

        }

    }
}
