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
        private int _countrans;
        private const int _minbal = 500;

        public Account(string CustName, string AcNo, int BalAmt)
        {
            _custName = CustName;
            _acNo = AcNo;
            _balance = BalAmt;
            //_countrans = 0;
            Console.WriteLine("Account created");
        }

        public Account(string name, string account)
            : this(name, account, 500)
        {
        }

        public void DepositeAmt(int depositeamt)
        {
            Console.WriteLine("Amount has been desposited:" + depositeamt);
            _balance = _balance + depositeamt;
            _countrans++;
        }

        public void WithrawAmt(int amount)
        {
            if ((_balance - amount) < _minbal)
            {
                Console.WriteLine("Maintain minimum balance 500rs Withdrwal Request has been denied");
                return;
            }

            _balance = _balance - amount;
            _countrans++;
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

        public int NumberOfTransCount
        {
            get
            {
                return _countrans;
            }
        }
    }
}
