namespace RPGFramework.Battle.SharedTypes.Constants
{
    /// <summary>What the battle tells Core happened, for the game's module router to route.</summary>
    public static class BattleOutcomes
    {
        /// <summary>The battle is over; how it ended is in the <c>IBattleCompleteStateStore</c>.</summary>
        public const byte FINISHED = 1;
    }
}
