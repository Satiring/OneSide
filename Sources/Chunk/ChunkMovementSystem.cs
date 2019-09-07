using Entitas;

public class ChunkMovementSystem : IExecuteSystem  {
	private Contexts _contexts;	

	public ChunkMovementSystem(Contexts contexts) {
    	_contexts = contexts;
    }

	public void Execute()
	{
		var entities = _contexts.game.GetGroup(GameMatcher.AnyOf(GameMatcher.Velocity, GameMatcher.Chunk, GameMatcher.RigidBody2D)).GetEntities();

		
		foreach (var entity in entities)
		{
			entity.rigidBody2D.value.Velocity = entity.velocity.value;
		}
		

	}
}