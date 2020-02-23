using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapi.Database;


namespace webapi.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase 
    {

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(getStudents());
        }


        private List<Student> getStudents()
        {
            return InMemory.Students;
        }
    }

  


}