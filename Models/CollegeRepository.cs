namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>
        {
            new Student { Id = 1, StudentName = "John", Email = "student1@gmail.com", Address = "USA" },
            new Student { Id = 2, StudentName = "Smith", Email = "student2@gmail.com", Address = "UK" },
            new Student { Id = 3, StudentName = "Doe", Email = "student3@gmail.com", Address = "Canada" }
        };
    }
}
