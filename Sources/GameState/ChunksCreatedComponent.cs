using Entitas;
using Entitas.CodeGeneration.Attributes;

[Unique]
[Game]
public class ChunksCreatedComponent : IComponent
{
    public int Value;
}