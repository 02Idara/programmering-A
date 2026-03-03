using System;
using System.Collections.Generic;
using System.Threading;

namespace upp_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Idas Glass fönster :)";                                 // Namn på fliken 

            List<string> glassar = new List<string>();

            int saldo = 100;
            int val = 0;

            Console.WriteLine(" Välj en glass att köpa ");
            Thread.Sleep(1000);

            Console.WriteLine(" Du har " + saldo + " kr på kontot");
            Thread.Sleep(1000);

            Console.WriteLine(" Det som finns att välja mellan är... ");
            Thread.Sleep(2000);

            Console.WriteLine(" Piggelin 10kr " + " tryck 1 ");
            Thread.Sleep(1000);
            Console.WriteLine(" Magnum 20kr " + " tryck 2 ");
            Thread.Sleep(1000);
            Console.WriteLine(" Daimstrut 30kr " + " tryck 3 ");
            Thread.Sleep(1000);

            string val1 = Console.ReadLine();

            if (int.TryParse(val1, out val))
            {
                if (val == 1)
                {
                    glassar.Add("Piggelin");
                    saldo = saldo - 10;
                }
                else if (val == 2)
                {
                    glassar.Add("Magnum");
                    saldo = saldo - 20;
                }
                else if (val == 3)
                {
                    glassar.Add("Daimstrut");
                    saldo = saldo - 30;
                }

            }
            
            while (saldo > 0)
            {
                Console.Clear();
                Console.WriteLine("Du har köpt: ");
                foreach (var glass in glassar)
                {
                    Console.WriteLine("- " + glass);
                }
                Thread.Sleep(1000);
                Console.WriteLine(" Vill du köp en till glass? Du har " + saldo + " kr kvar att handla för.");
                Thread.Sleep(1000);
                Console.WriteLine("   ");
                Console.WriteLine(" Piggelin 10kr tryck 1    Magnum 20kr tryck 2    Daimstrut 30 kr tryck 3 ");

                string val2 = Console.ReadLine();

                if (int.TryParse(val2, out val) && saldo > 0)
                {
                    if (val != 1 && val != 2 && val != 3)
                    {
                        Console.WriteLine(" Oops!!!! du har valt nått som inte finns att välja mellan. ");
                        Console.WriteLine("   ");                        
                    }
                    else if (val == 1 && saldo >= 10)
                    {
                        glassar.Add("Piggelin");
                        saldo -= 10;
                    }
                    else if (val == 2 && saldo >= 20)
                    {
                        saldo -= 20;
                        glassar.Add("Magnum");
                    }
                    else if (val == 3 && saldo >= 30)
                    {
                        glassar.Add("Daimstrut");
                        saldo -= 30;
                    }                                        
                    else
                    {
                        Console.WriteLine(" Oops!!!! Du har inte råd. ");
                        Console.WriteLine("   ");
                        Console.ReadKey();
                    }
                }
            }            
        }
    }
}
