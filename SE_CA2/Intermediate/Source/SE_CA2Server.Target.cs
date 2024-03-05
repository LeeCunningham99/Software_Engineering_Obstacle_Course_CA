using UnrealBuildTool;

public class SE_CA2ServerTarget : TargetRules
{
	public SE_CA2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SE_CA2");
	}
}
