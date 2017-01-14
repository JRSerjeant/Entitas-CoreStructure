using System;
using Entitas;

class UIInitializeSystem : IInitializeSystem
{
    readonly Context _context;

    public UIInitializeSystem(Contexts contexts)
    {
        _context = contexts.game;
    }


    public void Initialize()
    {
        throw new NotImplementedException();
    }
}

