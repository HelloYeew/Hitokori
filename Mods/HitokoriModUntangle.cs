﻿using osu.Framework.Graphics.Sprites;
using osu.Game.Rulesets.Hitokori.Beatmaps;
using osu.Game.Rulesets.Mods;
using System;
using System.Collections.Generic;
using System.Text;

namespace osu.Game.Rulesets.Hitokori.Mods {
	public class HitokoriModUntangle : AutoImplementedMod {
		public override string Name => "Untangle";
		public override string Acronym => "UN";
		public override string Description => "WIP";

		public override double ScoreMultiplier => 1;

		public override IconUsage? Icon => FontAwesome.Solid.Ribbon;
		public override ModType Type => ModType.Conversion;

		[Modifies( typeof( HitokoriBeatmapConverter ), nameof( HitokoriBeatmapConverter.Untangle ) )]
		private bool Untangle => true;
	}
}
