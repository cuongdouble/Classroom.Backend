using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Entity.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Assignment> Assignments { get; set; }

        public List<ClassTeacher> ClassTeachers { get; set; }
    }
}
