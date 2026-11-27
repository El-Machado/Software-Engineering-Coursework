using Godot;
using System;
using System.ComponentModel;
public partial class AgeButton : Button
{
    private int _age = 0;
    [Export] public Label label;
    [Export] public MainTextManager MainTextManager;

    public override void _Ready()
    {
        Pressed += OnPressed;                  // runs OnPressed when tapped
    }

    private void OnPressed()
    {
        _age++;
        label.Text = $"Age {_age}";
        MainTextManager.AgeUp();
    }
}