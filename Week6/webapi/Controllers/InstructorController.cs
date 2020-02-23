using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapi.Database;


namespace webapi.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructorController : ControllerBase 
    {

        [HttpGet]
        public ActionResult<List<Instructor>> Get()
        {
            return Ok(getInstructors());
        }


        private List<Instructor> getInstructors()
        {
            return InMemory.Instructors;
        }
    }
}