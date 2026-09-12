using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Raymond : Warrior
    {
        public int BengDamage { get; set; }

        public Raymond(int health, int attackPower)
            : base("Raymond", health, attackPower, WarriorType.Marksman)
        {
            attackPower += BengDamage;
        }


        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "beng", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: Yare ka sakin {target.Name}");
            
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");
            Thread.Sleep(1000);

            
            
        }
    }
}