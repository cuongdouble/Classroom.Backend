using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Entity.Models
{
    public class Student : User
    {
        public string StudentId { get; set; }

        public override AccountType AccountType => AccountType.Student;

        public List<ClassStudent> ClassStudents { get; set; }

        public List<AssignmentGrade> AssignmentStudents { get; set; }
    }
}
