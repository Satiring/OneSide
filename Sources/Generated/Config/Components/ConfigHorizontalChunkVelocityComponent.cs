//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity horizontalChunkVelocityEntity { get { return GetGroup(ConfigMatcher.HorizontalChunkVelocity).GetSingleEntity(); } }
    public HorizontalChunkVelocity horizontalChunkVelocity { get { return horizontalChunkVelocityEntity.horizontalChunkVelocity; } }
    public bool hasHorizontalChunkVelocity { get { return horizontalChunkVelocityEntity != null; } }

    public ConfigEntity SetHorizontalChunkVelocity(float newValue) {
        if (hasHorizontalChunkVelocity) {
            throw new Entitas.EntitasException("Could not set HorizontalChunkVelocity!\n" + this + " already has an entity with HorizontalChunkVelocity!",
                "You should check if the context already has a horizontalChunkVelocityEntity before setting it or use context.ReplaceHorizontalChunkVelocity().");
        }
        var entity = CreateEntity();
        entity.AddHorizontalChunkVelocity(newValue);
        return entity;
    }

    public void ReplaceHorizontalChunkVelocity(float newValue) {
        var entity = horizontalChunkVelocityEntity;
        if (entity == null) {
            entity = SetHorizontalChunkVelocity(newValue);
        } else {
            entity.ReplaceHorizontalChunkVelocity(newValue);
        }
    }

    public void RemoveHorizontalChunkVelocity() {
        horizontalChunkVelocityEntity.Destroy();
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

    public HorizontalChunkVelocity horizontalChunkVelocity { get { return (HorizontalChunkVelocity)GetComponent(ConfigComponentsLookup.HorizontalChunkVelocity); } }
    public bool hasHorizontalChunkVelocity { get { return HasComponent(ConfigComponentsLookup.HorizontalChunkVelocity); } }

    public void AddHorizontalChunkVelocity(float newValue) {
        var index = ConfigComponentsLookup.HorizontalChunkVelocity;
        var component = (HorizontalChunkVelocity)CreateComponent(index, typeof(HorizontalChunkVelocity));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceHorizontalChunkVelocity(float newValue) {
        var index = ConfigComponentsLookup.HorizontalChunkVelocity;
        var component = (HorizontalChunkVelocity)CreateComponent(index, typeof(HorizontalChunkVelocity));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveHorizontalChunkVelocity() {
        RemoveComponent(ConfigComponentsLookup.HorizontalChunkVelocity);
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

    static Entitas.IMatcher<ConfigEntity> _matcherHorizontalChunkVelocity;

    public static Entitas.IMatcher<ConfigEntity> HorizontalChunkVelocity {
        get {
            if (_matcherHorizontalChunkVelocity == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.HorizontalChunkVelocity);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherHorizontalChunkVelocity = matcher;
            }

            return _matcherHorizontalChunkVelocity;
        }
    }
}
