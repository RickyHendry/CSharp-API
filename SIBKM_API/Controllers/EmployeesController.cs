using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIBKM_API.Context;
using SIBKM_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        MyContext myContext;

        public EmployeesController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var data = myContext.Employees.ToList();
            return Ok(new { status = 200, message = "data has been collected", data = data});
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var data = myContext.Employees.Find(id);
            return Ok(new { status = 200, message = "data has been collected", data = data });
        }

        [HttpPost]
        public ActionResult Post(Employee employee)
        {
            myContext.Employees.Add(employee);
            var result = myContext.SaveChanges();
            if (result > 0)
                return Ok(new { status = 200, message = "data has been collected" });
            return BadRequest(new { status = 200, message = "data has been collected" });
        }

        [HttpPost]
        public ActionResult Put(Employee employee)
        {
            myContext.Employees.Update(employee);
            var result = myContext.SaveChanges();
            if (result > 0)
                return Ok(new { status = 200, message = "data has been collected" });
            return BadRequest(new { status = 200, message = "data has been collected" });
        }
    }
}
