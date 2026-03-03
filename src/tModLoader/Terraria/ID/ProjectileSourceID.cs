#nullable enable

using System;

namespace Terraria.ID;

//TML: Made internal in favor of string contexts on every entity source.
internal static class ProjectileSourceID
{
	public const int None = 0;
	public const int SetBonus_SolarExplosion_WhenTakingDamage = 1;
	public const int SetBonus_SolarExplosion_WhenDashing = 2;
	public const int SetBonus_ForbiddenStorm = 3;
	public const int SetBonus_Titanium = 4;
	public const int SetBonus_Orichalcum = 5;
	public const int SetBonus_Chlorophyte = 6;
	public const int SetBonus_Stardust = 7;
	public const int WeaponEnchantment_Confetti = 8;
	public const int PlayerDeath_TombStone = 9;
	public const int TorchGod = 10;
	public const int FallingStar = 11;
	public const int PlayerHurt_DropFootball = 12;
	public const int StormTigerTierSwap = 13;
	public const int AbigailTierSwap = 14;
	public const int SetBonus_GhostHeal = 15;
	public const int SetBonus_GhostHurt = 16;
	public const int VampireKnives = 18;
	public const int BoulderRain = 19;
	public const int MeteorRain = 20;
	public const int MeteorShower = 21;
	public const int StormLightning = 22;
	public static readonly int Count = 23;

	public static string? ToContextString(int itemSourceId) => itemSourceId switch {
		SetBonus_SolarExplosion_WhenTakingDamage => nameof(SetBonus_SolarExplosion_WhenTakingDamage),
		SetBonus_SolarExplosion_WhenDashing => nameof(SetBonus_SolarExplosion_WhenDashing),
		SetBonus_ForbiddenStorm => nameof(SetBonus_ForbiddenStorm),
		SetBonus_Titanium => nameof(SetBonus_Titanium),
		SetBonus_Orichalcum => nameof(SetBonus_Orichalcum),
		SetBonus_Chlorophyte => nameof(SetBonus_Chlorophyte),
		SetBonus_Stardust => nameof(SetBonus_Stardust),
		WeaponEnchantment_Confetti => nameof(WeaponEnchantment_Confetti),
		PlayerDeath_TombStone => nameof(PlayerDeath_TombStone),
		FallingStar => nameof(FallingStar),
		PlayerHurt_DropFootball => nameof(PlayerHurt_DropFootball),
		StormTigerTierSwap => nameof(StormTigerTierSwap),
		AbigailTierSwap => nameof(AbigailTierSwap),
		SetBonus_GhostHeal => nameof(SetBonus_GhostHeal),
		SetBonus_GhostHurt => nameof(SetBonus_GhostHurt),
		VampireKnives => nameof(VampireKnives),
		TorchGod => nameof(TorchGod),
		BoulderRain => nameof(BoulderRain),
		MeteorRain => nameof(MeteorRain),
		MeteorShower => nameof(MeteorShower),
		StormLightning => nameof(StormLightning),
		_ => null,
	};
}
