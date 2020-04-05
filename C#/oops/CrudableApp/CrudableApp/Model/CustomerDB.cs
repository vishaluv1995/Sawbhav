using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("CustomerDB is Created");
        }

        public void Delete()
        {
            Console.WriteLine("CustomerDB is Created");
        }

        public bool Isexist()
        {
            return true;
        }

        public void Read()
        {
            Console.WriteLine("CustomerDB is Read");
        }

        public void Update()
        {
            Console.WriteLine("CustomerDB is Updated");
        }
    }
}
