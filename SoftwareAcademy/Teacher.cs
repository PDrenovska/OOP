using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareAcademy;

    class Teacher : ITeacher
    {
        private string name;
        public IList<ICourse> Courses = new List<ICourse>();
        public string Name
        {
            get { return this.name; } 
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentNullException(Name, "The name cannot be null!");
                else
                {
                    this.name = value;
                }
            }
        }

        public void AddCourse(ICourse course)
        {
           this.Courses.Add(course);
        }

        public Teacher(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            StringBuilder teacherInfo = new StringBuilder();
            teacherInfo.Append(this.GetType().Name + ": ");
            teacherInfo.Append("Name=" + this.Name);
            if (this.Courses.Count > 0)
            {
                teacherInfo.Append("; Courses=[");
                foreach (var course in Courses)
                {
                    teacherInfo.Append(course.Name + ", ");
                }
                teacherInfo.Length--;
                teacherInfo.Length--;
                teacherInfo.Append("]");
            }
            return teacherInfo.ToString();
        }
    }