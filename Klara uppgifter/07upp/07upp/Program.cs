using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07upp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string playername = "";
            int playerHP = 100;
            string weaponType = "";
            string weaponChoice;
            
            int pMax = 0;
            int pMin = 0;

            int enemyHP = 100;
            int eMaxDamage = 10;
            int eMinDamage = 5;
            int enemyDamage;

            Console.WriteLine("Välkommen! Spelet går till såhär: Du möter en enemy med samma HP som dig (100)\nSedan kommer du få välja ett vapen med olika max & min damage som också kommer att slumpas\nvilken damage du kommer göra.");   
            Console.WriteLine(" ");
            Thread.Sleep(2000);
            Console.WriteLine("Skriv in ditt namn");
            playername = Console.ReadLine();
            Console.WriteLine("Hej" + playername + "Nu kan spelet börja.");

            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine("Din HP är " + playerHP);
                Console.WriteLine("Enemys HP är " + enemyHP);

                while (weaponType == "")
                {
                    Console.WriteLine("Välj ett utav vapenen");
                    Console.WriteLine("sword = Maxdamage=12 Mindamage=10  tryck 1\n axe = Maxdamage=14 Mindamage=8  tryck 2\nhammer = Maxdamage=16 Mindamage=4  tryck 3");
                    weaponChoice = Console.ReadKey().KeyChar.ToString();
                    switch (weaponChoice)
                    {
                        case "1":
                            pMax = 12;
                            pMin = 10;
                            break;
                        case "2":
                            pMax = 14;
                            pMin = 8;
                            break;
                        case "3":
                            pMax = 16;
                            pMin = 4;
                            break;
                            
                    }
                }
                int playerdamage = rnd.Next(pMax, pMin);

                

            }
        }
    }
}
