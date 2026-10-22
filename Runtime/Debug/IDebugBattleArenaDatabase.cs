#if ENABLE_RPG_FRAMEWORK_DEBUG
using System.Collections.Generic;

namespace RPGFramework.Battle.SharedTypes
{
    /// <summary>Every arena the game's battles can be fought in, for the debug room to start a battle in.</summary>
    public interface IDebugBattleArenaDatabase
    {
        /// <summary>Every arena's name, at the number <see cref="BattleArgs.Arena" /> gives it.</summary>
        IReadOnlyList<string> ArenaNames { get; }
    }
}
#endif
