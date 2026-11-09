#if UNITY_EDITOR
using System.Collections.Generic;

namespace RPGFramework.Battle.SharedTypes
{
    /// <summary>The arenas a battle can be fought in, for another module's editor to offer and check.</summary>
    public interface IBattleArenaNames
    {
        /// <summary>Every arena's name, from every arena database in the project.</summary>
        IReadOnlyList<string> Names { get; }
    }
}
#endif
