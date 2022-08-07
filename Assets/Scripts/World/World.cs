using System;
using System.Collections;
using System.Collections.Generic;
using DefaultEcs.System;
using UnityEngine;

public class World : MonoBehaviour
{
    private DefaultEcs.World ecsWorld;
    private SequentialSystem<float> systems;

    public void Init()
    {
        ecsWorld = new DefaultEcs.World();
        CreateEntities();
        LaunchSystems();
    }

    private void CreateEntities()
    {
        var entities = GetComponentsInChildren<Entity>();
        
        foreach (var e in entities)
        {
            e.Init(ecsWorld);
        }
    }

    private void LaunchSystems()
    {
        systems = new SequentialSystem<float>
        (
            new TestSystem(ecsWorld)
        );
    }

    public void UpdateWorld(float deltaTime)
    {
        systems.Update(deltaTime);
    }
}
