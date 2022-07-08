using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Employee_MultiThreading
{
    public class Payroll_DB_Connection
    {
        public static string connectionString = "Data Source = DESKTOP-VMLSH89\\SQLEXPRESS;Database = payroll_service;Trusted_Connection=true";
        public List<Employee_Profile> emp = new List<Employee_Profile>();
        public void addEmployee(List<Employee_Profile> emp)
        {
            foreach (Employee_Profile emp_Profile in emp)
            {
                this.createRecord(emp_Profile);
                Console.WriteLine("Employee Added: " + emp_Profile.name);
            }
        }
        public void createRecord(Employee_Profile profile)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SpAddEmployeeDetails", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", profile.name);
                command.Parameters.AddWithValue("@salary", profile.salary);
                command.Parameters.AddWithValue("@startdate", profile.startdate);
                command.Parameters.AddWithValue("@gender", profile.gender);
                command.Parameters.AddWithValue("@phone_no", profile.phone_no);
                command.Parameters.AddWithValue("@department", profile.department);
                command.Parameters.AddWithValue("@address", profile.address);
                command.Parameters.AddWithValue("@basic_pay", profile.basic_pay);
                command.Parameters.AddWithValue("@deductions", profile.deductions);
                command.Parameters.AddWithValue("@taxable_pay", profile.taxable_pay);
                command.Parameters.AddWithValue("@income_tax", profile.income_tax);
                command.Parameters.AddWithValue("@net_pay", profile.net_pay);
                command.ExecuteNonQuery();
                Console.WriteLine("Records are created successfully.");
                connection.Close();
            }
        }
    }
}
