// Made by Ivan Piccione

using UnrealBuildTool;
using System.Collections.Generic;

public class ToweringSaviourTarget : TargetRules
{
	public ToweringSaviourTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "ToweringSaviour" } );
	}
}
