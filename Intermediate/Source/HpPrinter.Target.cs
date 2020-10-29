using UnrealBuildTool;

public class HpPrinterTarget : TargetRules
{
	public HpPrinterTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("HpPrinter");
	}
}
