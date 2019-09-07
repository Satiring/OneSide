using System.Collections.Generic;
using UnityEngine;
using Entitas;




public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    private MainSystems _systems;
    private Services _services;
    

    private void Awake()
    {
        _contexts = Contexts.sharedInstance;
        _services = new Services();

        Configure(_contexts);
        CreateServices(_contexts, _services);

        _systems = new MainSystems(_contexts, _services);
        
        // 
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
    
    private void OnDestroy()
    {
        _systems.DeactivateReactiveSystems();
        _systems.ClearReactiveSystems();
        _systems.TearDown();
        
    }

    //It's not in the system for ease of use
    private void Configure(Contexts contexts)
    {
        // I dont like at all this solution, but im learning...
        
        // We must implement this configs parameters via JSON service.
        
        // ANYWAYS.
        // TO-DO 
        
        // Map Config
        var minScreenPoint = new Vector2(0,0 ); 
        var maxScreenPoint = new Vector2(160,144 );
        var middlePoint = new Vector2(((maxScreenPoint.x - minScreenPoint.x) / 2), ((maxScreenPoint.y - minScreenPoint.y) / 2));
        
        // Chunk Size
        var chunkSize = 4f;

        // Map Set 
        contexts.config.SetMapSizeConfig(
            minScreenPoint,
            maxScreenPoint,
            chunkSize);
        contexts.config.SetMapSideWidth(16f);

        
        
        // Player Config
        contexts.config.SetInitialVelocity(new Vector2(0f, 0f));
        contexts.config.SetReductionFactorVelocity(0f);
        contexts.config.SetStartPlayerPosition(middlePoint) ;
        contexts.config.SetSpeedUpPositionValue(10f);
        contexts.config.SetMaxPlayerDescentVelocity(25f);
        contexts.config.SetSpeedUpVelocityValue(10f);
        
        
        // Input Config
        contexts.config.SetButtonA("j");
        contexts.config.SetButtonB("k");
        contexts.config.SetButtonSelect("space");
        contexts.config.SetButtonStart("enter");
        contexts.config.SetHorizontalAxis("horizontal");
        contexts.config.SetVerticalAxis("vertical");
        
        // Chunks Config
        contexts.config.SetHorizontalChunkVelocity(0f);
        contexts.config.SetVerticalChunkVelocity(0.2f);
        contexts.config.SetTimeBetweenSpawnsChunk(5);
        contexts.config.SetInitialChunkPosition(new Vector2(contexts.config.startPlayerPosition.value.x,0));


        contexts.game.SetChunksCreated(1);
    }

    private void CreateServices(Contexts contexts, Services services)
    {

        services.ViewService = new UnityViewService(contexts);
        services.PhysicsService = new UnityPhysicsService(contexts);
        services.InputService = new UnityInputGameBoyService(contexts);
        services.TimeService = new UnityTimeService(contexts);
        services.CollisionEmissionService = new UnityCollisionEmissionService(contexts);
        services.IdService = new IdService(contexts);
        services.CreatePlayerService = new CreatePlayerService(contexts);
        services.CreateChunkService = new CreateChunkService(contexts);
        
        
//        services.JumpService               = new JumpService(contexts);
//        services.CreatePlayerService       = new CreatePlayerService(contexts);
//        services.KillPlayerService         = new KillPlayerService(contexts);
//        services.CreateChunkService        = new CreateChunkService(contexts);
//        services.CollisionEmisstionService = new UnityCollisionEmissionService(contexts);
    }

#if !ENTITAS_DISABLE_VISUAL_DEBUGGING
    private void OnGUI()
    {
       // For testing
    }
#endif
}