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
            var Gen = new Generate();
            Gen.generate();
            var Read = new ReadFromFiles();
            Read.read();
            //var ReadData = new ReadFromFile();
            //ReadData.read();
            //var ReadData = new Read();
            //ReadData.read();
            //var DisplayData = new Display(ReadData.Stud);
            //DisplayData.display();
            /*
             CPU: i7-9700K
             Generate:
                1: 00:00:00.0070056
                2: 00:00:00.0029930
                3: 00:00:00.0029934
                4: 00:00:00.0149843
                5: 00:00:00.1166913
            Sort and Write:
                1: 00:00:00.0049869
                2: 00:00:00.0039893
                3: 00:00:00.0080054
                4: 00:00:00.0398646
                5: 00:00:00.4707135
           */
        }
    }
}
