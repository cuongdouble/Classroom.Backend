using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Classroom.Backend.Entity.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual AccountType AccountType { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
