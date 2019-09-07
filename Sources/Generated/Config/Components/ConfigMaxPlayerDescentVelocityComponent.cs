//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity maxPlayerDescentVelocityEntity { get { return GetGroup(ConfigMatcher.MaxPlayerDescentVelocity).GetSingleEntity(); } }
    public MaxPlayerDescentVelocity maxPlayerDescentVelocity { get { return maxPlayerDescentVelocityEntity.maxPlayerDescentVelocity; } }
    public bool hasMaxPlayerDescentVelocity { get { return maxPlayerDescentVelocityEntity != null; } }

    public ConfigEntity SetMaxPlayerDescentVelocity(float newValue) {
        if (hasMaxPlayerDescentVelocity) {
            throw new Entitas.EntitasException("Could not set MaxPlayerDescentVelocity!\n" + this + " already has an entity with MaxPlayerDescentVelocity!",
                "You should check if the context already has a maxPlayerDescentVelocityEntity before setting it or use context.ReplaceMaxPlayerDescentVelocity().");
        }
        var entity = CreateEntity();
        entity.AddMaxPlayerDescentVelocity(newValue);
        return entity;
    }

    public void ReplaceMaxPlayerDescentVelocity(float newValue) {
        var entity = maxPlayerDescentVelocityEntity;
        if (entity == null) {
            entity = SetMaxPlayerDescentVelocity(newValue);
        } else {
            entity.ReplaceMaxPlayerDescentVelocity(newValue);
        }
    }

    public void RemoveMaxPlayerDescentVelocity() {
        maxPlayerDescentVelocityEntity.Destroy();
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

    public MaxPlayerDescentVelocity maxPlayerDescentVelocity { get { return (MaxPlayerDescentVelocity)GetComponent(ConfigComponentsLookup.MaxPlayerDescentVelocity); } }
    public bool hasMaxPlayerDescentVelocity { get { return HasComponent(ConfigComponentsLookup.MaxPlayerDescentVelocity); } }

    public void AddMaxPlayerDescentVelocity(float newValue) {
        var index = ConfigComponentsLookup.MaxPlayerDescentVelocity;
        var component = (MaxPlayerDescentVelocity)CreateComponent(index, typeof(MaxPlayerDescentVelocity));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMaxPlayerDescentVelocity(float newValue) {
        var index = ConfigComponentsLookup.MaxPlayerDescentVelocity;
        var component = (MaxPlayerDescentVelocity)CreateComponent(index, typeof(MaxPlayerDescentVelocity));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMaxPlayerDescentVelocity() {
        RemoveComponent(ConfigComponentsLookup.MaxPlayerDescentVelocity);
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

    static Entitas.IMatcher<ConfigEntity> _matcherMaxPlayerDescentVelocity;

    public static Entitas.IMatcher<ConfigEntity> MaxPlayerDescentVelocity {
        get {
            if (_matcherMaxPlayerDescentVelocity == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.MaxPlayerDescentVelocity);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherMaxPlayerDescentVelocity = matcher;
            }

            return _matcherMaxPlayerDescentVelocity;
        }
    }
}
