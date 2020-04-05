using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePloymorphism.Model
{
    abstract class Employee
    {
        private int eno;
        private string name;
        protected double basic;

        public Employee(int eno,string name,double basic)
        {
            this.eno = eno;
            this.name = name;
            this.basic = basic;
        }

        public int EmpNo
        {
            get
            {
                return eno;
            }
        } 

        public string EmpName
        {
            get
            {
                return name;
            }
        }

        public double Getbasic
        {
            get
            {
                return basic;
            }
        }

        public virtual string Designation()
        {
            return "Employee";
        }

        public abstract double CalculateNetSalary();

        public abstract string SalarySplitComponent();
    }
}
