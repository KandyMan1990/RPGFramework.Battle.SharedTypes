# RPGFramework.Battle.SharedTypes

What other modules need to start a battle and learn how it ended, without depending on the Battle package itself.

Requires Unity 6000.6 or newer and RPGFramework.Core.SharedTypes.

- **`IBattleModule`**: the battle module, as Core resolves it.
- **`BattleConstants.MODULE_ID`**: its module id, 2.
- **`BattleOutcomes.FINISHED`**: what the battle reports as it ends, for the game's module router to route.
- **`BattleArgs`**: the battle to fight: an arena, an enemy group and an enemy level, as numbers your game defines, and
  its **`BattleFlags`**.
- **`BattleFlags`** change how a battle runs, combined as a mask: no escape, no victory fanfare (the battle's music
  plays on), the field's countdown carried in, no items or experience won, the music playing kept as the battle music,
  and a forced first strike for either side or neither. Two more, `DISABLE_GAME_OVER_ON_DEFEAT` and
  `DISABLE_GAME_OVER_ON_TIME_OUT`, belong to the battle mode alone.
- **`IBattleArgsStore`**: where `BattleArgs` are kept. Whatever starts a battle, such as a field script, sets it, and the
  battle module reads it as it enters. Your global installer binds it to the Battle package's `BattleArgsStore`.
- **`IBattleModeStore`**: the battle mode, a saved `BattleFlags` mask a script sets: the flags random battles will be
  fought with, and whether losing a battle or a countdown running out ends the game, which the game's module router
  reads after every battle. Your global installer binds it to the Battle package's `BattleModeStore`, which keeps
  it in the variable map's `BattleMode`.
- **`BattleCompleteState`** and **`IBattleCompleteStateStore`**: how the last battle ended (still going, defeat, escape,
  out of time or victory), for the router and the module the player returns to. Your global installer binds it to the
  Battle package's `BattleCompleteStateStore`.

```csharp
battleArgsStore.Set(new BattleArgs(arena: 3, enemyGroup: 12, BattleFlags.DISABLE_ESCAPE, enemyLevel: 5));
```

## Not in this version

- **`BattleArgs.SetFlag` changes only the copy it is called on**, since `BattleArgs` is a struct: set the flags when you
  make it.
- **The battle module that reads these is a shell**, so the flags and the enemy level aren't acted on yet, and its
  result is a placeholder: won after three seconds, or lost if Cancel is pressed first.
- **Random battles** aren't built, so nothing reads the battle mode's own battle flags yet.
