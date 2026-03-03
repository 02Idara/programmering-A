using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upp_6_ida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> glassar = new List<string>();

            int money = 100;
            string glass;



            while (money > 0) 
            {
                Console.WriteLine("Vill du köpa en glass? ");
                Console.WriteLine("Det som finns är Piggelin för 10 Kr, Magnum för 20 Kr och Daimstrut för 30 Kr ");
                Console.WriteLine(" Du har" + money + "Kr kvar ");

                glass = Console.ReadLine();


                switch(glass)
                {
                    case "1":
                        money -= 10;
                        break;

                    
                }  
            }
        }
    }
}
