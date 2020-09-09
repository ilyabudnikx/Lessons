using System;
namespace ModifyString
{
    class Program
    {
public static void Main(string[] args)
        {
            //Создали объект класса Student
            Student s1 = new Student();
            Console.ReadLine(s1.Name);

            //Создали новый объект с тем же именем
            Student s2 = new Student();
            s2.Name = s1.Name;

            //Шарпы измениили s2, но не троли главный объект - S1
            s2.Name = s1.Name.ToUpper();
            Console.WriteLine(s2.Name);

        }
    }
    class Student
    {
        public String Name;
    }
}