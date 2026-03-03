using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopar_dok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hemligt = "s3cr3t1";
            string[] hemligaArrayer = { "s", "3", "c", "r", "3", "t", "1" };
            string gissning = "";
            string output = "";
            string baba = "";
            string mod = "f1";
            string bob = Console.ReadLine();
            if (bob == mod)
            {
                hemligt = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Gissa ett lösenord en bokstav i taget!");
            foreach (char c in hemligt)
            {
                gissning = Console.ReadLine();
                string d = "";
                d = c.ToString();
                int rättaGissningar = 0;
                while (true)
                {
                    if (d == gissning)
                    {
                        if (rättaGissningar < hemligt.Length)
                        {
                            rättaGissningar++;
                            output += d;
                            for (int i = output.Length; i < hemligt.Length; i++)
                            {
                                baba += "_";
                            }
                            Console.WriteLine("Rätt svar");
                            Console.WriteLine($"Dina rätt hittills är {output}{baba}");
                            baba = "";

                        }                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fel gissning! \nGissa om och gärna gissa rätt!");
                        gissning = Console.ReadLine();
                    }
                }
               

            }
            Console.WriteLine($"Du har gissat hela ordet! Ordet var {hemligt}");

        }
    }
}
