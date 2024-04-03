// Made by Ivan Piccione

using UnrealBuildTool;
using System.Collections.Generic;

public class ToweringSaviourEditorTarget : TargetRules
{
	public ToweringSaviourEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "ToweringSaviour" } );
	}
}
