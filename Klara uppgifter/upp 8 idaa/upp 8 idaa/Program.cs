using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upp_8_idaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int spelarenval = 0;
            int pengar = 100;
            string namn = "";
            int satsning = 0;

            int motpengar = 100;
            int motval = 0;


            Console.WriteLine("Välkommen!! Spelet är sten,sax,påse och du ska satsa pengar för att kunna vinna över datorn\n100kr var och det går bara satsa jämt");
            Console.WriteLine("Skriv in ditt namn");
            namn = Console.ReadLine();
            Console.WriteLine("Lycka till " + namn);

            while (pengar > 0 && motpengar > 0)
            {
                Console.WriteLine("hur mycket pengar vill du satsa? (bara heltal)");
                satsning = int.Parse(Console.ReadLine());
                Console.WriteLine("Datorn satsar alltid samma");
                Console.WriteLine(" ");



                while (spelarenval == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Välj utav\nSten = tryck 1\nSax = tryck 2\nPåse = tryck 3");
                    spelarenval = int.Parse(Console.ReadKey().KeyChar.ToString());
                    motval = rnd.Next(1, 4);
                                     
                    if (spelarenval == motval)
                    {
                        Console.WriteLine("\nBåda valde samma. inget händer");
                    }
                    else if (spelarenval == 1)
                    {
                     if (motval == 2)
                        {
                            Console.WriteLine("\nDu valde sten och datorn valde sax");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Du vann!!");
                            pengar += satsning;
                            Console.ResetColor();
                            motpengar -= satsning;
                        }
                     if (motval == 3)
                        {
                            Console.WriteLine("\nDu valde sten och datorn valde påse");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Du förlorade!!");
                            Console.ResetColor();
                            pengar -= satsning;
                            motpengar += satsning;
                        }

                    }
                    else if (spelarenval == 2)
                    {
                      if (motval == 1)
                        {
                            Console.WriteLine("\nDu valde sax och datorn valde sten");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Du förlorade!!");
                            Console.ResetColor();
                            pengar -= satsning;
                            motpengar += satsning;
                        } 
                      if (motval == 3)
                        {
                            Console.WriteLine("\nDu valde sax och datorn valde påse");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Du vann!!");
                            Console.ResetColor();
                            pengar += satsning;
                            motpengar -= satsning;
                        }
                    }
                    else if (spelarenval == 3)
                    {
                      if (motval == 1)
                        {
                            Console.WriteLine("\nDu valde påse och datorn valde sten");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Du vann!!");
                            Console.ResetColor();
                            pengar += satsning;
                            motpengar -= satsning;
                        }
                      if (motval == 2)
                        {
                            Console.WriteLine("\nDu valde påse och datorn valde sax");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Du förlorade!!");
                            Console.ResetColor();
                            pengar -= satsning;
                            motpengar += satsning;
                        }
                    }
                   
                    
                   
                }

                Console.WriteLine(" ");
                Console.WriteLine("Du har " + pengar + "kr\nDatorn har " + motpengar + "kr");
                spelarenval = 0;

            } 
            if (pengar > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Grattis du har vunnit!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du förlorade mot datorn!!!");
                Console.ResetColor();
            }
           
        }
    }
}
