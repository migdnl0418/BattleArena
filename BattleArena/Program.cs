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
            var Raymond = new Marksman("Raymond", 100, 30);
            var Kirk = new Fighter("Kirk", 200, 15);
            var Jibi = new Tank("Jibi", 150, 30, 20);

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();
            Jibi.DisplayStatus();
             
            while(Raymond.IsAlive && Kirk.IsAlive && Jibi.IsAlive)
            {
                
                Raymond.Attack(Kirk);
                Console.WriteLine("----------------------------------------------");
                Jibi.Attack(Raymond);
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    } 
}
