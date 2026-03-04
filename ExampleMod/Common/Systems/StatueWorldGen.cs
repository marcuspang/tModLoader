using ExampleMod.Content.Tiles;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace ExampleMod.Common.Systems
{
	// This is a simple example of adding custom statues to world generation.
	// In this example, we add our statue tile to the existing data structure that will be consulted whenever a random statue is placed.
		public class StatueWorldGen : ModSystem
		{
			public override void PostWorldGen() {
				// Keep the sample implementation disabled until HookGen aliases for WorldGen hooks are restored.
				// The original detour-based sample can be re-enabled by porting On_WorldGen hooks.
				if (GenVars.statueList == null)
					return;

				// The vanilla game has an array of statue types that we'll be adding ours to.
				int startIndex = GenVars.statueList.Length; // Save the original length of the vanilla list to use later.

			// This is an array of statues we want to add to worldgen.
			// Set shouldBeWired to true to make the statue spawn with a pressure plate wired to it (like traps are).
			(int type, bool shouldBeWired, ushort placeStyle)[] statueTypesToAdd = [
				(ModContent.TileType<ExampleStatue>(), false, 0),
				// If the mod adds more statues, they can be added here.
			];

			// Make space in the statueList array.
			Array.Resize(ref GenVars.statueList, GenVars.statueList.Length + statueTypesToAdd.Length);

			// And then add Point16s of (TileID, PlaceStyle) to it.
			for (int i = 0; i < statueTypesToAdd.Length; i++) {
				int arrayIndex = startIndex + i;
				(int statueType, bool shouldBeWired, ushort placeStyle) = statueTypesToAdd[i];

				GenVars.statueList[arrayIndex] = new Point16(statueType, placeStyle);

				if (shouldBeWired) {
					GenVars.StatuesWithTraps.Add(arrayIndex);
				}
			}
		}
	}
}
