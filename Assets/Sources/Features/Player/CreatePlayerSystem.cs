using System;
using Entitas;

public sealed class CreatePlayerSystem : IInitializeSystem
{
    Context _context;

    public CreatePlayerSystem(Contexts contexts){
        _context = contexts.game;
    }

    public void Initialize()
    {
        _context.CreateEntity()
            .AddResource("TestObject");
    }
}
