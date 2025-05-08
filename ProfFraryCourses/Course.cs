using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfFraryCourses
{
    internal class Course
    {
        // Started out with automatic properties
        public string DeptID {  get; set; }
        public string CourseNum { get; set; }
        public string CourseName { get; set; }
        public int Credits {  get; set; } 

        // default constructor - no parameters
        public Course() {
            DeptID = string.Empty;
            CourseNum = string.Empty;
            CourseName = string.Empty;
            Credits = 3;
        }

        public Course(string dept, string crsNum, 
            string crsName, int cred)
        {
            DeptID = dept;
            CourseNum = crsNum;
            CourseName = crsName;
            Credits = cred;
        }

        public override string ToString()
        {

           /* return ("Department is " + DeptID +
                " Course Number is " + CourseNum +
                " Course Name is " + CourseName + 
                " Number of Credits is " + Credits.ToString());
           */
             return (DeptID + " " + CourseNum + " " + CourseName + 
                " " + Credits.ToString() + " Credits");

        }
    }
   
}
