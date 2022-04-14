using Classwork.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
    public class Group
    {
        private static int _no=200;
        public string No { get; set; }

        public Group()
        {
            _no++;
            No = $"BP{_no}";
            _students = new Student[0];
        }

        public int StudentLimit { get; set; }

         private Student[] _students;


        public void AddStudent(Student student)
        {
            if (_students.Length<StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                throw new CapacityLimitException("Limiti ashdiz");
            }
        }
    }
}
