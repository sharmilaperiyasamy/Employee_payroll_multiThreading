using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MultiThreading
{
    public class Employee_Profile
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal salary { get; set; }
        public DateTime startdate { get; set; }
        public string gender { get; set; }
        public string phone_no { get; set; }
        public string department { get; set; }
        public string address { get; set; }
        public decimal basic_pay { get; set; }
        public decimal deductions { get; set; }
        public decimal taxable_pay { get; set; }
        public decimal income_tax { get; set; }
        public decimal net_pay { get; set; }

        public Employee_Profile(int id, string name, decimal salary, DateTime startdate, string gender, string phone_no, string department, string address, decimal basic_pay, decimal deductions, decimal taxable_pay, decimal income_tax, decimal net_pay)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.startdate = startdate;
            this.gender = gender;
            this.phone_no = phone_no;
            this.department = department;
            this.address = address;
            this.basic_pay = basic_pay;
            this.deductions = deductions;
            this.taxable_pay = taxable_pay;
            this.income_tax = income_tax;
            this.net_pay = net_pay;
        }
    }
}
