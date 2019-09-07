//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity chunksCreatedEntity { get { return GetGroup(GameMatcher.ChunksCreated).GetSingleEntity(); } }
    public ChunksCreatedComponent chunksCreated { get { return chunksCreatedEntity.chunksCreated; } }
    public bool hasChunksCreated { get { return chunksCreatedEntity != null; } }

    public GameEntity SetChunksCreated(int newValue) {
        if (hasChunksCreated) {
            throw new Entitas.EntitasException("Could not set ChunksCreated!\n" + this + " already has an entity with ChunksCreatedComponent!",
                "You should check if the context already has a chunksCreatedEntity before setting it or use context.ReplaceChunksCreated().");
        }
        var entity = CreateEntity();
        entity.AddChunksCreated(newValue);
        return entity;
    }

    public void ReplaceChunksCreated(int newValue) {
        var entity = chunksCreatedEntity;
        if (entity == null) {
            entity = SetChunksCreated(newValue);
        } else {
            entity.ReplaceChunksCreated(newValue);
        }
    }

    public void RemoveChunksCreated() {
        chunksCreatedEntity.Destroy();
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
public partial class GameEntity {

    public ChunksCreatedComponent chunksCreated { get { return (ChunksCreatedComponent)GetComponent(GameComponentsLookup.ChunksCreated); } }
    public bool hasChunksCreated { get { return HasComponent(GameComponentsLookup.ChunksCreated); } }

    public void AddChunksCreated(int newValue) {
        var index = GameComponentsLookup.ChunksCreated;
        var component = (ChunksCreatedComponent)CreateComponent(index, typeof(ChunksCreatedComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceChunksCreated(int newValue) {
        var index = GameComponentsLookup.ChunksCreated;
        var component = (ChunksCreatedComponent)CreateComponent(index, typeof(ChunksCreatedComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveChunksCreated() {
        RemoveComponent(GameComponentsLookup.ChunksCreated);
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

    static Entitas.IMatcher<GameEntity> _matcherChunksCreated;

    public static Entitas.IMatcher<GameEntity> ChunksCreated {
        get {
            if (_matcherChunksCreated == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ChunksCreated);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChunksCreated = matcher;
            }

            return _matcherChunksCreated;
        }
    }
}