using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Classroom.Backend.Entity.Models
{
    public class User : IdentityUser<Guid>
    {
        public virtual AccountType AccountType { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
