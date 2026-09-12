using BattleArena.Enums;
using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Abilities
{
    internal interface IHealable
    {
        TeamType TeamType { get; }
        void ReceiveHeal(int amount, Warrior healer);
    }
}
