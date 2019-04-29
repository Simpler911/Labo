using System;
using System.Collections.Generic;

namespace ND
{
    class Student
    {
        Calculations Calc = new Calculations();
        public string FName { get; set; }
        public string LName { get; set; }
        public List<string> Grade { get; set; }
        public string Exam { get; set; }
        public double Mean => Calc.Mean(Grade, Exam);
        public double Median => Calc.Median(Grade, Exam);
        public bool IsLazy => Mean < 5;
        public bool IsSmart => Mean >= 5;
    }
}