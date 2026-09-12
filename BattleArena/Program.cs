using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            var Raymond = new Raymond(100, 30);
            var Kirk = new Kirk(200, 15, 10, Enums.TeamType.A);
            var Jibi = new Jibi(150, 30, 15);

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();
            Jibi.DisplayStatus();
             
            while(Raymond.IsAlive && Kirk.IsAlive && Jibi.IsAlive)
            {
                Console.WriteLine("\n\n==========================================");
                Raymond.Attack(Kirk);
                Kirk.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Jibi.Attack(Raymond);
                Jibi.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    } 
}
