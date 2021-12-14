using Classroom.Backend.Contracts;
using Classroom.Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Repository
{
    public class AssignmentRepository : RepositoryBase<AssignmentRepository>, IAssignmentRepository
    {
        public AssignmentRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }
    }
}
