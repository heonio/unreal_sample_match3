// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealMatch3EditorTarget : TargetRules
{
	public UnrealMatch3EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.AddRange( new string[] { "Match3" } );
	}
}
