using Entitas;

public class InitMovementPlayerSystem : IInitializeSystem  {
	private Contexts _contexts;

    public InitMovementPlayerSystem(Contexts contexts) {
    	_contexts = contexts;
    }

	public void Initialize()
	{
		var player = _contexts.game.playerEntity;

		if (player == null || !player.hasPosition || !player.hasView) return;
		
		player.AddVelocity(_contexts.config.initialVelocity.value);
		player.isMoving = true;

	}		
}