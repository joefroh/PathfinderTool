using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderServer.Interfaces;

namespace PathFinderServer.Skills
{
    abstract class Skill: ISkill
    {
        public abstract bool TrainedOnly { get; }
        public abstract Abilities.Abilities AbilityBase { get; }
        public abstract int AbilityMod { get; }
        public int Ranks { get; set; }
        public int MiscMod { get; set; }
        public int TotalBonus()
        {
            return AbilityMod + Ranks + MiscMod;
        }
    }
}
