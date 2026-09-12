using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace BattleArena.Warriors
{
    public class Kirk : Warrior, IDefender
    {
        public int Shield { get; set; }


        public Kirk(int health, int attackPower, int shield, TeamType teamType)
            : base("Kirk", health, attackPower, WarriorType.Tank, teamType )
        {
            Shield = shield;
            attackPower += shield;
        }
        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "bogsh", HasCriticalChance, this);
            Console.WriteLine($"\t->{Name}: Tatagos kaba {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;

            var blockChance = _random.Next(0, 100);
            var isBlocked = blockChance < 50;
            _damageTaken = damage;

            if (isBlocked) Block();
            else
            {

                var newDmgInfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical, damage.From);
                base.TakeDamage(newDmgInfo);
            }
        }

        public void Block()
        {
            var blockMessage = $"Hahaha! Blocked {_damageTaken.TotalAmountDamage} damage from{_damageTaken.From.Name}!";
        }

       
    }


}
