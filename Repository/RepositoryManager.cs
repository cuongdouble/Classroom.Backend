using Classroom.Backend.Contracts;
using Classroom.Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private IAssignmentGradeRepository _assignmentGradeRepository;
        private IAssignmentRepository _assignmentRepository;
        private IClassRepository _classRepository;
        private IClassStudentRepository _classStudentRepository;
        private IClassTeacherRepository _classTeacherRepository;
        private ICommentRepository _commentRepository;
        private IStudentRepository _studentRepository;
        private ITeacherRepository _teacherRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IAssignmentGradeRepository AssignmentGradeRepository
        {
            get
            {
                if (_assignmentGradeRepository == null)
                    _assignmentGradeRepository = new AssignmentGradeRepository(_repositoryContext);

                return _assignmentGradeRepository;
            }
        }

        public IAssignmentRepository AssignmentRepository
        {
            get
            {
                if (_assignmentRepository == null)
                    _assignmentRepository = new AssignmentRepository(_repositoryContext);

                return _assignmentRepository;
            }
        }

        public IClassRepository ClassRepository
        {
            get
            {
                if (_classRepository == null)
                    _classRepository = new ClassRepository(_repositoryContext);

                return _classRepository;
            }
        }

        public IClassStudentRepository ClassStudentRepository
        {
            get
            {
                if (_classStudentRepository == null)
                    _classStudentRepository = new ClassStudentRepository(_repositoryContext);

                return _classStudentRepository;
            }
        }

        public IClassTeacherRepository ClassTeacherRepository
        {
            get
            {
                if (_classTeacherRepository == null)
                    _classTeacherRepository = new ClassTeacherRepository(_repositoryContext);

                return _classTeacherRepository;
            }
        }

        public ICommentRepository CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new CommentRepository(_repositoryContext);

                return _commentRepository;
            }
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                if (_studentRepository == null)
                    _studentRepository = new StudentRepository(_repositoryContext);

                return _studentRepository;
            }
        }

        public ITeacherRepository TeacherRepository
        {
            get
            {
                if (_teacherRepository == null)
                    _teacherRepository = new TeacherRepository(_repositoryContext);

                return _teacherRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
