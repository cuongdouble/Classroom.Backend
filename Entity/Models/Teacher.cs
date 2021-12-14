using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Entity.Models
{
    public class Teacher : User
    {
        public override AccountType AccountType => AccountType.Teacher;

        public List<Assignment> Assignments { get; set; }

        public List<ClassTeacher> ClassTeachers { get; set; }
    }
}
