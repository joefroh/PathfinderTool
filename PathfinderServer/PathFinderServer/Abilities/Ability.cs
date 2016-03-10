using System;

namespace PathFinderServer.Abilities
{
    internal abstract class Ability : IAbility
    {
        public int AbilityModifier
        {
            get { throw new NotImplementedException(); }
        }

        public int AbilityScore
        {
            get { throw new NotImplementedException(); }
        }

        public int TempAdjustment
        {
            get { throw new NotImplementedException(); }
        }

        public int TempModifier
        {
            get { throw new NotImplementedException(); }
        }
    }
}