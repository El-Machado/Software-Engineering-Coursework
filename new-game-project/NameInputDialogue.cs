using Godot;
using System;

public partial class NameInputDialogue : ConfirmationDialog
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AddThemeFontSizeOverride("title_font_size", 30);
    	AddThemeConstantOverride("title_height", 40);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
