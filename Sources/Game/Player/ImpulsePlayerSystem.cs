using Entitas;
using UnityEngine;

public class ImpulsePlayerSystem : IExecuteSystem  {
	private Contexts _contexts;

    public ImpulsePlayerSystem(Contexts contexts) {
    	_contexts = contexts;
    }

    public void Execute()
    {

	    var player = _contexts.game.playerEntity;
	    if (player.isDashing)
	    {
		    player.isDashing = false;
		    if (player != null && player.hasRigidBody2D && player.hasVelocity)
		    {
			    // References
			    var speedToAddY = _contexts.config.speedUpVelocityValue.value;
			    var actualVerticalVelocity = player.velocity.value.y;
			    var capVerticalVelocity = _contexts.config.maxPlayerDescentVelocity.value;

			    // Max Velocity can be added due to the max Config
			    //var maxVelocityToAdd =  - player.rigidBody2D.value.Velocity.y;

			    // Force to add, just for clarify
			    var forceToAdd = new Vector2(
				    0,
				    System.Math.Min(
					    capVerticalVelocity,
					    actualVerticalVelocity + speedToAddY
				    )
			    );


			    //layer.rigidBody2D.value.AddVerticalImpulse(forceToAdd);

		    }
	    }
    }
}