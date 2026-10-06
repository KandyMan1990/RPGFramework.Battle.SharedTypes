namespace RPGFramework.Battle.SharedTypes.Stores
{
    public interface IBattleCompleteStateStore
    {
        BattleCompleteState State { get; }
        void                Set(BattleCompleteState state);
    }
}