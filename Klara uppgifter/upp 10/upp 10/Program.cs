using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upp_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
                                

            bool x = true;
            int satsning = 0;
            int saldo = 0;
            int p = 0;
            int m = 0;

            Console.WriteLine("Välkomen till enarmad banditen!\nFå tre likadana symboler");
            Console.WriteLine("Först får du sätta in en summa pengar 10-1000 max\nSedan väljer du hur mycket du vill satsa");

            while (true)
            {
                Console.WriteLine("Hur mycket vill du sätta in? 10-1000 max");
                int saldo2 = int.Parse(Console.ReadLine());
                if (saldo2 <= 1000 && saldo2 >= 10)
                {
                    saldo = saldo2;
                    break;
                }
                else
                {
                    Console.WriteLine("Du har lagt in för mycket eller lite");
                }
            }

    

            while (saldo > 0 && satsning <= saldo && x)
            {
                char[] slots = new char[3];

                while (true)
                {
                    Console.WriteLine("Hur mycket vill du satsa?");
                    int sats2 = int.Parse(Console.ReadLine());
                    if (sats2 > 0 && sats2 <= saldo)
                    {
                        satsning = sats2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Du har satsat för mycket eller för lite");
                    }
                }

                for (int i = 0; i < slots.Length; i++)
                {
                    int val = rnd.Next(1, 4);
                    if(val == 1)
                    {
                        slots[i] = 'X';
                    }
                    else if(val == 2)
                    {
                        slots[i] = 'Y';
                    }
                    else if(val == 3)
                    {
                        slots[i] = 'Z';
                    }

                }
                foreach (char slot in slots)
                {
                    Console.Write(slot);
                }
                Console.WriteLine();
                if (slots[0] == slots[1] && slots[0] == slots[2])
                {
                    
                    Console.WriteLine("Grattis du har dubblat dina pengar");
                    saldo = saldo + satsning;
                    p = p + satsning;
                   
                }
                else
                {
                    
                    Console.WriteLine("Du förlorade");
                    saldo = saldo - satsning;
                    m = m + satsning;
                }
                Console.WriteLine("nuvarande saldo är " + saldo);
                
                Console.WriteLine("Vill du fortsätta tryck j för ja n för nej");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    x = false;
                    Console.WriteLine("Nuvarande saldo är " + saldo);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du har gått +" + p);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du har gått -" + m);
                    Console.ResetColor();

                }
          
            }
            if(saldo <= 0)
            {
                Console.WriteLine("Du har förlorat alla pengar du lat in");
            }

        }
    }
}
