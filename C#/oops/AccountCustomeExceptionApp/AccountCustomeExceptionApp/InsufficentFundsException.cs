using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountCustomeExceptionApp
{
    class InsufficentFundsException : Exception
    {
        private Account accountholder;

        public InsufficentFundsException(Account account)
        {
            accountholder = account;
        }

        public InsufficentFundsException(string message)
        {

        }

        public override string Message
        {
            get
            {
                return "Account" + accountholder.AcNo + " named" + accountholder.CustName + " have balcne of only " + accountholder.BalAmt + " but you tried to witdaw" +
                "amount was" + accountholder.WithdrawAmtReq + "which is less than mininmum balance. Txn Declined by ICIC bank !!";
            }
        }
    }
}
