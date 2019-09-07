using UnityEngine;

public class CreateChunkService : Service, ICreateObject2DService
{
    public CreateChunkService(Contexts contexts) : base(contexts)
    {
    }


    public void Create(int id, Vector2 position2D, string assetName)
    {
        
        // Chunk listo
        var entity = _contexts.game.CreateEntity();
        entity.isChunk = true;
        entity.AddId(id);
        entity.AddAsset(assetName);
        entity.AddPosition(position2D);
    }
}
