using System;

namespace RPGFramework.Battle.SharedTypes
{
    [Flags]
    public enum BattleFlags : ushort
    {
        /// <summary>
        /// A normal battle
        /// </summary>
        DEFAULT = 0,

        /// <summary>
        /// The party cannot run
        /// </summary>
        DISABLE_ESCAPE = 1 << 0,

        /// <summary>
        /// No victory fanfare: the battle's music plays on after it ends, won or lost
        /// </summary>
        DISABLE_VICTORY_FANFARE = 1 << 1,

        /// <summary>
        /// The field's countdown timer carries on through the battle, which ends if it runs out
        /// </summary>
        INHERIT_COUNTDOWN_TIMER = 1 << 2,

        /// <summary>
        /// No items or experience are won
        /// </summary>
        DISABLE_ITEM_AND_EXP_GAIN = 1 << 3,

        /// <summary>
        /// The music playing as the battle starts plays on as its battle music. A victory fanfare still replaces it,
        /// unless <see cref="DISABLE_VICTORY_FANFARE" /> is set too
        /// </summary>
        USE_CURRENT_MUSIC = 1 << 4,

        /// <summary>
        /// The party acts first
        /// </summary>
        FORCE_PREEMPTIVE_ATTACK = 1 << 5,

        /// <summary>
        /// The enemy acts first
        /// </summary>
        FORCE_BACK_ATTACK = 1 << 6,

        /// <summary>
        /// Neither side can strike first
        /// </summary>
        DISABLE_PREEMPTIVE_AND_BACK_ATTACK = 1 << 7,
    }
}