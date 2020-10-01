using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule.Models
{
    public class CourseType
    {
        public int ID { get; set; }
        //public String Type { get; set; }
        public int CourseID{ get; set; }
        public int StudentID { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
