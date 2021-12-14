using Microsoft.AspNetCore.Identity;
using System;

namespace Classroom.Backend.Entity.Models
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
