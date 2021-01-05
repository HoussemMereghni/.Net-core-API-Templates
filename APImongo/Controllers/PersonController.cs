
using System;
using System.Linq;
using System.Threading.Tasks;
using APImongo.Model;
using APImongo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APImongo.Controllers
{
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly AttEmployeeService _employeeService;
        public PersonController(AttEmployeeService context)
        {
            _employeeService = context;
        }

        // Get All Records
        [Route("[controller]")]
        [HttpGet]
        [HttpGet]
        public ActionResult<List<AttEmployees>> Get() =>
            _employeeService.Get();

        [HttpGet("{id:length(8)}", Name = "GetEmployee")]
        public ActionResult<AttEmployees> Get(string id)
        {
            var emp = _employeeService.Get(id);

            if (emp == null)
            {
                return NotFound();
            }

            return emp;
        }

    }

}