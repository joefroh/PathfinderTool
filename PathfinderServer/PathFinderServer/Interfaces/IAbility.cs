namespace PathFinderServer.Interfaces
{
    internal interface IAbility
    {
        int AbilityScore { get; set; }

        int AbilityModifier { get; set; }

        int TempAdjustment { get; set; }

        int TempModifier { get; set; }

        Abilities.Abilities Type { get; }
    }
}