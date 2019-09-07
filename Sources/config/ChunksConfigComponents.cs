using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Unique]
[Config]
public class HorizontalChunkVelocity : IComponent
{
    public float value;
}

[Unique]
[Config]
public class VerticalChunkVelocity : IComponent
{
    public float value;
}

[Unique]
[Config]
public class TimeBetweenSpawnsChunk : IComponent
{
    public float value;
}

[Unique]
[Config]
public class DistanceToDestroyChunk : IComponent
{
    public float value;
}

[Unique]
[Config]
public class InitialChunkPosition : IComponent
{
    public Vector2 value;
}