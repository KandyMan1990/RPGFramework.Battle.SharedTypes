using System.Runtime.InteropServices;

namespace RPGFramework.Battle.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BattleArgs
    {
        /// <summary>The encounter fought, by the hash of its name: its enemy group, its own flags and its levels.</summary>
        public ulong Encounter { get; }

        /// <summary>Where it is fought, by the hash of the arena's name.</summary>
        public ulong Arena { get; }

        /// <summary>The flags of the call that starts it, joined to the encounter's own.</summary>
        public BattleFlags Flags { get; private set; }

        /// <summary>
        /// The transition that covers the screen as the battle starts, by its name's hash, or <c>0</c> for the router's;
        /// how a battle gets the reference's boss transition.
        /// </summary>
        public ulong Transition { get; }

        public bool HasFlag(BattleFlags flag) => (Flags & flag) == flag;
        public void SetFlag(BattleFlags flag) => Flags |= flag;

        public BattleArgs(ulong encounter, ulong arena, BattleFlags flags, ulong transition)
        {
            Encounter  = encounter;
            Arena      = arena;
            Flags      = flags;
            Transition = transition;
        }
    }
}
