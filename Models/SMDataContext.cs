using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace StudentModule.Models
{
    public class SMDataContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<CollageDetails> CollageDetail { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = "DataSource=SNEHAL-PC\\SQLEXPRESS02,Initial Catalog=StudentDB,Integrated Security=True";
            optionsBuilder.UseSqlServer(connstr);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Foo>().Property(s => s.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //For Student(1-to-M)

            modelBuilder.Entity<Student>().HasKey(s => new { s.ID });
            modelBuilder.Entity<Student>().Property(s => s.FirstName).HasColumnType("varchar(60)").IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.LastName).HasColumnType("varchar(60)").IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.Address).HasColumnType("varchar(60)").IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.Gender).HasColumnType("varchar(60)").IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.Age).HasColumnType("varchar(3)").IsRequired();
            modelBuilder.Entity<Student>().HasOne<Grade>(s => s.Grade).WithMany(g => g.Student).HasForeignKey(s => s.GradeId);
            modelBuilder.Entity<Student>().HasOne<CollageDetails>(s => s.CollageDetails).WithMany(g => g.Student).HasForeignKey(s => s.GradeId);


            //For Teacher

            modelBuilder.Entity<Teacher>().HasKey(T => new { T.ID });
            modelBuilder.Entity<Teacher>().Property(T => T.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Teacher>().Property(T=>T.Gender).HasColumnType("varchar(60)").IsRequired();
            modelBuilder.Entity<Teacher>().Property(T => T.Address).HasColumnType("varchar(60)").IsRequired();
            modelBuilder.Entity<Teacher>().Property(T=> T.Qualification).HasColumnType("varchar(60)").IsRequired();

            //For CourseType(M-To-M)

            modelBuilder.Entity<CourseType>().HasKey(ct => new { ct.ID });
            modelBuilder.Entity<CourseType>().HasOne<Student>(ct => ct.Student).WithMany(s => s.CourseType).HasForeignKey(ct => ct.StudentID);
            modelBuilder.Entity<CourseType>().HasOne<Course>(ct => ct.Course).WithMany(s => s.CourseType).HasForeignKey(ct => ct.CourseID);
            
            //for StudentTeacher(M-To-M)

            modelBuilder.Entity<StudentTeacher>().HasOne<Student>(st => st.Student).WithMany(s => s.StudentTeacher).HasForeignKey(ct => ct.StudentID);
            modelBuilder.Entity<StudentTeacher>().HasOne<Teacher>(st => st.Teacher).WithMany(s => s.StudentTeacher).HasForeignKey(ct => ct.TeacherID);
           
            // For Course

            modelBuilder.Entity<Course>().Property(c => c.CourseName).HasColumnType("varchar(80)").IsRequired();
            modelBuilder.Entity<Course>().Property(c => c.CourseContent).HasColumnType("varchar(100)").IsRequired();
            // modelBuilder.Entity<Course>().Property(c => c.Fees).HasPrecision(decimal(14,2)).IsRequired();
            modelBuilder.Entity<Course>().Property(c => c.Fees).HasColumnType("decimal(14,2)").IsRequired();

            //For CollageDetails
            modelBuilder.Entity<CollageDetails>().Property(cd => cd.CollegeRegNo).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<CollageDetails>().Property(cd => cd.Location).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<CollageDetails>().Property(cd => cd.Name).HasColumnType("varchar(90)").IsRequired();
            modelBuilder.Entity<CollageDetails>().Property(cd => cd.Specification).HasColumnType("varchar(100)").IsRequired();
        }
    }
}
