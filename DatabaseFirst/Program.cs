using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst {
    class Program {
        static void Main(string[] args) {
            
            PlutoDbContext dbContext = new PlutoDbContext();

            
            var courses = dbContext.GetCourses();

            foreach (var course in courses) {
                Console.WriteLine("Course ID: {1}{0}Course Name: {2}{0}", Environment.NewLine,  course.CourseID, course.Title);
            }
        }
    }
    
}