//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ColliderIDComponent colliderID { get { return (ColliderIDComponent)GetComponent(GameComponentsLookup.ColliderID); } }
    public bool hasColliderID { get { return HasComponent(GameComponentsLookup.ColliderID); } }

    public void AddColliderID(int newValue) {
        var index = GameComponentsLookup.ColliderID;
        var component = (ColliderIDComponent)CreateComponent(index, typeof(ColliderIDComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceColliderID(int newValue) {
        var index = GameComponentsLookup.ColliderID;
        var component = (ColliderIDComponent)CreateComponent(index, typeof(ColliderIDComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveColliderID() {
        RemoveComponent(GameComponentsLookup.ColliderID);
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

    static Entitas.IMatcher<GameEntity> _matcherColliderID;

    public static Entitas.IMatcher<GameEntity> ColliderID {
        get {
            if (_matcherColliderID == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ColliderID);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherColliderID = matcher;
            }

            return _matcherColliderID;
        }
    }
}
