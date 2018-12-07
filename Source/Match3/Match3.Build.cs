// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Match3 : ModuleRules
{
	public Match3(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D", "UMG" });

		//PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
        DynamicallyLoadedModuleNames.Add("OnlineSubsystemNull");

        if (Target.Platform == UnrealTargetPlatform.IOS)
        {
            PrivateDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "OnlineSubsystem" });
            DynamicallyLoadedModuleNames.Add("IOSAdvertising");
        }
        else if (Target.Platform == UnrealTargetPlatform.Android)
        {
            PrivateDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "OnlineSubsystem" });
            DynamicallyLoadedModuleNames.Add("AndroidAdvertising");
        }
	}
}
