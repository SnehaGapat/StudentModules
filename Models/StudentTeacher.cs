using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule.Models
{
    public class StudentTeacher
    {
        public int ID { get; set; }
        public int TeacherID{get;set;}
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }

    }
}
