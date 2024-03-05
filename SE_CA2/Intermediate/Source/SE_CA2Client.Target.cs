using UnrealBuildTool;

public class SE_CA2ClientTarget : TargetRules
{
	public SE_CA2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SE_CA2");
	}
}
