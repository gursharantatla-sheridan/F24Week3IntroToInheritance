using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24Week3IntroToInheritance
{
    public class SalaryPlusCommissionEmployee : CommissionEmployee
    {
		private double _salary;

		public double Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}

        public SalaryPlusCommissionEmployee(int id, string name, double grossSales, double commissionRate, double salary)
        {
            Id = id;
            Name = name;
        }
    }
}
