using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication.API.Models
{
    public class EmployeeBL
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            for(int i= 1; i <= 10; i++)
            {
                if(i % 3 == 0)
                {
                    employees.Add(new Employee()
                    {
                        Id = i,
                        Name = "Name" + i,
                        Dept = "backend",
                        Salary = 15000
                    });
                }
                else if(i % 3 == 1)
                {
                    employees.Add(new Employee()
                    { 
                        Id = i,
                        Name = "Name" + i,
                        Dept = "frontend",
                        Salary = 15000
                    });
                }
                else
                {
                    employees.Add(new Employee() 
                    {
                        Id = i,
                        Name = "Name" + i,
                        Dept = "hr",
                        Salary = 15000
                    });
                }
            }
            return employees;
        }
    }
}