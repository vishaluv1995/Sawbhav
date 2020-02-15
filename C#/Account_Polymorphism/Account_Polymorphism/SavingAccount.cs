using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Polymorphism
{
     class SavingAccount : Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        public const int MinBal = 500;

        public SavingAccount(int accno, string name, double balance):base(accno,name,balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
            Console.WriteLine("Account Created");
        }


        public override void Withdraw(double withrawrqst)
        {
            if (_balance - withrawrqst < MinBal)
            {
                Console.WriteLine("Your balance should be altest 500 maintain for saving account");
                return;
            }
            double balance = _balance - withrawrqst;
        }
    }
}
