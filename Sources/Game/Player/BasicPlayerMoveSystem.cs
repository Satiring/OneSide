using System;
using Entitas;
using UnityEngine;

public class BasicPlayerMoveSystem : IExecuteSystem{
	private Contexts _contexts;
	private GameEntity _player;

    public BasicPlayerMoveSystem(Contexts contexts) {
    	_contexts = contexts;

    }

	public void Execute() {
		// per-frame code goes here
		_player = _contexts.game.playerEntity;

		if (_player != null && _player.hasRigidBody2D && _player.hasVelocity)
		{
			Debug.Log("Añado fuerza");
			_player.rigidBody2D.value.Velocity = _player.velocity.value; 
		}
		/*
		if (player != null && player.hasRigidBody2D && player.hasVelocity)
		{
			// Max Velocity can be added due to the max Config
			var maxCapVelocity = _contexts.config.maxPlayerDescentVelocity.value - player.rigidBody2D.value.Velocity.y; 
			
			// Force to add, just for clarify
			var forceToAdd = Math.Min(maxCapVelocity,_contexts.config.speedUpVelocityValue.value);
			
			// 
			player.rigidBody2D.value.AddVerticalImpulse(new Vector2(0,forceToAdd));
		}
		*/
		
	}
	
}