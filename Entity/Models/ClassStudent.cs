using System;

namespace Classroom.Backend.Entity.Models
{
    public class ClassStudent
    {
        public Guid ClassId { get; set; }

        public Class Class { get; set; }

        public Guid StudentId { get; set; }

        public Student Student { get; set; }
    }
}
