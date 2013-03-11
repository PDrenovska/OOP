using System;
using System.Collections.Generic;
using System.Linq;
using FindStudentsByAge;

namespace SortingStudents
{
    class SortStudents
    {
        static void Main()
        {
            var students = new List<Student>
            { 
              new Student { FirstName="Ivan", LastName="Ivanov" }, 
              new Student { FirstName="Dragan", LastName="Vasilev" },
              new Student { FirstName="Stoqn", LastName="Stoqnov" },
              new Student { FirstName="Alex", LastName="Petrov" },
              new Student { FirstName="Simona", LastName="Tomova" },
              new Student { FirstName="Alex", LastName="Popov" }
            };

            // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
            // by first name and last name by descending order;

            var orderedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            Console.WriteLine("Sorted students in descending order:");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();
            // Sorting students using LINQ query operators;
            var sortedStudents =
                // The first step is to specify the data source;
                // The range variable 'student' is like the iteration variable in a foreach loop;
                from student in students
                // The orderby clause will cause the elements in the returned sequence to be sorted according to the default comparer for the type being sorted; 
                // The following query sorts the results based on the FirstName and LastName properties;
                // To control the sort order, use the keywords ascending (which is the default) or descending;
                // Because FirstName and LastName are strings, the default comparer performs an alphabetical sort from Z to A;
                orderby student.FirstName descending , student.LastName descending
                // The select clause produces the results of the query and specifies the "shape" or type of each returned element;
                select student;

            Console.WriteLine("Sorted students in descending order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
