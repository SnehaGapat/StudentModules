using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule.Models
{
    public class Course
    {
        public int ID { get; set; }
        public String CourseName { get; set; }
        public String  CourseContent{ get; set; }
        public decimal Fees { get; set; }
        public IList<CourseType> CourseType { get; set; }
    }
}
