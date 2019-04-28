using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND
{
    class Program
    {
        static void Main(string[] args)
        {
            var ReadData = new Read();
            ReadData.read();
            var DisplayData = new Display(ReadData.Stud);
            DisplayData.display();
        }
    }
}