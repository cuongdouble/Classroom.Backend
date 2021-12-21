using System;
using System.Collections.Generic;

namespace Classroom.Backend.Entity.Models
{
    public class Assignment
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Grade { get; set; }

        public int GradeScale { get; set; }

        public bool IsFinalized { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime Deadline { get; set; }

        public Guid TeacherId { get; set; }

        public Guid ClassId { get; set; }

        public List<AssignmentGrade> AssignmentGrades { get; set; }

        public Assignment()
        {
            Id = Guid.NewGuid();
        }
    }
}
