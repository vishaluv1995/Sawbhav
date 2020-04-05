using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization organization = new Organization(1, "DataComp Webtechnology",1);
            organization.AddPartner("Ajay Arora");
            organization.AddPartner("Madhu");
            organization.AddPartner("Pradeep");

            foreach (string partnername in organization.Partners)
            {
                Console.WriteLine(partnername);
            }

            Console.WriteLine("");

            IEnumerator<string> enumerator = organization.Partners.GetEnumerator();

            while (enumerator.MoveNext())
            {
                string n = enumerator.Current;
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }

        static void Write(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                int value = e.Current;
                Console.WriteLine(value);
            }
        }
    }
}
