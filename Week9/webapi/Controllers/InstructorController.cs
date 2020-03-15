using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using database;


namespace webapi.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructorController : ControllerBase 
    {

       
        private readonly SchoolContext _dbContext;

        public InstructorController(SchoolContext dbContext){
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Instructor>> GetAllInstructors()
        {
            var result = _dbContext.Instructor.ToList();
            return Ok(result);
        }
    }
}