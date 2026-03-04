using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terraria.GameContent.UI.States;

namespace Terraria.ModLoader
{
	[TestClass]
	public class Port145CompatibilityTests
	{
		[TestMethod]
		public void UpscaleAndSaveImageAsPng_RejectsNonPositiveDimensionsBeforeIO()
		{
			// Uses a missing source path intentionally. Validation should happen before file access.
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
				WorkshopPublishInfoStateForMods.UpscaleAndSaveImageAsPng("missing.png", "out.png", 0, 4));

			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
				WorkshopPublishInfoStateForMods.UpscaleAndSaveImageAsPng("missing.png", "out.png", 4, 0));
		}

		[TestMethod]
		public void UpscaleAndSaveImageAsPng_StillReadsSourceWhenDimensionsAreValid()
		{
			// Ensures the guard is not overbroad: with valid dimensions, source file is accessed.
			Assert.ThrowsException<FileNotFoundException>(() =>
				WorkshopPublishInfoStateForMods.UpscaleAndSaveImageAsPng("missing.png", "out.png", 4, 4));
		}

	}
}
