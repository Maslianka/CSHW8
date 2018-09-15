using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW8P2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> lines = new List<string>();
            using (StreamReader streamReader = new StreamReader("text.txt"))
            {
                string line;
               
                while ((line = streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            foreach(string s in lines)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine((i + 1) + "line has " + lines[i].Length + " characters");
            }
        
            Console.ReadKey();
        }
    }
}
