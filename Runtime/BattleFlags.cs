using System;

namespace RPGFramework.Battle.SharedTypes
{
    [Flags]
    public enum BattleFlags : ushort
    {
        /// <summary>
        /// Normal battles
        /// </summary>
        DEFAULT = 0,

        /// <summary>
        /// Player cannot escape from battle
        /// </summary>
        DISABLE_ESCAPE = 1 << 0,

        /// <summary>
        /// Suppresses victory music, party members do not celebrate victory
        /// </summary>
        DISABLE_VICTORY = 1 << 1,

        /// <summary>
        /// Suppresses showing any kind of exp/money/items screens
        /// </summary>
        DISABLE_SPOILS = 1 << 2,

        /// <summary>
        /// Battle must be completed before the timer reaches zero
        /// </summary>
        TIMED = 1 << 3,

        /// <summary>
        /// Force the player to take action first
        /// </summary>
        FORCE_PREEMPTIVE_ATTACK = 1 << 4,

        /// <summary>
        /// Force the enemy to take action first
        /// </summary>
        FORCE_BACK_ATTACK = 1 << 5,

        /// <summary>
        /// Prevents both preemptive and back attack chances
        /// </summary>
        DISABLE_PREEMPTIVE_AND_BACK_ATTACK = 1 << 6,

        /// <summary>
        /// Prevents the game from going to the game over screen upon defeat in battle
        /// </summary>
        DISABLE_GAME_OVER = 1 << 7,
    }
}