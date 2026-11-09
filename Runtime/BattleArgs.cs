using System.Runtime.InteropServices;

namespace RPGFramework.Battle.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BattleArgs
    {
        /// <summary>What is fought, as a number the game defines.</summary>
        public int EnemyGroup { get; }

        /// <summary>Where it is fought, by the hash of the arena's name.</summary>
        public ulong Arena { get; }

        public BattleFlags Flags { get; private set; }

        /// <summary>
        /// The transition that covers the screen as the battle starts, by its name's hash, or <c>0</c> for the router's;
        /// how a battle gets the reference's boss transition.
        /// </summary>
        public ulong Transition { get; }

        public bool HasFlag(BattleFlags flag) => (Flags & flag) == flag;
        public void SetFlag(BattleFlags flag) => Flags |= flag;

        public BattleArgs(int enemyGroup, ulong arena, BattleFlags flags, ulong transition)
        {
            EnemyGroup = enemyGroup;
            Arena      = arena;
            Flags      = flags;
            Transition = transition;
        }
    }
}
