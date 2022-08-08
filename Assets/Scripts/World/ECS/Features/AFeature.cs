using System.Collections.Generic;
using DefaultEcs.System;

public abstract class AFeature<T>
{
    protected DefaultEcs.World world;

    public List<ISystem<T>> systems { get; set; } = new List<ISystem<T>>();

    public AFeature(DefaultEcs.World world)
    {
        this.world = world;
    }

    public abstract void CreateSystems();
    
    public void UpdateFeature(T t)
    {
        foreach (var system in systems)
        {
            system.Update(t);
        }
    }
}