namespace RPGFramework.Battle.SharedTypes.Providers
{
    public interface IBattleArgsProvider
    {
        BattleArgs Get { get; }
        void       Set(BattleArgs args);
    }

    public sealed class BattleArgsProvider : IBattleArgsProvider
    {
        private BattleArgs m_Args;

        BattleArgs IBattleArgsProvider.Get => m_Args;

        void IBattleArgsProvider.Set(BattleArgs args) => m_Args = args;
    }
}