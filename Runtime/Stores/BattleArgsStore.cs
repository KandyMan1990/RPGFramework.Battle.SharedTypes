namespace RPGFramework.Battle.SharedTypes.Stores
{
    /// <summary>
    /// The battle to fight next: set by whatever starts it, such as a field script, read as the battle enters.
    /// </summary>
    public interface IBattleArgsStore
    {
        /// <summary>The next battle's encounter, arena, flags and cover.</summary>
        BattleArgs Args { get; }

        /// <summary>Sets the battle to fight next.</summary>
        void Set(BattleArgs args);
    }
}