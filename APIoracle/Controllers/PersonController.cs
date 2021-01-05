
using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIoracle.Models;

namespace APIoracle.Controllers
{
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly ModelContext _context;
        public PersonController(ModelContext context)
        {
            _context = context;
        }

        // Get All Records
        [Route("[controller]")]
        [HttpGet]
        public ActionResult GetPerson()
        {
            return Ok(_context.AttEmployees.ToList());
        }

        //Get Record by Id
        [Route("[controller]/{id}")]
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            string empid = id.ToString();
            return Ok(_context.AttEmployees.FirstOrDefault(obj => obj.EmployeeNo == empid));

        }

        //Get Record by Email -- explicit route exp: /Person/GetByEmail/xxx@xxx.x
        [Route("[controller]/[action]/{email}")]
        [HttpGet("{email}")]

        public ActionResult GetByEmail(string email)
        {
            return Ok(_context.AttEmployees.FirstOrDefault(o => o.Email == email));
        }

        //Add a new Record
        [Route("[controller]")]
        [HttpPost]
        public async Task<ActionResult<AttEmployees>> AddEmployee(AttEmployees emp)
        {
            if (!Exists(Int32.Parse(emp.EmployeeCode)))
            {
                _context.AttEmployees.Add(emp);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Content("Object already exists!");
            }
            return Ok(_context.AttEmployees.ToList());
        }

        //Delete a Record -- route exp: /Person/DeleteEmployee
        [Route("[controller]/[action]")]
        [HttpPost]
        public async Task<ActionResult<AttEmployees>> DeleteEmployee(AttEmployees emp)
        {
            if (Exists(Int32.Parse(emp.EmployeeCode)))
            {
                _context.AttEmployees.Remove(emp);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Content("Object not found!");
            }

            return Ok(_context.AttEmployees.ToList());
        }

        //Update a Record
        [Route("[controller]")]
        [HttpPut]
        public async Task<ActionResult<AttEmployees>> UpdateEmployee(AttEmployees emp)
        {
            if (!Exists(Int32.Parse(emp.EmployeeCode)))
            {
                return BadRequest();
            }
            _context.Entry(emp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                if (!Exists(Int32.Parse(emp.EmployeeCode)))
                {
                    return NotFound();
                }
                else { throw; }
            }

            return Ok(_context.AttEmployees.ToList());
        }
        public bool Exists(int id) => _context.AttEmployees.Any(e => Int32.Parse(e.EmployeeCode) == id);

    }

}