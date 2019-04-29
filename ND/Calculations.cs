using System;
using System.Collections.Generic;

namespace ND
{
    class Calculations
    {

        private double med1, med2;
        private double counter = 0;
        private double mean = 0;
        public double Mean(List<string> Grade)
        {
            foreach(var gr in Grade)
            {
                mean += double.Parse(gr);
                counter++;
            }
            return Math.Round(mean / counter, 2);
        }
        public double Median(List<string> Grade)
        {
            Grade.Sort();
            if(Grade.Count % 2 == 0)
            {
                med1 = double.Parse(Grade[Grade.Count / 2]);
                med2 = double.Parse(Grade[((Grade.Count / 2) - 1)]);
                return (med1+med2)/2;
            }
            else
            {
                return double.Parse(Grade[Grade.Count / 2]);
            }
        }
    }
}