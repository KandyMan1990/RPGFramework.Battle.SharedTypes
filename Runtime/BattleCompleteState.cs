namespace RPGFramework.Battle.SharedTypes
{
    public enum BattleCompleteState : byte
    {
        BATTLE_STILL_ACTIVE = 0,

        /// <summary>
        /// The party was defeated. Whether that ends the game is the battle mode's to say, not the battle's
        /// </summary>
        DEFEAT = 1,

        ESCAPE = 2,

        /// <summary>
        /// The countdown timer the battle inherited ran out. Whether that ends the game is the battle mode's to say
        /// </summary>
        OUT_OF_TIME = 3,

        VICTORY = 4
    }
}