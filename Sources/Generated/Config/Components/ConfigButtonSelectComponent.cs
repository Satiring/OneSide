//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity buttonSelectEntity { get { return GetGroup(ConfigMatcher.ButtonSelect).GetSingleEntity(); } }
    public ButtonSelectComponent buttonSelect { get { return buttonSelectEntity.buttonSelect; } }
    public bool hasButtonSelect { get { return buttonSelectEntity != null; } }

    public ConfigEntity SetButtonSelect(string newValue) {
        if (hasButtonSelect) {
            throw new Entitas.EntitasException("Could not set ButtonSelect!\n" + this + " already has an entity with ButtonSelectComponent!",
                "You should check if the context already has a buttonSelectEntity before setting it or use context.ReplaceButtonSelect().");
        }
        var entity = CreateEntity();
        entity.AddButtonSelect(newValue);
        return entity;
    }

    public void ReplaceButtonSelect(string newValue) {
        var entity = buttonSelectEntity;
        if (entity == null) {
            entity = SetButtonSelect(newValue);
        } else {
            entity.ReplaceButtonSelect(newValue);
        }
    }

    public void RemoveButtonSelect() {
        buttonSelectEntity.Destroy();
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

    public ButtonSelectComponent buttonSelect { get { return (ButtonSelectComponent)GetComponent(ConfigComponentsLookup.ButtonSelect); } }
    public bool hasButtonSelect { get { return HasComponent(ConfigComponentsLookup.ButtonSelect); } }

    public void AddButtonSelect(string newValue) {
        var index = ConfigComponentsLookup.ButtonSelect;
        var component = (ButtonSelectComponent)CreateComponent(index, typeof(ButtonSelectComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceButtonSelect(string newValue) {
        var index = ConfigComponentsLookup.ButtonSelect;
        var component = (ButtonSelectComponent)CreateComponent(index, typeof(ButtonSelectComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveButtonSelect() {
        RemoveComponent(ConfigComponentsLookup.ButtonSelect);
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

    static Entitas.IMatcher<ConfigEntity> _matcherButtonSelect;

    public static Entitas.IMatcher<ConfigEntity> ButtonSelect {
        get {
            if (_matcherButtonSelect == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.ButtonSelect);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherButtonSelect = matcher;
            }

            return _matcherButtonSelect;
        }
    }
}