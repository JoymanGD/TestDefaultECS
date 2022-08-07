using System;
using DefaultEcs;
using DefaultEcs.System;
using DefaultEcs.Threading;
using UnityEngine;

[With(typeof(Camera))]
[With(typeof(Transform))]
public class TestSystem : AEntitySetSystem<float>
{
    public TestSystem(DefaultEcs.World world, bool useBuffer = false) : base(world, useBuffer)
    {
    }

    protected override void Update(float state, in DefaultEcs.Entity entity)
    {
        var camera = entity.Get<Camera>();
        Debug.Log(camera.transform.position);
    }
}