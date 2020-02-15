using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        private static int nextid;
        private string id;

        private string firstname;
        private string lastname;

        public Customer(string firstname, string lastname)
        {
            nextid += 1;
            id = "C00" + nextid;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string CustprefixWithId
        {
            get
            {
                return id;
            }
        }
    }
}
