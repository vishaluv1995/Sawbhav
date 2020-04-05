using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomeExceptionApp
{
    class Account
    {
        private string _custName;
        private string _acNo;
        private int _balance;
        private int _withdrawamt;

        public Account(string CustName, string AcNo, int BalAmt)
        {
            _custName = CustName;
            _acNo = AcNo;
            _balance = BalAmt;
            Console.WriteLine("Account created");
        }

        public Account(string name, string account)
            : this(name, account, 1000)
        {
        }

        public void DepositeAmt(int depositeamt)
        {
            Console.WriteLine("Amount has been desposited:" + depositeamt);
            _balance = _balance + depositeamt;
        }

        public void WithrawAmt(int amount)
        {
            _withdrawamt = amount;

            if (_balance < amount)
            {
                //throw new InsufficentFundsException("Withrwal request has been denied");
                throw new InsufficentFundsException(this);
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

        public int WithdrawAmtReq
        {
            get
            {
                return _withdrawamt;
            }
        }
    }
}
