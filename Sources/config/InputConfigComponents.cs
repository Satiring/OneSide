using Entitas;
using Entitas.CodeGeneration.Attributes;
// Components Definitions
// -----------------------------------------------


[Unique]
[Config]
public class HorizontalAxisComponent : IComponent
{
    public string value;
}

[Unique]
[Config]
public class VerticalAxisComponent : IComponent
{
    public string value;
}

[Unique]
[Config]
public class ButtonAComponent : IComponent
{
    public string value;
}

[Unique]
[Config]
public class ButtonBComponent : IComponent
{
    public string value;
}

[Unique]
[Config]
public class ButtonStartComponent : IComponent
{
    public string value;
}

[Unique]
[Config]
public class ButtonSelectComponent : IComponent
{
    public string value;
}