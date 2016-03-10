namespace PathFinderServer.Interfaces
{
    internal interface ISkill
    {
        bool TrainedOnly { get; }

        Abilities.Abilities AbilityBase { get; }

        int AbilityMod { get; }

        int Ranks { get; set; }

        int MiscMod { get; set; }

        int TotalBonus();
    }
}