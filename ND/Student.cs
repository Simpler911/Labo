using System;
using System.Collections.Generic;

namespace ND
{
    class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public List<string> Grade { get; set; }
        public string Exam { get; set; }
        public double Mean { get; set; }
        public double Median { get; set; }
    }
}