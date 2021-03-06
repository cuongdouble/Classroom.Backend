using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Entity.Models
{
    public class Class
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TeacherId { get; set; }

        public Class()
        {
            Id = Guid.NewGuid();
        }
    }
}
