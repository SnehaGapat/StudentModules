using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule.Models
{
   public class Grade
    {
        public int ID { get; set; }
        public String letters { get; set; }
        public IList<Student> Student{ get; set; }
    }
}
