using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace BattleArena.Warriors
{
    public class Kirk : Warrior
    {
        public int Shield { get; set; }
        public Kirk(int health, int attackPower, int shield)
            : base("Kirk", health, attackPower, WarriorType.Tank)
        {
            Shield = shield;
            attackPower += shield;
        }
        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "bogsh", HasCriticalChance);
            Console.WriteLine($"\t->{Name}: Tatagos kaba {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;
            var newDmgInfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical);
            base.TakeDamage(newDmgInfo);
        }
    }


}
