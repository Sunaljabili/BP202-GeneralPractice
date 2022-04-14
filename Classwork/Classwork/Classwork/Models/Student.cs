using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
   public  class Student
    {
        public Student(string name,string surname,int point)
        {
            Name = name;
            Surname = surname;
            Point = point;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        private int _age;
        public int Age {
            get
            {
                return _age;
            }

            set {
                if (value>0)
                {
                    _age = value;
                }
            }
        }

        private int _point;

        public int Point {
            get
            {
                return _point;
            }
            set {
                if (value>0 && value<100)
                {
                    _point = value;
                }    
            }
        }
    }
}
