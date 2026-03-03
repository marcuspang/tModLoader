# 1.4.5 Port Error Inventory

Last updated: 2026-03-04
Source log: \.tmp/build_full.log
Build command: 
`dotnet build solutions/tModLoader.sln --no-restore /nr:false /m:1 -v:minimal`

## Snapshot

- Total C# errors (unique): **103**
- Total C# errors (raw log lines): **206**
- Affected files (ExampleMod): **67**
- Core `Terraria.csproj` status: builds clean; remaining failures are ExampleMod API-drift issues.

## Errors By Code

| Count | Code |
|---:|---|
| 90 | CS0117 |
| 34 | CS1061 |
| 32 | CS1503 |
| 18 | CS0103 |
| 8 | CS7036 |
| 8 | CS0012 |
| 4 | CS1739 |
| 4 | CS0019 |
| 2 | CS0426 |
| 2 | CS0200 |
| 2 | CS0120 |
| 2 | CS0030 |

## Top Files By Error Count

| Count | File |
|---:|---|
| 14 | `Content/NPCs/ExampleZombieThief.cs` |
| 12 | `Content/ExampleRecipes.cs` |
| 8 | `Content/Projectiles/ExampleInteractableProjectile.cs` |
| 6 | `Content/Walls/ExampleVanillaConversionWalls.cs` |
| 6 | `Content/NPCs/MinionBoss/MinionBossBody.cs` |
| 6 | `Content/Items/CustomItemDrawingShowcase.cs` |
| 6 | `Common/Systems/ExampleWorldGenHookingSystem.cs` |
| 6 | `Common/EntitySources/ExampleSourceDependentTweaks.cs` |
| 4 | `Content/Tiles/Furniture/ExampleDresser.cs` |
| 4 | `Content/Tiles/Furniture/ExampleChandelier.cs` |
| 4 | `Content/Tiles/Furniture/ExampleBed.cs` |
| 4 | `Content/Projectiles/ExampleHeldProjectileWeaponProjectile.cs` |
| 4 | `Content/Projectiles/ExampleFlailProjectile.cs` |
| 4 | `Content/Projectiles/ExampleAdvancedFlailProjectile.cs` |
| 4 | `Content/NPCs/PartyZombie.cs` |
| 4 | `Content/Items/Weapons/ExampleHeldProjectileWeapon.cs` |
| 4 | `Content/Items/Placeable/ExampleTorch.cs` |
| 4 | `Content/Buffs/ExampleMinecartBuff.cs` |
| 4 | `Common/Systems/ExampleWorldHeaderSystem.cs` |
| 4 | `Common/ItemDropRules/DropConditions/ExampleJourneyModeDropCondition.cs` |
| 2 | `ExampleMod.Networking.cs` |
| 2 | `Content/Tiles/Furniture/MinionBossRelic.cs` |
| 2 | `Content/Tiles/Furniture/ExampleWorkbench.cs` |
| 2 | `Content/Tiles/Furniture/ExampleToilet.cs` |
| 2 | `Content/Tiles/Furniture/ExampleTable.cs` |
| 2 | `Content/Tiles/Furniture/ExamplePlatform.cs` |
| 2 | `Content/Tiles/Furniture/ExampleDoorOpen.cs` |
| 2 | `Content/Tiles/Furniture/ExampleDoorClosed.cs` |
| 2 | `Content/Tiles/Furniture/ExampleChest.cs` |
| 2 | `Content/Tiles/Furniture/ExampleChair.cs` |

## Working Notes

1. Prioritize high-frequency files first (`ExampleZombieThief.cs`, `ExampleRecipes.cs`, `ExampleInteractableProjectile.cs`).
2. Resolve renamed/moved APIs in batches (IDs/Sets/constants, item/world-item model, hook API changes).
3. Rebuild after each batch and append progress to this file.

## Progress Log

- 2026-03-04: Created initial consolidated inventory from full solution build log.
