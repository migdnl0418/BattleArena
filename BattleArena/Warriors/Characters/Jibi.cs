using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
   
    public class Jibi : Warrior
    {
        public int PunchDamage { get; private set; }
        public Jibi(int health, int attackPower, int punchDamage)
            : base("Jibi", health, attackPower, WarriorType.Fighter)
        {
            PunchDamage = punchDamage;
            attackPower += punchDamage;
        }

        public Jibi(string name, int health, int attackPower)
            : base(name, health, attackPower, WarriorType.Fighter)
        {
            PunchDamage = PunchDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sapak", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: Tutuhugin kita {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

    }
}
