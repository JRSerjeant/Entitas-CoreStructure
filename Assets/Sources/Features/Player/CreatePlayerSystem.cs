using System;
using Entitas;
using UnityEngine;

public sealed class CreatePlayerSystem : IInitializeSystem
{
    Context _context;

    public CreatePlayerSystem(Contexts contexts){
        _context = contexts.game;
    }

    public void Initialize()
    {
        //Debug.Log("Creating GameObject Resource");
        _context.CreateEntity()
            .AddResource("TestObject");
    }
}
