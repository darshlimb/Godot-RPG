using Godot;
using System;

namespace RPG;

// Manage state of GameWorld
public partial class Game : Node
{
    StateMachine _gameStateMachine;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _gameStateMachine = GetNode<StateMachine>("StateMachine");
    }

    public void StartNewGame()
    {
        _gameStateMachine.UpdateState("MainGameState");
    }


    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}
