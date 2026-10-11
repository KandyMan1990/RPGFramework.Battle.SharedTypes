namespace RPGFramework.Battle.SharedTypes.Stores
{
    /// <summary>
    /// How the last battle ended, written by the battle for the module it returns to and the router to read.
    /// </summary>
    public interface IBattleCompleteStateStore
    {
        /// <summary>How the last battle ended, or that it is still going.</summary>
        BattleCompleteState State { get; }

        /// <summary>Records how the battle ended.</summary>
        void Set(BattleCompleteState state);
    }
}