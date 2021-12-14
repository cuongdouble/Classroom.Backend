using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Contracts
{
    public interface IRepositoryManager
    {
        IAssignmentGradeRepository AssignmentGradeRepository { get; }

        IAssignmentRepository AssignmentRepository { get; }

        IClassRepository ClassRepository { get; }

        IClassStudentRepository ClassStudentRepository { get; }

        IClassTeacherRepository ClassTeacherRepository { get; }

        ICommentRepository CommentRepository { get; }

        IStudentRepository StudentRepository { get; }

        ITeacherRepository TeacherRepository { get; }

        void Save();
    }
}
