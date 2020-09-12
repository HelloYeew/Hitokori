﻿using System.ComponentModel;

namespace osu.Game.Rulesets.Hitokori.Settings {
	public enum HitokoriSetting {
		ADOFAIJudgement,
		MissCorrectionMode,
		CameraFollowMode,
		CameraSpeed,
		RingOpacity,
		RingDashStyle,

		HoldConnectorWidth,
		ConnectorWidth
	}

	public enum MissCorrectionMode {
		[Description( "Angles" )]
		Angle = 0,

		[Description( "Velocity ( obsolete | jumpy )" )]
		Velocity = 1
	}

	public enum CameraFollowMode {
		[Description( "Fast" )]
		Dynamic,

		[Description( "Smooth" )]
		Smooth
	}

	public enum DashStyle {
		Dashed,

		Dotted,

		Solid
	}
}
