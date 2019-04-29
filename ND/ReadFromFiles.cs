using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ND
{
    class ReadFromFiles
    {
        List<Student> Stud = new List<Student>();
        //LinkedList<Student> Stud = new LinkedList<Student>();
        //Queue<Student> Stud = new Queue<Student>();
        public void read()
        {
            try
            {
                for(int tt = 1; tt < 6; tt++)
                {
                    string[] lines = System.IO.File.ReadAllLines(@"Data"+tt+".txt");
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
                        Stud.Add(Student);
                        //Stud.AddFirst(Student);
                        //Stud.Enqueue(Student);
                    }
                    DateTime dt = DateTime.Now;
                    var lazyStudents = Stud.Where(x => x.IsLazy).ToList();
                    var smartStudents = Stud.Where(x => x.IsSmart).ToList();
                    lazyStudents = lazyStudents.OrderBy(x => x.FName).ThenBy(t => t.LName).ToList();
                    smartStudents = smartStudents.OrderBy(x => x.FName).ThenBy(t => t.LName).ToList();
                    var write = new WriteToFiles(lazyStudents, smartStudents);
                    write.write(tt);
                    TimeSpan ts = DateTime.Now - dt;
                    Console.WriteLine(tt + ": " + ts);
                    Stud.Clear();
                }
            }
            catch (FileNotFoundException ex) { Console.WriteLine(ex); }
        }
    }
}
