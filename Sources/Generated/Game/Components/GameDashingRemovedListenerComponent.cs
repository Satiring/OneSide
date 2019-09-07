//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DashingRemovedListenerComponent dashingRemovedListener { get { return (DashingRemovedListenerComponent)GetComponent(GameComponentsLookup.DashingRemovedListener); } }
    public bool hasDashingRemovedListener { get { return HasComponent(GameComponentsLookup.DashingRemovedListener); } }

    public void AddDashingRemovedListener(System.Collections.Generic.List<IDashingRemovedListener> newValue) {
        var index = GameComponentsLookup.DashingRemovedListener;
        var component = (DashingRemovedListenerComponent)CreateComponent(index, typeof(DashingRemovedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDashingRemovedListener(System.Collections.Generic.List<IDashingRemovedListener> newValue) {
        var index = GameComponentsLookup.DashingRemovedListener;
        var component = (DashingRemovedListenerComponent)CreateComponent(index, typeof(DashingRemovedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDashingRemovedListener() {
        RemoveComponent(GameComponentsLookup.DashingRemovedListener);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDashingRemovedListener;

    public static Entitas.IMatcher<GameEntity> DashingRemovedListener {
        get {
            if (_matcherDashingRemovedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DashingRemovedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDashingRemovedListener = matcher;
            }

            return _matcherDashingRemovedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddDashingRemovedListener(IDashingRemovedListener value) {
        var listeners = hasDashingRemovedListener
            ? dashingRemovedListener.value
            : new System.Collections.Generic.List<IDashingRemovedListener>();
        listeners.Add(value);
        ReplaceDashingRemovedListener(listeners);
    }

    public void RemoveDashingRemovedListener(IDashingRemovedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = dashingRemovedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDashingRemovedListener();
        } else {
            ReplaceDashingRemovedListener(listeners);
        }
    }
}
