namespace RPGFramework.Battle.SharedTypes.Stores
{
    /// <summary>
    /// The battle mode: the flags every random battle is fought with, and whether losing a battle or a countdown running
    /// out ends the game. Kept in the save, set by a script, and read by the router after every battle.
    /// </summary>
    public interface IBattleModeStore
    {
        /// <summary>The battle mode, as a script last set it.</summary>
        BattleFlags Mode { get; }

        /// <summary>Sets the battle mode until it is set again.</summary>
        void SetMode(BattleFlags mode);
    }
}