using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Polymorphism
{
    class CurrentAccount : Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private const int OverDraftLimit = -5000;

        public CurrentAccount(int accno, string name, double balance):base(accno,name,balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }

        public override void Withdraw(double withrawrqst)
        {
            if (_balance - withrawrqst < OverDraftLimit)
            {
                Console.WriteLine("Your balance should be altest -5000 maintain for current account");
                return;
            }
            double balance = _balance - withrawrqst;
        }
    }
}
