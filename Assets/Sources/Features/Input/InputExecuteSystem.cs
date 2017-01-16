using System;
using Entitas;
using UnityEngine;
using DG.Tweening;

public sealed class InputExecuteSystem : IExecuteSystem
{

    readonly Context _context;
    Group _group;
    GameObject _gameObject;
    Sequence sq = DOTween.Sequence();

    public InputExecuteSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        _group = _context.GetGroup(GameMatcher.View);

        foreach (var item in _group.GetEntities())
        {
            if(! _gameObject)
            {
                _gameObject = item.view.gameObject;
            }
            
        }
        //Debug.Log(_gameObject);

        if (UnityEngine.Input.GetKeyDown("space"))
        {
            sq.Append(_gameObject.transform.DOJump(new Vector3(0,0,0), 1, 5, 5));
            sq.Append(_gameObject.transform.DOShakePosition(2));

        }
    }
}

