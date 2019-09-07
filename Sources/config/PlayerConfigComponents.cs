using Entitas;
using Entitas.CodeGeneration.Attributes;

// Components

// 

[Unique]
[Config]
public class InitialVelocity : IComponent
{
    public UnityEngine.Vector2 value;
}


[Unique]
[Config]
public class SpeedUpVelocityValue : IComponent
{
    public float value;
}

[Unique]
[Config]
public class SpeedUpPositionValue : IComponent
{
    public float value;
}

[Unique]
[Config]
public class StartPlayerPosition : IComponent
{
    public UnityEngine.Vector2 value;
}


[Unique]
[Config]
public class MaxPlayerDescentVelocity : IComponent
{
    public float value;
}

[Unique]
[Config]
public class ReductionFactorVelocity : IComponent
{
    public float value;
}

