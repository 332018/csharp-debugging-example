using System;

namespace Domaci_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            Department d = new Department();


            s1.Name = "Darko";
            s2.Name = "Marko";
            s3.Name = "Janko";

            s1.IdNumber = "5 / 2018";
            s2.IdNumber = "24 / 2016";
            s3.IdNumber = "68 / 2017";

            s1.Department.Code = "IT";

            Console.WriteLine("Prvi student:\nIme: " + s1.Name + "\nBroj indeksa: " + s1.IdNumber + "\nSmer: ");
        }
    }
}
