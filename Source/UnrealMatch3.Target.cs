// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealMatch3Target : TargetRules
{
	public UnrealMatch3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.AddRange( new string[] { "Match3" } );

        if (Target.Platform == UnrealTargetPlatform.IOS && !bUsePrecompiled)
        {
            bCompileAPEX = false;
            bCompileNvCloth = false;
            bCompileICU = true;
            bCompileSimplygon = false;
            bCompileLeanAndMeanUE = true;
            bCompileRecast = true;
            bCompileFreeType = true;
            bCompileForSize = true;
        }

        PreBuildSteps.Add("echo =========!!!");
	}
}
