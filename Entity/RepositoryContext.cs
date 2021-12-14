using Classroom.Backend.Entity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Classroom.Backend.Entity
{
    public class RepositoryContext : IdentityDbContext<User, Role, Guid>
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClassStudent>().HasKey(sc => new { sc.ClassId, sc.StudentId });
            modelBuilder.Entity<ClassTeacher>().HasKey(sc => new { sc.ClassId, sc.TeacherId });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<AssignmentGrade> AssignmentGrades { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<ClassStudent> ClassStudents { get; set; }

        public DbSet<ClassTeacher> ClassTeachers { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
