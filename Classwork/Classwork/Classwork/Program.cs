using Classwork.Models;
using System;
using System.Reflection;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Yusif","Osmanov",90);
            Student student2 = new Student("Zakir", "Eliyev", 85);

            Group group = new Group();
            group.StudentLimit = 3;

            group.AddStudent(student1);
            group.AddStudent(student2);

            Assembly assembly = Assembly.GetExecutingAssembly();
            int sum = 0;
            foreach (var type in assembly.GetTypes())
            {

                if (type == typeof(Group))
                {

                    //Console.WriteLine(type);
                    foreach (var item in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                    {

                        if (item.Name == "_students")
                        {
                            foreach (var fld in (Student[])item.GetValue(group))
                            {
                                sum += fld.Point;
                            }
                        }
                    }

                }
            }
            Console.WriteLine(sum );
        }
    }
}
