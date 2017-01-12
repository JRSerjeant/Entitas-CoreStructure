using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour {

    Systems _systems;

	void Start () {

        var contexts = Contexts.sharedInstance;
        contexts.SetAllContexts();

        _systems = createSystems(contexts);
        _systems.Initialize();
	}
	
	void Update () {
        _systems.Execute();
	}

    Systems createSystems(Contexts contexts)
    {
        return new Feature("Systems")
                  
        // Initialize
            .Add(new CreatePlayerSystem(contexts))

        // Input
            // Add input systems

        // Update
            // Add update systems

        // Render
            .Add(new RemoveViewSystem(contexts))
            .Add(new AddViewSystem(contexts))

        //Destroy
        ;
    }
}
