using System;
using Entitas;
using UnityEngine;
using UnityEngine.UI;


class UIInitializeSystem : IInitializeSystem
{
    readonly Context _context;
    Button b;

    public UIInitializeSystem(Contexts contexts)
    {
        _context = contexts.game;
    }


    public void Initialize()
    {
        b = GameObject.Find("/Canvas/Button").GetComponent<Button>();
        _context.CreateEntity().AddButton(b);
    }
}

