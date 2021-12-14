using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Entity.Models
{
    public class AssignmentGrade
    {
        public Guid Id { get; set; }

        public Guid StudentId { get; set; }

        public float Grade { get; set; }

        public float ExpectationGrade { get; set; }

        public string StudentExplanation { get; set; }

        public bool IsFinalDecision { get; set; }

        public AssignmentGrade()
        {
            Id = Guid.NewGuid();
        }
    }
}
