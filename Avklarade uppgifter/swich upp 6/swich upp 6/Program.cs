using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace swich_upp_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;
            string val;
            string glassar = "";
            bool köpt = false;            
             
            while (saldo >= 0)
            {
                if (saldo == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Du har inga pengar kvar\nDina glassar du köpt är:\n{glassar}\nHejdå! Din råtta :]");
                    break;
                }
                Console.WriteLine($"\nHej vill du köpa en glass? ditt saldo är {saldo}Kr");
                Thread.Sleep(1000);
                if (köpt)
                {
                    Console.WriteLine($"Dina glassar du har köpt är:\n{glassar}\n");
                }
                Console.WriteLine("Det finns piggelin för 10kr, Tryck 1 för att köpa");
                Console.WriteLine("Det finns 88:an för 20kr, Tryck 2 för att köpa");
                Console.WriteLine("Det finns Magnum för 30kr, Tryck 3 för att köpa");
                val = Console.ReadKey().KeyChar.ToString();

                switch (val)
                {
                    case "1":
                        if (saldo < 10)
                        {
                            Console.WriteLine("\nDu har inte råd med den glassen, välj en annan.");
                            break;
                        }
                        saldo -= 10;
                        glassar = glassar + "Piggelin\n";
                        köpt = true;
                        break;
                    case "2":
                        if (saldo < 20)
                        {
                            Console.WriteLine("\nDu har inte råd med den glassen, välj en annan.");
                            break;
                        }
                        saldo -= 20;
                        glassar = glassar + "88:an\n";
                        köpt = true;
                        break;
                    case "3":
                        if (saldo < 30)
                        {
                            Console.WriteLine("\nDu har inte råd med den glassen, välj en annan.");
                            break;
                        }
                        saldo -= 30;
                        glassar = glassar + "Magnum\n";
                        köpt = true;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;



                }
            }
        }
    }
}
