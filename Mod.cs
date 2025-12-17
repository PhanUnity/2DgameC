using Godot;
using System;

public partial class Mod : RigidBody2D
{
    
    public override void _Ready()
    {
        var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
        
        // get the list of animation names from the AnimatedSprite2D's sprite_frames property: walk, fly, swim...
        string[] mobTypes = animatedSprite2D.SpriteFrames.GetAnimationNames();
        animatedSprite2D.Play(mobTypes[GD.Randi() % mobTypes.Length]);
    }
    
    // the mobs delete themselves when they leave the screen
    private void OnVisibleOnScreenNotifier2DScreenExited()
    {
        QueueFree();
    }
}
