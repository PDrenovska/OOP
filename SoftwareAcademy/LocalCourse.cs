using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareAcademy;

    class LocalCourse : Course, ILocalCourse
    {
        private string lab;
        public string Lab
        {
            get { return this.lab; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException(Lab, "The lab cannot be null");
                else
                {
                    this.lab = value;
                }
            }
        }

        public LocalCourse(string name, ITeacher teacher, string lab)
            :base(name, teacher) // calling the constructor of parent class;
        {
            this.Lab = lab;
        }
    }