#if UNITY_EDITOR
using System.Collections.Generic;

namespace RPGFramework.Battle.SharedTypes
{
    /// <summary>The encounters a battle can be started with, for another module's editor to offer and check.</summary>
    public interface IBattleEncounterNames
    {
        /// <summary>Every encounter's name, from every encounter database in the project.</summary>
        IReadOnlyList<string> Names { get; }
    }
}
#endif
