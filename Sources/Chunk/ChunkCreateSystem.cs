using Entitas;
using UnityEngine;

public class ChunkCreateSystem : IExecuteSystem  {
	private Contexts _contexts;
	private Services _services;

    public ChunkCreateSystem(Contexts contexts, Services services) {
    	_contexts = contexts;
        _services = services;
    }

	public void Execute()
	{
		var TimeBetweenSpawns = _contexts.config.timeBetweenSpawnsChunk.value;
		var ChunksCreated = _contexts.game.chunksCreated.Value;
		var ChunkInitialPosition = _contexts.config.initialChunkPosition.value;
		var time = _services.TimeService.RealtimeSinceStartup();

		if (time > (TimeBetweenSpawns * ChunksCreated))
		{
			var id = _services.IdService.GetNext();
			
			
			_contexts.game.chunksCreated.Value = ChunksCreated+1;
			_services.CreateChunkService.Create(id,ChunkInitialPosition, "Chunk01");
			
			Debug.Log("Se ha creado un chunk. Time: " + time + " id: " + id + " existen: " + ChunksCreated + " chunks");
		}		
		
		


	}
}