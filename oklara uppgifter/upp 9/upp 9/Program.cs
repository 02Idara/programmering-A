using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upp_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[3];

            Console.WriteLine("Skriv in person 1");
            namn[0] = Console.ReadLine();
            Console.WriteLine("Skriv in person 2");
            namn[1] = Console.ReadLine();
            Console.WriteLine("Skriv in person 3");
            namn[2] = Console.ReadLine();

            Console.WriteLine(" sök person");
            int val = int.Parse(Console.ReadLine());

            if (val == 0 || val == 1 || val == 2 || val == 3)
            {
                if (val == 0)
                {
                    for (int i = 0; i < namn.Length; i++) 
                    {
                        Console.WriteLine("person " + (i+1) + " " + namn[i] );
                    }
                }
                else
                {
                    Console.WriteLine(namn[val-1]);
                }
            }
            else
            {
                Console.WriteLine("Inte korrekt nummer");
            }
        }
    }
}
