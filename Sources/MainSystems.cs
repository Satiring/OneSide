using Entitas;
using UnityEngine.Networking;

public class MainSystems : Feature  {
    public MainSystems(Contexts contexts, Services services) {
    	
	    // Systems
	    Add(new InitCreatePlayerSystem(contexts,services));

	    Add(new ChunkCreateSystem(contexts, services));
	    
	    // View
	    Add(new ViewSystem(contexts,services));
	    
	    Add(new ChunkVelocitySystem(contexts));
	    Add(new ChunkMovementSystem(contexts));

	    //Add(new InitMovementPlayerSystem(contexts));
	    
	    // MoveSystem
	    Add(new BasicPlayerMoveSystem(contexts));
	    Add(new UpdatePlayerPositionSystem(contexts));
	    


    }	
}