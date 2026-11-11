#if ENABLE_RPG_FRAMEWORK_DEBUG
using System.Collections.Generic;

namespace RPGFramework.Battle.SharedTypes
{
    /// <summary>Every encounter the game's battles can start, for the debug room to start one.</summary>
    public interface IDebugBattleEncounterDatabase
    {
        /// <summary>Every encounter's name, whose hash is what <see cref="BattleArgs.Encounter" /> holds.</summary>
        IReadOnlyList<string> EncounterNames { get; }
    }
}
#endif
