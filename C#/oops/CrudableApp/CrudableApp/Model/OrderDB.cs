using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    public class OrderDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order is Created");
        }

        public void Read()
        {
            Console.WriteLine("Order is read");
        }

        public void Update()
        {
            Console.WriteLine("Order is updated");
        }

        public void Delete()
        {
            Console.WriteLine("order is deleted");
        }

        public bool Isexist()
        {
            return true;
        }

    }
}
