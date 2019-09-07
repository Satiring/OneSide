using Entitas;

public class InitCreatePlayerSystem : IInitializeSystem  {
	private Contexts _contexts;
	private Services _services;

    public InitCreatePlayerSystem(Contexts contexts, Services services) {
    	_contexts = contexts;
        _services = services;
    }

	public void Initialize() {
		// Initialization code here
		var id = _services.IdService.GetNext();
		_services.CreatePlayerService.Create(id, _contexts.config.startPlayerPosition.value, "Player");

	}		
}