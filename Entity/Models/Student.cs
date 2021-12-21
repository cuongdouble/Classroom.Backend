using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Entity.Models
{
    public class Student
    {
        public Guid Id { get; set; }

        public string StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<ClassStudent> ClassStudents { get; set; }

        public List<AssignmentGrade> AssignmentGrades { get; set; }
    }
}
