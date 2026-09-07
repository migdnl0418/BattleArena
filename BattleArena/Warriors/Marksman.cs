using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Marksman : Warrior
    {
        public int ArrowDamage { get; set; }

        public Marksman(string name, int health, int attackPower)
            : base(name, health, attackPower)
        {
            attackPower += ArrowDamage;
        }


        public override void Attack(Warrior target)
        {
            TakeDamage(target.AttackPower + ArrowDamage);
            Console.WriteLine($"\t->{Name}: Yare ka sakin {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->-------{target.Name}-------");
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");
        }
    }
}