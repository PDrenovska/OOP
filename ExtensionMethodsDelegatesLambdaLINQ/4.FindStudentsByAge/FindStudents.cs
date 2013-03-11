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
              new Student { FirstName="Ivan", LastName="Ivanov", Age = 35 }, 
              new Student { FirstName="Dragan", LastName="Vasilev", Age = 60 },
              new Student { FirstName="Stoqn", LastName="Stoqnov", Age = 20 },
              new Student { FirstName="Petar", LastName="Aleksandrov", Age = 23 },
              new Student { FirstName="Simona", LastName="Tomova", Age = 12 },
              new Student { FirstName="Alex", LastName="Petrov", Age = 45 }
            };

            // Filtering students using LINQ query operators;
            var youngerStudents =
                // The first step is to specify the data source;
                // The range variable 'student' is like the iteration variable in a foreach loop;
                from student in students
                // The filter causes the query to return only those elements for which the expression is true; 
                // The result is produced by using the 'where' clause;
                // In this way we specify which elements to exclude from the source sequence; 
                // In this example, only those students whose age is between 18 and 24 are returned;
                where student.Age >= 18 && student.Age <= 24
                // The select clause produces the results of the query and specifies the "shape" or type of each returned element;
                select student;

            Console.WriteLine("Students with age between 18 and 24:");
            foreach (var student in youngerStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
