using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            /*Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = " fernandes";
            emp.Salary = 14000;*/
            employees.Add(new Employee() { FirstName = "johnson", LastName = " fernandes", Salary = 14000 });
            /*emp.FirstName = "michael";
            emp.LastName = " jackson";
            emp.Salary = 16000;*/
            employees.Add(new Employee() { FirstName = "michael", LastName = " jackson", Salary = 16000 });
            /*emp.FirstName = "robert";
            emp.LastName = " patterson";
            emp.Salary = 20000;*/
            employees.Add(new Employee() { FirstName = "robert", LastName = " patterson", Salary = 20000 });
            return employees;
        }
    }
}