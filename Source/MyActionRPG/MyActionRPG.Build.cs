// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyActionRPG : ModuleRules
{
	public MyActionRPG(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MyActionRPG",
			"MyActionRPG/Variant_Platforming",
			"MyActionRPG/Variant_Platforming/Animation",
			"MyActionRPG/Variant_Combat",
			"MyActionRPG/Variant_Combat/AI",
			"MyActionRPG/Variant_Combat/Animation",
			"MyActionRPG/Variant_Combat/Gameplay",
			"MyActionRPG/Variant_Combat/Interfaces",
			"MyActionRPG/Variant_Combat/UI",
			"MyActionRPG/Variant_SideScrolling",
			"MyActionRPG/Variant_SideScrolling/AI",
			"MyActionRPG/Variant_SideScrolling/Gameplay",
			"MyActionRPG/Variant_SideScrolling/Interfaces",
			"MyActionRPG/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
