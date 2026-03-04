using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ExampleMod.Content.Items
{
	public class ExampleResearchPresent : ModItem
	{
		public static LocalizedText NoAccessoryText { get; private set; }
		public static LocalizedText NewAccessoryText { get; private set; }
		public static LocalizedText AllAccessoryText { get; private set; }

		public override void SetStaticDefaults() {
			// Must be researched as many times as there are items in the game.
			// If fully researched, and a new mod is added, it will become un-researched and require that much more
			// Research amount will never go down or over the max limit of 9999.
			Item.ResearchUnlockCount = Utils.Clamp(ItemLoader.ItemCount, 1, 9999);

				NoAccessoryText = this.GetLocalization("NoAccessory");
				NewAccessoryText = this.GetLocalization("NewAccessory");
				AllAccessoryText = this.GetLocalization("AllAccessory");
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.GoodieBag);
		}

			public override void OnResearched(bool fullyResearched) {
			if (fullyResearched) {
				LearnAllAccessories();
			}
			else {
				// Attempt to learn a random accessory for each present sacrificed
				int count = 0;
				for (int j = Item.stack; j > 0; j--) {
					if (LearnRandomAccessory()) {
						count++;
					}
				}
				if (count == 0) {
					Main.NewText(NoAccessoryText);
				}
				else {
					Main.NewText(NewAccessoryText.Format(count));
				}
			}
		}

		// try 1000 random item ids and if we randomly select an accessory, attempt learn it
		private bool LearnRandomAccessory() {
			for (int i = 0; i < 1000; i++) {
				int type = Main.rand.Next(1, ItemLoader.ItemCount);
				if (ContentSamples.ItemsByType[type].accessory) {
					if (CreativeUI.ResearchItem(type) == CreativeUI.ItemSacrificeResult.SacrificedAndDone) {
						return true;
					}
				}
			}
			return false;
		}

		private void LearnAllAccessories() {
			for (int i = 1; i < ItemLoader.ItemCount; i++) {
				if (ContentSamples.ItemsByType[i].accessory) {
					CreativeUI.ResearchItem(i);
				}
			}

			Main.NewText(AllAccessoryText);
		}
	}
}
