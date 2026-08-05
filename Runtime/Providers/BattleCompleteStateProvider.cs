namespace RPGFramework.Battle.SharedTypes.Providers
{
    public interface IBattleCompleteStateProvider
    {
        BattleCompleteState Get { get; }
        void                Set(BattleCompleteState state);
    }

    public sealed class BattleCompleteStateProvider : IBattleCompleteStateProvider
    {
        private BattleCompleteState m_State;

        BattleCompleteState IBattleCompleteStateProvider.Get => m_State;

        void IBattleCompleteStateProvider.Set(BattleCompleteState state)
        {
            m_State = state;
        }
    }
}