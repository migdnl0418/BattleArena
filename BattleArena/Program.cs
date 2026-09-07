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
            Warrior Raymond = new Warrior("Raymond", 100, 30, "Plasma Slash");
           Warrior Kirk = new Warrior("Kirk", 200, 15, "Kinagat");
            Warrior Jibi = new Warrior("Jibi", 150, 20, "Sinargo");

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();
            Jibi.DisplayStatus();

            int round = 1;
            while(Raymond.IsAlive && Kirk.IsAlive && Jibi.IsAlive)
            {
                Console.WriteLine($"----------Round {round}-----------------");
                Raymond.Attack(Kirk);
                Kirk.Attack(Raymond);
                Jibi.Attack(Kirk);
                Console.WriteLine("---------------------------");
                round++;
            }
        }
    }
}
