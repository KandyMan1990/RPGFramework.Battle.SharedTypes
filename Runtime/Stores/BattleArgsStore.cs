namespace RPGFramework.Battle.SharedTypes.Stores
{
    public interface IBattleArgsStore
    {
        BattleArgs Args { get; }
        void       Set(BattleArgs args);
    }
}