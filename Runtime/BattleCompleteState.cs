namespace RPGFramework.Battle.SharedTypes
{
    public enum BattleCompleteState : byte
    {
        BATTLE_STILL_ACTIVE = 0,
        VICTORY             = 1,
        GAME_OVER           = 2,
        ESCAPE              = 3
    }
}