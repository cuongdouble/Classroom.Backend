using System;

namespace Classroom.Backend.Entity.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Guid AssignmentId { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime CreateAt { get; set; }

        public Comment()
        {
            Id = Guid.NewGuid();
        }
    }
}
