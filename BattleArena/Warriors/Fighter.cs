using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Fighter : Warrior
    {
        public int SwordDamage { get; private set; }
        public Fighter(string name, int health, int attackPower, int swordDamage)
            : base(name, health, attackPower)
        {
            SwordDamage = swordDamage;
            attackPower += swordDamage;
        }

        public Fighter(string name, int health, int attackPower)
            : base(name, health, attackPower)
        {
            SwordDamage = SwordDamage;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + SwordDamage;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t->{Name}: Tutuhugin kita {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Console.WriteLine($"\t->-----{target.Name}-----");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->-----{target.Name}-----");
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");
            Console.WriteLine($"\t---------------------------");

        }

    }
}
