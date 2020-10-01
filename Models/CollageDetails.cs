using System;
using System.Collections.Generic;
using System.Text;

namespace StudentModule.Models
{
    public class CollageDetails
    {
        public int ID { get; set; }
        public String CollegeRegNo { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public String Specification { get; set; }
        public String University { get; set; }
        public IList<Student> Student { get; set; }
    }
}
