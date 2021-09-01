using System;
using System.IO;

namespace StreamReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileStream f = new FileStream("c:\\Samu.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            f.Close();
        }
    
    }
}
