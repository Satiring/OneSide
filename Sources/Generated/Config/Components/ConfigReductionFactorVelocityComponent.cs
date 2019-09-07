//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity reductionFactorVelocityEntity { get { return GetGroup(ConfigMatcher.ReductionFactorVelocity).GetSingleEntity(); } }
    public ReductionFactorVelocity reductionFactorVelocity { get { return reductionFactorVelocityEntity.reductionFactorVelocity; } }
    public bool hasReductionFactorVelocity { get { return reductionFactorVelocityEntity != null; } }

    public ConfigEntity SetReductionFactorVelocity(float newValue) {
        if (hasReductionFactorVelocity) {
            throw new Entitas.EntitasException("Could not set ReductionFactorVelocity!\n" + this + " already has an entity with ReductionFactorVelocity!",
                "You should check if the context already has a reductionFactorVelocityEntity before setting it or use context.ReplaceReductionFactorVelocity().");
        }
        var entity = CreateEntity();
        entity.AddReductionFactorVelocity(newValue);
        return entity;
    }

    public void ReplaceReductionFactorVelocity(float newValue) {
        var entity = reductionFactorVelocityEntity;
        if (entity == null) {
            entity = SetReductionFactorVelocity(newValue);
        } else {
            entity.ReplaceReductionFactorVelocity(newValue);
        }
    }

    public void RemoveReductionFactorVelocity() {
        reductionFactorVelocityEntity.Destroy();
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

    public ReductionFactorVelocity reductionFactorVelocity { get { return (ReductionFactorVelocity)GetComponent(ConfigComponentsLookup.ReductionFactorVelocity); } }
    public bool hasReductionFactorVelocity { get { return HasComponent(ConfigComponentsLookup.ReductionFactorVelocity); } }

    public void AddReductionFactorVelocity(float newValue) {
        var index = ConfigComponentsLookup.ReductionFactorVelocity;
        var component = (ReductionFactorVelocity)CreateComponent(index, typeof(ReductionFactorVelocity));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceReductionFactorVelocity(float newValue) {
        var index = ConfigComponentsLookup.ReductionFactorVelocity;
        var component = (ReductionFactorVelocity)CreateComponent(index, typeof(ReductionFactorVelocity));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveReductionFactorVelocity() {
        RemoveComponent(ConfigComponentsLookup.ReductionFactorVelocity);
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

    static Entitas.IMatcher<ConfigEntity> _matcherReductionFactorVelocity;

    public static Entitas.IMatcher<ConfigEntity> ReductionFactorVelocity {
        get {
            if (_matcherReductionFactorVelocity == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.ReductionFactorVelocity);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherReductionFactorVelocity = matcher;
            }

            return _matcherReductionFactorVelocity;
        }
    }
}
