using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public void Init(DefaultEcs.World world)
    {
        var entity = world.CreateEntity();

        var components = GetComponents<IComponent>();

        foreach (var c in components)
        {
            entity.Set(c);
        }
    }
}