using System;
using System.IO;

namespace helloconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();
            
            if (input.Equals("Cullen", StringComparison.OrdinalIgnoreCase))
            {
                var path = $"{Directory.GetCurrentDirectory()}/io.txt";
                path = Path.GetFullPath(path);

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine($"Hello {input},");
                    sw.WriteLine("Screw you!");
                    sw.WriteLine("This is my file now!");
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        Console.Write((char)sr.Read());
                    }
                }
            }
        }
    }
}
