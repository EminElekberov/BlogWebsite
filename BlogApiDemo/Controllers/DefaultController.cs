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
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c = new Context();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmplyeeGet(int id)
        {
            using var c = new Context();
            var values = c.Employees.Find(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {

            using var c = new Context();
            var values = c.Employees.Find(id);
            if (values==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(values);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Employee category)
        {
            using var c = new Context();
            var categorydb = await c.Employees.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (categorydb == null)
            {
                return NotFound();
            }
            categorydb.Name = category.Name;
            c.Update(categorydb);
            await c.SaveChangesAsync();
            return Ok($"Edit Succesfully {category.Name}");
        }
    }
}
