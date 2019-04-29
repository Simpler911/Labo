using System;
using System.Collections.Generic;
using System.IO;

namespace ND
{
    class Generate
    {
        Random r = new Random();
        List<string> data = new List<string>();
        public void generate()
        {
            for(double ind = 1; ind < 6; ind++)
            {
                DateTime dt = DateTime.Now;
                for(int i = 0; i < Math.Pow(10, ind); i++)
                {
                    data.Add("V" + i + " " + "P" + i
                        + " " + r.Next(1, 10) 
                        + " " + r.Next(1, 10)
                        + " " + r.Next(1, 10)
                        + " " + r.Next(1, 10)
                        + " " + r.Next(1, 10));
                }
                System.IO.File.WriteAllLines("Data" + ind + ".txt", data.ToArray());
                TimeSpan ts = DateTime.Now - dt;
                Console.WriteLine(ind + ": " + ts);
                data.Clear();
            }
        }
    }
}
