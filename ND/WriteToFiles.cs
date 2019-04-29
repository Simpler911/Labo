using System.Collections.Generic;

namespace ND
{
    class WriteToFiles
    {
        public List<Student> Lazy;
        public List<Student> Smart;
        public WriteToFiles(List<Student> Lazy, List<Student> Smart)
        {
            this.Lazy = Lazy;
            this.Smart = Smart;
        }
        public void write(int index)
        {
            var SmartLines = new List<string>();
            var LazyLines = new List<string>();
            string line;
            foreach(var stud in Lazy)
            {
                line = stud.FName + " " + stud.LName;
                LazyLines.Add(line);
            }
            foreach(var stud in Smart)
            {
                line = stud.FName + " " + stud.LName;
                SmartLines.Add(line);
            }
            System.IO.File.WriteAllLines("Smart" + index + ".txt", SmartLines.ToArray());
            System.IO.File.WriteAllLines("Lazy" + index + ".txt", LazyLines.ToArray());
        }
    }
}
