using System.Runtime.InteropServices;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Battle.SharedTypes
{
    public interface IBattleModuleArgs : IModuleArgs
    {
        ushort Arena      { get; }
        ushort EnemyGroup { get; }
        byte   EnemyLevel { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct BattleModuleArgs : IBattleModuleArgs
    {
        private readonly ushort m_Arena;
        private readonly ushort m_EnemyGroup;
        private readonly byte   m_EnemyLevel;

        ushort IBattleModuleArgs.Arena      => m_Arena;
        ushort IBattleModuleArgs.EnemyGroup => m_EnemyGroup;
        byte IBattleModuleArgs.  EnemyLevel => m_EnemyLevel;

        public BattleModuleArgs(ushort arena, ushort enemyGroup, byte enemyLevel)
        {
            m_Arena      = arena;
            m_EnemyGroup = enemyGroup;
            m_EnemyLevel = enemyLevel;
        }
    }

    public interface IBattleModule : IModule
    {
    }
}