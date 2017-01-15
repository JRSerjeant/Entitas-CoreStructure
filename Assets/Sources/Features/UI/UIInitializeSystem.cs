using System;
using Entitas;
using UnityEngine;
using UnityEngine.UI;


class UIInitializeSystem : IInitializeSystem
{
    readonly Context _context;
    Entity _entity;
    GameObject _gameObject;
    Button _button;

    public UIInitializeSystem(Contexts contexts)
    {
        _context = contexts.game;
    }


    public void Initialize()
    {
        _gameObject = GameObject.Find("/Canvas/Button");
        _button = _gameObject.GetComponent<Button>();
        _entity = _context.CreateEntity().AddButton(_button);
        _gameObject.Link(_entity, _context);

    }
}

