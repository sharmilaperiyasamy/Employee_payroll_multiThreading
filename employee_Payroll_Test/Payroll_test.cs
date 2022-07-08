using System.Collections.Generic;
using AutoMapper;
using Employee_MultiThreading;

namespace employee_Payroll_Test
{
    public class Tests
    {
        [Test]
        public void GivenListOfMultiEmployee_AddIntoDB_TestTimeWithout_MultiThreading()
        {
            List<Employee_Profile> emp = new List<Employee_Profile>();
            emp.Add(new Employee_Profile(id: 7, name: "Santhosh", salary: 20000, startdate: DateTime.Now, gender: "M", phone_no: "8909687800", address: "Nagerkoil", department: "Production", basic_pay: 21000, deductions: 1200, taxable_pay: 1000, income_tax: 2100, net_pay: 19000));
            emp.Add(new Employee_Profile(id: 8, name: "Hari", salary: 21000, startdate: DateTime.Now, gender: "M", phone_no: "8989809099", address: "Kerala", department: "Marketing", basic_pay: 23000, deductions: 1400, taxable_pay: 1300, income_tax: 2300, net_pay: 21000));
            emp.Add(new Employee_Profile(id: 9, name: "Sampath", salary: 23000, startdate: DateTime.Now, gender: "M", phone_no: "7898090795", address: "Tirupur", department: "Sales", basic_pay: 24000, deductions: 1500, taxable_pay: 1400, income_tax: 2400, net_pay: 22000));
            emp.Add(new Employee_Profile(id: 10, name: "Savitha", salary: 24000, startdate: DateTime.Now, gender: "F", phone_no: "8934565563", address: "Mumbai", department: "Testing", basic_pay: 25000, deductions: 1600, taxable_pay: 1500, income_tax: 2500, net_pay: 23000));

            Payroll_DB_Connection payroll = new Payroll_DB_Connection();
            DateTime startTime = DateTime.Now;
            payroll.addEmployee(emp);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Time required to add multiple employees without using Thread: " + (endTime - startTime));
        }
    }
}