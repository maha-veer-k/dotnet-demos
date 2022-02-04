using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }
    }
}