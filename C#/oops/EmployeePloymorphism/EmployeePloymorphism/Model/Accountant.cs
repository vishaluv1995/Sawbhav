using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePloymorphism.Model
{
    class Accountant : Employee
    {
        private const int perks = 30;

        public Accountant(int eno, string name, double basic):base(eno,name,basic)
        {
        }


        public override double CalculateNetSalary()
        {
            return PerkAmt + base.basic;
        }

        public override string SalarySplitComponent()
        {
             return ("Da Amt");
        }

        public double PerkAmt
        {
            get
            {
                return base.basic * perks / 100;
            }
        }

        public override string Designation()
        {
            return "Accountant";
        }
    }
}
