using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Event(EventTarget.Self)]
[Game]
public class PositionComponent : IComponent
{
    public Vector2 Value;
}