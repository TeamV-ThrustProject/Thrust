// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TrustProject : ModuleRules
{
	public TrustProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
