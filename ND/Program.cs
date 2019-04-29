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
            Sort and Write using List:
                1: 00:00:00.0079784
                2: 00:00:00.0049863
                3: 00:00:00.0079793
                4: 00:00:00.0339095
                5: 00:00:00.3670187
            Sort and Write using LinkedList:
                1: 00:00:00.0049866
                2: 00:00:00.0029875
                3: 00:00:00.0079783
                4: 00:00:00.0329085
                5: 00:00:00.3630080
            Sort and Write using Deque:
                1: 00:00:00.0049869
                2: 00:00:00.0039890
                3: 00:00:00.0089765
                4: 00:00:00.0329398
                5: 00:00:00.3630294
           */
        }
    }
}
