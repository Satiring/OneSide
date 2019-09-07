//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity verticalChunkVelocityEntity { get { return GetGroup(ConfigMatcher.VerticalChunkVelocity).GetSingleEntity(); } }
    public VerticalChunkVelocity verticalChunkVelocity { get { return verticalChunkVelocityEntity.verticalChunkVelocity; } }
    public bool hasVerticalChunkVelocity { get { return verticalChunkVelocityEntity != null; } }

    public ConfigEntity SetVerticalChunkVelocity(float newValue) {
        if (hasVerticalChunkVelocity) {
            throw new Entitas.EntitasException("Could not set VerticalChunkVelocity!\n" + this + " already has an entity with VerticalChunkVelocity!",
                "You should check if the context already has a verticalChunkVelocityEntity before setting it or use context.ReplaceVerticalChunkVelocity().");
        }
        var entity = CreateEntity();
        entity.AddVerticalChunkVelocity(newValue);
        return entity;
    }

    public void ReplaceVerticalChunkVelocity(float newValue) {
        var entity = verticalChunkVelocityEntity;
        if (entity == null) {
            entity = SetVerticalChunkVelocity(newValue);
        } else {
            entity.ReplaceVerticalChunkVelocity(newValue);
        }
    }

    public void RemoveVerticalChunkVelocity() {
        verticalChunkVelocityEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigEntity {

    public VerticalChunkVelocity verticalChunkVelocity { get { return (VerticalChunkVelocity)GetComponent(ConfigComponentsLookup.VerticalChunkVelocity); } }
    public bool hasVerticalChunkVelocity { get { return HasComponent(ConfigComponentsLookup.VerticalChunkVelocity); } }

    public void AddVerticalChunkVelocity(float newValue) {
        var index = ConfigComponentsLookup.VerticalChunkVelocity;
        var component = (VerticalChunkVelocity)CreateComponent(index, typeof(VerticalChunkVelocity));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVerticalChunkVelocity(float newValue) {
        var index = ConfigComponentsLookup.VerticalChunkVelocity;
        var component = (VerticalChunkVelocity)CreateComponent(index, typeof(VerticalChunkVelocity));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVerticalChunkVelocity() {
        RemoveComponent(ConfigComponentsLookup.VerticalChunkVelocity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ConfigMatcher {

    static Entitas.IMatcher<ConfigEntity> _matcherVerticalChunkVelocity;

    public static Entitas.IMatcher<ConfigEntity> VerticalChunkVelocity {
        get {
            if (_matcherVerticalChunkVelocity == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.VerticalChunkVelocity);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherVerticalChunkVelocity = matcher;
            }

            return _matcherVerticalChunkVelocity;
        }
    }
}