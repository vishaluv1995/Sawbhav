using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePloymorphism.Model
{
    class Manager : Employee
    {
        private const int hra = 50;
        private const int ta = 40;
        private const int da = 30;

        public Manager(int eno, string name, double basic) : base(eno, name, basic)
        {

        }

        public override double CalculateNetSalary()
        {
            return HraAmt + DaAmt + DaAmt + base.basic;
        }

        public override string SalarySplitComponent()
        {
            throw new NotImplementedException();    
        }

        public override string Designation()
        {
            return "Manager";
        }

        public double HraAmt
        {
            get
            {
                return base.basic * hra / 100;
            }
        }

        public double TaAmt
        {
            get
            {
                return base.basic * ta / 100;
            }
        }

        public double DaAmt
        {
            get
            {
                return base.basic * da / 100;
            }
        }
    }
}
