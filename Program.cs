using Microsoft.EntityFrameworkCore.Diagnostics;
using StudentModule.Models;
using System;
using System.Net.Sockets;

namespace StudentModule
{
    class Program
    {
        static void Main(string[] args)
        {
            SMDataContext context = new SMDataContext();
            Student newStudent = new Student()
            {
                FirstName = "Denis",
                LastName = "Rechared",
                Address = "Newyork city",
                Gender = "Male",
                Age = 32,
                GradeId = 2,
                collageID = 10001
               };
            Student newStudents = new Student()
            {
                FirstName = "Deni",
                LastName = "Rechared",
                Address = "Londan",
                Gender = "Female",
                Age = 22,
                GradeId = 1,
                collageID = 10003
            };
        }
       /* private static void AddPatient(SMDataContext context)
        {
            context.Add (new Student()
            {
                FirstName = "Denies";
                LastName = "Richard";
            AddressFamily = "NewYork";
            };
        }
        */
    }
}
