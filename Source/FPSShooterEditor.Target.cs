// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FPSShooterEditorTarget : TargetRules
{
	public FPSShooterEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        bUsesSteam = true;
		ExtraModuleNames.AddRange( new string[] { "FPSShooter" } );
	}
}
