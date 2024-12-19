using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        // In-memory list of students for demonstration
        private static readonly List<Student> Students = new List<Student>
        {
            new Student { Id = 1, Name = "Amal", Age = 20, Grade = "A" },
            new Student { Id = 2, Name = "Alwin", Age = 22, Grade = "B" },
            new Student { Id = 3, Name = "Sarath", Age = 18, Grade = "D" },
            new Student { Id = 4, Name = "Roith", Age = 19, Grade = "C" },
            new Student { Id = 5, Name = "Dhanush", Age = 21, Grade = "A" }
        };

        // Get all students
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(Students);
        }

        // Get a student by ID
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound(new { Message = $"Student with ID {id} not found." });
            }
            return Ok(student);
        }

        // Trigger an error for testing exception handling
        [HttpGet("error")]
        public IActionResult TriggerError()
        {
            throw new Exception("This is a test exception!");
        }
    }

    // Student model
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Grade { get; set; }
    }
}
