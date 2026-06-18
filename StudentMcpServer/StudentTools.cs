using System.ComponentModel;

namespace StudentMcpServer
{
    public class StudentTools
    {
        private static readonly List<Student> Students =
        [
            new()
            {
                Id = 1,
                Name = "Shivang"
            },
            new()
            {
                Id = 2,
                Name = "Rahul"
            },
            new()
            {
                Id = 69,
                Name = "Bhautik"
            }
        ];

        [Description("Get all students")]
        public List<Student> GetAllStudents()
        {
            return Students;
        }

        [Description("Create a new student")]
        public string CreateStudent(int id, string name)
        {
            Students.Add(
                new Student
                {
                    Id = id,
                    Name = name
                });

            return $"Student {name} created successfully";
        }
    }
}
