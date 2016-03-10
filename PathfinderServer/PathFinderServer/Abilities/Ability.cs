using System;
using PathFinderServer.Interfaces;

namespace PathFinderServer.Abilities
{
    internal abstract class Ability : IAbility
    {
        public int AbilityScore { get; set; }
        public int AbilityModifier { get; set; }
        public int TempAdjustment { get; set; }
        public int TempModifier { get; set; }
        public abstract Abilities Type { get; }
    }
}