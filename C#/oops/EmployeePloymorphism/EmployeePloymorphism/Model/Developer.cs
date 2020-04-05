using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePloymorphism.Model
{
    class Developer:Employee
    {
        private const int _pa = 40;
        private const int _insentive = 30;

        public Developer(int eno, string name, double basic):base(eno,name,basic)
        {

        }

        public override double CalculateNetSalary()
        {
            return DaAmt + InsentiveAmt + base.basic;   
        }

        public override string SalarySplitComponent()
        {
            throw new NotImplementedException();    
        }

        public double DaAmt
        {
            get
            {
                return base.basic * _pa / 100;
            }
        }

        public double InsentiveAmt
        {
            get
            {
                return base.basic * _insentive / 100;
            }
        }

        public override string Designation()
        {
            return "Developer";
        }
    }
}
