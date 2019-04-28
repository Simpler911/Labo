using System;
using System.Collections.Generic;

namespace ND
{
    class Read
    {
        public List<Student> Stud = new List<Student>();
        public void read()
        {
            String Vardas;
            String[] split;
            int n;
            Console.WriteLine("Iveskite namu darbu sk: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite studento V ir P: ");
            Vardas = Console.ReadLine();
            while (Vardas != "")
            {
                var Student = new Student();
                Student.Grade = new List<string>();
                split = Vardas.Split(null);
                Student.FName = split[0];
                Student.LName = split[1];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Iveskite namu darbu pazymi nr: " + (i + 1));
                    Student.Grade.Add(Console.ReadLine());
                }
                Console.WriteLine("Iveskite egzamino pazymi: ");
                Student.Exam = Console.ReadLine();
                var Calc = new Calculations();
                Student.Mean = Calc.Mean(Student.Grade);
                Student.Median = Calc.Median(Student.Grade);
                Stud.Add(Student);
                Console.WriteLine("Iveskite studento V ir P: ");
                Vardas = Console.ReadLine();
            }
        }
    }
}