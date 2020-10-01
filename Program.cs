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
