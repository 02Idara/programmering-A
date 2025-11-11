using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upp_4_ida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2025;
            int age = 0;
            int born;

            Console.WriteLine("Hejsan");
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Vilket år är du född?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out born))
                {
                    age = year - born;
                    {
                        if (age >= 0)
                        {
                            if(age <= 12)
                            {
                                Console.WriteLine(namn + " är " + age +  " eller " + " år gammal och blir barn");
                            }
                            else if (age < 25)
                            {
                                Console.WriteLine(namn + " är " + age + " år gammal och blir ungdom");
                            }
                            else if (age < 70)
                            {
                                Console.WriteLine(namn + " är " + age + " år gammal och blir medelålders");
                            }
                            else if (age < 120)
                            {
                                Console.WriteLine(namn + " är " + age + " år gammal och blir gammal.");
                            }
                            else
                            {
                                Console.WriteLine(namn + " är " + age + " år gammal och troligtvis lever inte.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(" OJ, du är inte född ännu. ");
                        }
                    }
                    

                    break;
                }
                else
                {
                    Console.WriteLine("Fel: du måste skriva ett heltal. försök igen.");
                    Console.Beep(1000, 2000);
                }

            }

        }
    }
}
