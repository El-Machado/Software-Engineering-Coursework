using Godot;
using System;

public partial class StartGameButton : Button
{
	[Export] public ConfirmationDialog NameDialog;
    [Export] public LineEdit NameInput;
	[Export] public PackedScene GameScene;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Pressed += OpenDialog;
        NameDialog.Confirmed += OnConfirmed;
        NameDialog.RegisterTextEnter(NameInput);   // pressing Enter = OK

	}
	 private void OpenDialog()
    {
        NameInput.Text = "";
        NameDialog.PopupCentered();   // show it in the middle of the screen
        NameInput.GrabFocus();        // cursor ready; opens keyboard on phones
    }
	private void OnConfirmed()
    {
        string name = NameInput.Text;
        GD.Print($"Name entered: {name}");
		
		var game = GameScene.Instantiate<MainGame>();   // GameRoot = script on that scene's root node
    	game.PlayerName = NameInput.Text;               // set before it starts

    	GetTree().ChangeSceneToNode(game);
    }
}
