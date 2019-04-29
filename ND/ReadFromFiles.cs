using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ND
{
    class ReadFromFiles
    {
        List<Student> Stud = new List<Student>();
        List<Student> Lazy = new List<Student>();
        public void read()
        {
            try
            {
                for (int tt = 1; tt < 6; tt++)
                {
                    string[] lines = System.IO.File.ReadAllLines(@"Data" + tt + ".txt");
                    string[] split;
                    foreach (var line in lines)
                    {
                        var Student = new Student();
                        Student.Grade = new List<string>();
                        split = line.Split(null);
                        Student.FName = split[0];
                        Student.LName = split[1];
                        Student.Exam = split[split.Length - 1];
                        for (var i = 2; i < split.Length - 1; i++)
                            Student.Grade.Add(split[i]);
                        if (Student.Mean >= 5)
                            Stud.Add(Student);
                        else
                            Lazy.Add(Student);
                    }
                    DateTime dt = DateTime.Now;
                    var lazyStudents = Stud.OrderBy(x => x.FName).ThenBy(t => t.LName).ToList();
                    var smartStudents = Lazy.OrderBy(x => x.FName).ThenBy(t => t.LName).ToList();
                    var write = new WriteToFiles(lazyStudents, smartStudents);
                    write.write(tt);

                    TimeSpan ts = DateTime.Now - dt;
                    Console.WriteLine(tt + ": " + ts);
                    Stud.Clear();
                    Lazy.Clear();
                }
            }
            catch (FileNotFoundException ex) { Console.WriteLine(ex); }
        }
    }
}
