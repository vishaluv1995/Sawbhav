using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Organization
    {
        private int _id;
        private string _name;
        private int _departmentid;
        private string[] partners = new string[3];
        private int[] departs = new int[3];

        public Organization(int id, string name, int departmentid)
        {
            _id = id;
            _name = name;
            _departmentid = departmentid;
        }

        public void AddPartner(string PartnerName)
        {
            int i = PartnerCount();
            partners[i] = PartnerName;
        }

        public void AddDepartment(int departmentid)
        {
            int i = DepartmentCount();
            departs[i] = departmentid;
        }

        public int PartnerCount()
        {
            int totalpartner = 0;
            foreach (string partNme in partners)
            {
                if (partNme != null)
                {
                    totalpartner++;
                }
            }
            return totalpartner;
        }

        public int DepartmentCount()
        {
            int totalcount = 0;
            foreach (int i in departs)
            {
                if (i != 0)
                {
                    totalcount++;
                }
            }
            return totalcount;
        }

        public IEnumerable<string> Partners
        {
            get
            {
                return partners;
            }
        }

        public IEnumerable<int> Departments
        {
            get
            {
                return departs;
            }
        }
    }
}
