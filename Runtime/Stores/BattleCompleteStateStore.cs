namespace RPGFramework.Battle.SharedTypes.Stores
{
    public interface IBattleCompleteStateStore
    {
        BattleCompleteState State { get; }
        void                Set(BattleCompleteState state);
    }

    public sealed class BattleCompleteStateStore : IBattleCompleteStateStore
    {
        private BattleCompleteState m_State;

        BattleCompleteState IBattleCompleteStateStore.State => m_State;

        void IBattleCompleteStateStore.Set(BattleCompleteState state)
        {
            m_State = state;
        }
    }
}