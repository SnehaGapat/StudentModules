using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String Gender { get; set; }
        public int  Age{ get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int collageID { get; set; }
        
        public CollageDetails CollageDetails { get; set; }
        public IList<CourseType> CourseType { get; set; }
        public IList<StudentTeacher> StudentTeacher{ get; set; }

    }
}
