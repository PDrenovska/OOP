using System;
using System.Collections.Generic;
using System.Linq;

namespace FindStudents
{
    class FindStudents
    {
        static void Main()
        {
            var students = new List<Student>
            { 
              new Student { FirstName="Ivan", LastName="Ivanov" }, 
              new Student { FirstName="Petar", LastName="Aleksandrov" },
              new Student { FirstName="Simona", LastName="Tomova" },
              new Student { FirstName="Alex", LastName="Petrov" }
            };

            // The method FindAll() everytime calls the delegate with one parameter-current student;
            var alphabetStudents =
                students.FindAll(delegate(Student student)
                {
                    // If the returned value is true, the student will be added to the list alphabetStudents;
                    return student.FirstName.CompareTo(student.LastName) < 0;
                });

            // This is a short form of the above using lambda expression;
            var alphabeticallyStudents =
                students.FindAll(student => student.FirstName.CompareTo(student.LastName) < 0);

            // Filtering students using LINQ query operators;
            var alphaStudents =
                // The first step is to specify the data source;
                // The range variable 'student' is like the iteration variable in a foreach loop;
                from student in students
                // The filter causes the query to return only those elements for which the expression is true; 
                // The result is produced by using the 'where' clause;
                // In this way we specify which elements to exclude from the source sequence; 
                // In this example, only those students whose first name is before its last name are returned;
                where student.FirstName.CompareTo(student.LastName) < 0
                // The select clause produces the results of the query and specifies the "shape" or type of each returned element;
                select student;

            // All foreach loops print same data;
            foreach (var student in alphabeticallyStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();
            foreach (var student in alphabetStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();
            foreach (var student in alphaStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
