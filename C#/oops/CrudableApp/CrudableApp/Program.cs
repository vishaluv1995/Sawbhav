using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudableApp.Model;

namespace CrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDboperation(new OrderDB());
            DoDboperation(new CustomerDB());

            Console.ReadLine();
        }

        public static void DoDboperation(ICrudable crudable)
        {
            Console.WriteLine("Dolg DB Operation");
            crudable.Create();
            crudable.Update();
            crudable.Read();
            crudable.Delete();

        }
    }
}
