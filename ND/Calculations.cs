﻿using System;
using System.Collections.Generic;

namespace ND
{
    class Calculations
    {

        private double med1, med2;
        private double counter = 0;
        private double mean = 0;
        private double vid = 0;
        public double Mean(List<string> Grade, string exam)
        {   
            foreach(var gr in Grade)
            {
                mean += double.Parse(gr);
                counter++;
            }
            try
            {
                vid = (Math.Round(mean / counter, 2) * 0.3) + (double.Parse(exam) * 0.7);
                return vid;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                Console.Write("Dalyba iš nulio negalima.Bandykite dar kartą.");
                return 0;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
                Console.Write("Netinkamas skaičius. Bandykite dar kartą.");
                return 0;
            }
        }
        public double Median(List<string> Grade, string exam)
        {
            Grade.Add(exam.ToString());
            Grade.Sort();
            try
            {
                if (Grade.Count % 2 == 0)
                {
                    med1 = double.Parse(Grade[Grade.Count / 2]);
                    med2 = double.Parse(Grade[((Grade.Count / 2) - 1)]);
                    return (med1 + med2) / 2;
                }
                else
                {
                    return double.Parse(Grade[Grade.Count / 2]);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                Console.Write("Dalyba iš nulio negalima.Bandykite dar kartą.");
                return 0;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
                Console.Write("Netinkamas skaičius. Bandykite dar kartą.");
                return 0;
            }
        }
    }
}