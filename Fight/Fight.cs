using Godot;
using System;

public class Fight : Node
{
#pragma warning disable 649
	[Export]
	public PackedScene Fighter;
#pragma warning restore 649
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Fighter player = (Fighter)Fighter.Instance();
		Fighter opponent = (Fighter)Fighter.Instance();
		player.Init("player");
		opponent.Init("opponent");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
