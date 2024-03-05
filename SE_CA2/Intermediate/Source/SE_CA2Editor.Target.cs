using UnrealBuildTool;

public class SE_CA2EditorTarget : TargetRules
{
	public SE_CA2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SE_CA2");
	}
}
