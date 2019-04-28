using System;
using System.Collections.Generic;

namespace ND
{
    class Display
    {
        public List<Student> Stud;
        public Display(List<Student> Stud)
        {
            this.Stud = Stud;
        }
        public void display()
        {
            foreach (var ppl in Stud)
            {
                Console.Write("Name: " + ppl.FName + " " + ppl.LName + " Grades: ");
                foreach (var g in ppl.Grade)
                {
                    Console.Write(g + " ");
                }
                Console.Write("Exam: " + ppl.Exam);
                Console.Write(" Mean: " + ppl.Mean);
                Console.Write(" Median: " + ppl.Median + '\n');
            }
        }
    }
}