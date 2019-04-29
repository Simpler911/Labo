using System;
using System.Collections.Generic;
using System.IO;

namespace ND
{
    class ReadFromFile
    {
        public List<Student> Stud = new List<Student>();
        public void read()
        {
            try {
                string[] lines = System.IO.File.ReadAllLines(@"Data.txt");
                string[] split;
                foreach (var line in lines)
                {
                    //Console.WriteLine(line);
                    var Student = new Student();
                    Student.Grade = new List<string>();
                    split = line.Split(null);
                    Student.FName = split[0];
                    Student.LName = split[1];
                    Student.Exam = split[split.Length - 1];
                    for (var i = 2; i < split.Length - 1; i++)
                        Student.Grade.Add(split[i]);
                    var Calc = new Calculations();
                    Student.Mean = Calc.Mean(Student.Grade);
                    Student.Median = Calc.Median(Student.Grade);
                    Stud.Add(Student);
                }
            }
            catch (FileNotFoundException ex) { Console.WriteLine(ex); }
        }
    }
}