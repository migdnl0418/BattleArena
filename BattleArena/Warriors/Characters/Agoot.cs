using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class Agoot : Warrior, IHealCaster
    {
        public int HealingAmount { get; set; }
        public Agoot(int health, int attackPower, WarriorType warriorType, TeamType teamType, int healingAmount)
            : base("Agoot", health, attackPower, WarriorType.Magery, teamType)
        {
            HealingAmount = healingAmount;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Haplos", HasCriticalChance, this);
            Console.WriteLine($"\t->{Name}: Tatagos kaba {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Agay Agay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} asa ka boi {target.Name}");
        }

        public void HealTeamMates(List<Warrior> teamMates)
        {
            foreach (var warrior in teamMates)
            {
                warrior.ReceiveHeal(HealingAmount, this);
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"->{Name}: Sayang, patay na si {warrior.Name}!");
                    warrior.ReceiveHeal(HealingAmount, this);
                }
                else
                    Console.WriteLine($"->{Name}:Sayang, patay na si {warrior.Name}." +
                        $"Hindi ko na sya mahaplos");
            }
        }

    }
}
