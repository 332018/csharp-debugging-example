using System;
using System.Collections.Generic;

namespace Domaci_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Student > Studenti = new List<Student>();

            string Code_s1 = "IT";
            string Code_s2 = "ri";
            string Code_s3 = "ti";

            Department smer1 = new Department(Code_s1);
            Department smer2 = new Department(Code_s2);
            Department smer3 = new Department(Code_s3);

            Student s1 = new Student("Ivan", "21/2018", smer1);
            Student s2 = new Student("Jovan", "22/2018", smer2);
            Student s3 = new Student("Dragan", "23/2018", smer3);

            Studenti.Add(s1);
            Studenti.Add(s2);
            Studenti.Add(s3);

            foreach(Student studenti in Studenti)
            {
        Console.WriteLine("{0} {1} {2}", studenti.Name, studenti.IdNumber, studenti.Department);
            }
            
        }
    }
}
