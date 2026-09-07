using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Tank : Warrior
    {
        public int Shield { get; set; }
        public Tank(string name, int health, int attackPower, int shield)
            : base(name, health, attackPower)
        {
            Shield = shield;
            attackPower += shield;
        }
        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + Shield;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t->{Name}: Tatagos kaba {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->-------{target.Name}-------");
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");
            Console.WriteLine($"\t---------------------------");
        }
    }
}
