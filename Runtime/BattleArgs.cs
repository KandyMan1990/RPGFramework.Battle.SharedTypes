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

        /// <summary>
        /// The transition that covers the screen as the battle starts, by its name's hash, or <c>0</c> for the router's;
        /// how a battle gets the reference's boss transition.
        /// </summary>
        public ulong Transition { get; }

        public bool HasFlag(BattleFlags flag) => (Flags & flag) == flag;
        public void SetFlag(BattleFlags flag) => Flags |= flag;

        public BattleArgs(int arena, int enemyGroup, BattleFlags flags, byte enemyLevel, ulong transition)
        {
            Arena      = arena;
            EnemyGroup = enemyGroup;
            Flags      = flags;
            EnemyLevel = enemyLevel;
            Transition = transition;
        }

        public BattleArgs(int arena, int enemyGroup, byte enemyLevel) : this(arena, enemyGroup, BattleFlags.DEFAULT, enemyLevel, 0)
        {
        }
    }
}