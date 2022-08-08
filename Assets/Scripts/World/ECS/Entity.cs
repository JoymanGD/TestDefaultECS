using System;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public void Init(DefaultEcs.World world)
    {
        var entity = world.CreateEntity();

        var components = GetComponents<IComponent>();

        foreach (var c in components)
        {
            c.Init(entity);
        }
    }
    
    public static void SetComponent<T>(in T component, DefaultEcs.Entity entity)
    {
        entity.Set<T>(component);
    }
}