using UnityEngine;

public class CreatePlayerService : Service, ICreateObject2DService
{

    public CreatePlayerService(Contexts contexts) : base(contexts)
    {
    }
    

    public void Create(int id, Vector2 position2D, string assetName)
    {
        var entity = _contexts.game.CreateEntity();
        entity.isPlayer = true;
        entity.AddId(id);
        entity.AddAsset(assetName);
        entity.AddPosition(position2D);
        entity.AddVelocity(_contexts.config.initialVelocity.value);
    }
}