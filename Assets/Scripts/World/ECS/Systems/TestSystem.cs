using System;
using DefaultEcs;
using DefaultEcs.System;
using DefaultEcs.Threading;
using UnityEngine;

[With(typeof(MyPosComponent))]
public class TestSystem : AEntitySetSystem<float>
{
    public TestSystem(DefaultEcs.World world, bool useBuffer = false) : base(world, useBuffer)
    {
    }

    protected override void Update(float state, in DefaultEcs.Entity entity)
    {
        var component = entity.Get<MyPosComponent>();
        Debug.Log(component.transform.position);
    }
}