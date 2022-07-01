using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class defController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var context = new Context();
            var value = context.Employees.ToList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var context = new Context();
            context.Add(employee);
            context.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult employeGet(int id)
        {
            var context = new Context();
            var values = context.Employees.Find(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult Edit([FromBody] Employee employee)
        {
            var context = new Context();
            var value = context.Employees.FirstOrDefault(x => x.Id == employee.Id);
            value.Name = employee.Name;
            context.Update(value);
            context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Dekete(int id)
        {
            var context = new Context();
            var value = context.Employees.Find(id);
            context.Remove(value);
            return Ok("deleted succsessfully");
        }
    }
}
