using Godot;
using System;

public partial class MainTextManager : BoxContainer
{
	private int _age = 0;
	public string name = "x";
	[Export] public MainGame MainGame;
	public override void _Ready()
	{
		name = MainGame.PlayerName;
	}
	public void AgeUp()
	{
		_age ++;
		GD.Print($"AgeUp called with {_age}");
		var label = new Label();
		label.Text = name + " is now " + _age + " years old";
		label.Position = new Vector2(100, 200);
		label.AddThemeColorOverride("font_color", Colors.Black);
    	label.AddThemeFontSizeOverride("font_size", 48);

		AddChild(label);
	}
}
