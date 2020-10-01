using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule.Models
{
   public class Teacher
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Gender { get; set; }
        public String Qualification { get; set; }
        public IList<StudentTeacher> StudentTeacher { get; set; }
    }
}
