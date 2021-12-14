using Classroom.Backend.Contracts;
using Classroom.Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Repository
{
    public class TeacherRepository : RepositoryBase<TeacherRepository>, ITeacherRepository
    {
        public TeacherRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }
    }
}
