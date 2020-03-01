using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using database;


namespace webapi.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase 
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext){
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            var result = _dbContext.Student.ToList();
            return Ok(result);
        }

    }

  


}