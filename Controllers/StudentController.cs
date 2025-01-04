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
        public IEnumerable<Student> GetStudents()
        {
            return CollegeRepository.Students;
        }

        [HttpGet]
        [Route("{id}", Name = "GetStudentById")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
        }

        [HttpGet("{name}", Name = "GetStudentByName")]
        public Student GetStudentByName(string name)
        {
            return CollegeRepository.Students.Where(n => n.StudentName.Contains(name)).FirstOrDefault();
        }
        [HttpDelete("{id}", Name = "DeleteStudentById")]
        public bool DeleteStudent(int id)
        {
            var student = CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            CollegeRepository.Students.Remove(student);
            return true;
        }
    }
}
