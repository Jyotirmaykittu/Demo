using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APITddDemo.DataRepository;
using APITddDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace APITddDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //private readonly IDataRepository/*<Employee>*/ _dataRepository;

        //public ValuesController(IDataRepository/*<Employee>*/ dataRepository)
        //{
        //    _dataRepository = dataRepository;
        //}

        private readonly EmployeeContext _db;
        private DbContextOptions<EmployeeContext> _options;

        public ValuesController (EmployeeContext context)
        {
            _db = context;
        }

        public ValuesController(DbContextOptions<EmployeeContext> options)
        {
            _options = options;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _db.Employees.ToList();
            return Ok(employees);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //var emp = _db.Employees.FirstOrDefault(e => e.EmpId == id);
            return Ok( _db.Employees.FirstOrDefault(e => e.EmpId == id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
