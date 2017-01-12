using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class RemoveViewSystem : ReactiveSystem
{
    public RemoveViewSystem(Contexts contexts) : base(contexts.game) {
    }

    protected override void Execute(List<Entity> entities)
    {
        foreach (var e in entities)
        {
            UnityEngine.Object.Destroy(e.view.gameObject);
            e.RemoveView();
        }
    }

    protected override bool Filter(Entity entity)
    {
        return entity.hasView;
    }

    protected override Collector GetTrigger(Context context)
    {
        return new Collector(
            new Group[] {
                context.GetGroup(GameMatcher.Resource)
            },
            new GroupEvent[] {
                GroupEvent.AddedOrRemoved
            }
            );
    }

}

