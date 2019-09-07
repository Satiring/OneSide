using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class ChunkVelocitySystem : ReactiveSystem<GameEntity>
{

	private readonly Contexts _contexts;
	
	
	public ChunkVelocitySystem (Contexts contexts) : base(contexts.game)
	{
		_contexts = contexts;
	}
		
	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
	{
		return context.CreateCollector(GameMatcher.Chunk);
	}
		
	protected override bool Filter(GameEntity entity)
	{
		return !entity.hasVelocity;
	}

	protected override void Execute(List<GameEntity> entities) {
		foreach (var e in entities) {
			e.AddVelocity(new Vector2(
				_contexts.config.horizontalChunkVelocity.value,
				_contexts.config.verticalChunkVelocity.value));
		}
	}
}
