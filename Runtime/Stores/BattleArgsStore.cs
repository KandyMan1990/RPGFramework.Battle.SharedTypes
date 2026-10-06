namespace RPGFramework.Battle.SharedTypes.Stores
{
    public interface IBattleArgsStore
    {
        BattleArgs Args { get; }
        void       Set(BattleArgs args);
    }

    public sealed class BattleArgsStore : IBattleArgsStore
    {
        private BattleArgs m_Args;

        BattleArgs IBattleArgsStore.Args => m_Args;

        void IBattleArgsStore.Set(BattleArgs args) => m_Args = args;
    }
}