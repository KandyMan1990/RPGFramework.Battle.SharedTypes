using System.Runtime.InteropServices;

namespace RPGFramework.Battle.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BattleArgs
    {
        public int         Arena      { get; }
        public int         EnemyGroup { get; }
        public BattleFlags Flags      { get; private set; }
        public byte        EnemyLevel { get; }

        public bool HasFlag(BattleFlags flag) => (Flags & flag) == flag;
        public void SetFlag(BattleFlags flag) => Flags |= flag;

        public BattleArgs(int arena, int enemyGroup, BattleFlags flags, byte enemyLevel)
        {
            Arena      = arena;
            EnemyGroup = enemyGroup;
            Flags      = flags;
            EnemyLevel = enemyLevel;
        }

        public BattleArgs(int arena, int enemyGroup, byte enemyLevel) : this(arena, enemyGroup, BattleFlags.DEFAULT, enemyLevel)
        {
        }
    }
}