using Godot;
using System;

public partial class PlayerManager : Node2D
{
    [Export]
    public AnimationController animationController;
    [Export]
    public MovementController movementController;
}
