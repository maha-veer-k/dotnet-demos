using BasicAuthentication.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace BasicAuthentication.API.Controllers
{
    [BasicAuthentication]
    public class EmployeeController : ApiController
    {
        
        public HttpResponseMessage GetEmployees()
        {
            string UserName = Thread.CurrentPrincipal.Identity.Name;

            var EmpList = new EmployeeBL().GetEmployees();

            switch (UserName.ToLower())
            {
                case "backend":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(emp => emp.Dept == "backend").ToList());

                case "frontend":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(emp => emp.Dept == "frontend").ToList());

                case "hr":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(emp => emp.Dept == "hr").ToList());

                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }

}
