using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareAcademy;

    public abstract class Course : ICourse
    {
        private string name;
        public string Name { 
            get { return this.name; } 
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(Name, "The name cannot be null!");
                }
                else
                {
                    this.name = value;
                }
            } 
        }
        public IList<string> Topics = new List<string>(); 
        public ITeacher Teacher { get; set; }

        protected Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }

        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder courseInfo = new StringBuilder();
            courseInfo.Append(this.GetType().Name + ": ");
            courseInfo.Append("Name=" + this.Name);

            if (this.Teacher != null)
            {
                courseInfo.Append("; Teacher=" + this.Teacher.Name);
            }

            if (this.Topics.Count > 0)
            {

                courseInfo.Append("; Topics=[");
                foreach (var topic in Topics)
                {
                    courseInfo.Append(topic + ", ");
                }
                courseInfo.Length--;
                courseInfo.Length--;
                courseInfo.Append("]");
            }

            if (this is ILocalCourse)
            {
                var local = this as ILocalCourse;
                if (local != null)
                {
                    if (local.Lab != null)
                    {
                        courseInfo.Append("; Lab=" + local.Lab);
                    }
                        
                }
            }
            else if (this is IOffsiteCourse)
            {
                var offsite = this as IOffsiteCourse;
                if (offsite != null)
                {
                    if (offsite.Town != null)
                        courseInfo.Append("; Town=" + offsite.Town);
                }
            }
            return courseInfo.ToString();
        }
    }