using CollageApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollageApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All", Name = "GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            // OK - 200 - Success
            return Ok(CollegeRepository.Students);

        }

        [HttpGet]
        [Route("{id:int}", Name = "GetStudentById")]
        public ActionResult<Student> GetStudentById(int id)
        {
            if (id <= 0)
            {
                // Bad request - 400 - Client side error
                return BadRequest();
            }

            var student = CollegeRepository.Students.Where(x => x.Id == id).FirstOrDefault();
            if (student == null)
            {
                // Not found - 404 - Client side error
                return NotFound($"Student with id {id} Not Found");
            }
            // OK - 200 - Success
            return Ok(student);
        }

        [HttpGet("{name:alpha}", Name = "GetStudentByName")]
        public ActionResult<Student> GetStudentByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                // Bad request - 400 - Client side error
                return BadRequest();
            }

            var student = CollegeRepository.Students.Where(x => x.StudentName == name).FirstOrDefault();
            if (student == null)
            {
                // Not found - 404 - Client side error
                return NotFound($"Student with name {name} Not Found");
            }
            // OK - 200 - Success
            return Ok(student);
        }

        [HttpDelete("{id}", Name = "DeleteStudentById")]
        public ActionResult<bool> DeleteStudent(int id)
        {
            if (id <= 0)
            {
                // Bad request - 400 - Client side error
                return BadRequest();
            }

            var student = CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            if (student == null)
            {
                // Not found - 404 - Client side error
                return NotFound($"Student with id {id} Not Found");
            }
            CollegeRepository.Students.Remove(student);
            // OK - 200 - Success
            return Ok(true);
        }
    }
}
