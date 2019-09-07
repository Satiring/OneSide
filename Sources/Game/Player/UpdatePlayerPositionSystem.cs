using Entitas;

public class UpdatePlayerPositionSystem : IExecuteSystem  {
	private Contexts _contexts;

    public UpdatePlayerPositionSystem(Contexts contexts) {
    	_contexts = contexts;
    }

	public void Execute()
	{
		var player = _contexts.game.playerEntity;

		if (player != null && player.hasPosition && player.hasView)
		{
			player.ReplacePosition(player.view.Value.Position);
		}
		
	}
}