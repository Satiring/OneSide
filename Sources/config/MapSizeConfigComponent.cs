using Entitas;
using Entitas.CodeGeneration.Attributes;

[Unique]
[Config]
public class MapSizeConfigComponent : IComponent {

    // Map Definition
    public UnityEngine.Vector2 MinScreenPoint;
    public UnityEngine.Vector2 MaxScreenPoint;

    public float SizeChunk;
}

[Unique]
[Config]
public class MapSideWidth : IComponent
{

    public float value;
}
