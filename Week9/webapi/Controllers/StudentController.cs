using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using database;


namespace webapi.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase 
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService){
            _studentService = studentService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{studentId}")]
        public ActionResult<Student> GetStudent(int studentId)
        {
            var student = _studentService.GetStudentById(studentId);

            if (student != null) {
                return Ok(student);
            } else {
                return NotFound();
            }
        }

    }

  


}