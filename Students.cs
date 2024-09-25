using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace StudentDatabaseApp.Models
    {
        public class Student
        {
            public int StudentId { get; set; }  // Students ID  (Primary Key)
            public string FirstName { get; set; }  // Student Name
            public string LastName { get; set; }  // Student Last Nmae 
            public DateTime EnrollmentDate { get; set; }  // registiration date 
        }
    }
