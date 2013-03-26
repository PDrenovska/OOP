using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareAcademy;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;
        public string Town
        {
            get { return this.town; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException(Town, "The town cannot be null!");
                else
                {
                    this.town = value;
                }
            }
        }

         public OffsiteCourse(string name, ITeacher teacher, string town)
             :base(name, teacher) // calling the parent's constructor
         {
             this.Town = town;
         }
    }