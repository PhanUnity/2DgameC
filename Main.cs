using Godot;
using System;

public partial class Main : Node
{
    [Export]
    public PackedScene MobScene { get; set; }

    private int _score;
}
