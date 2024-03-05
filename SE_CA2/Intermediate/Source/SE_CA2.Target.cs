using UnrealBuildTool;

public class SE_CA2Target : TargetRules
{
	public SE_CA2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SE_CA2");
	}
}
