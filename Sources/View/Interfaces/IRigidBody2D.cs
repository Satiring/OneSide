using System;
using UnityEngine;

public interface IRigidBody2D
{
    Vector2 Velocity { get; set; }
    
    bool isKinematic { get; set; }
    
}