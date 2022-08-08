using UnityEngine;

public interface IComponent
{
    public void Init(DefaultEcs.Entity entity);
}

public abstract class BaseComponent : MonoBehaviour, IComponent
{
    protected virtual void InitInternal<T>(T t, DefaultEcs.Entity entity) where T : class
    {
        entity.Set(this as T);
    }

    public void Init(DefaultEcs.Entity entity)
    {
        InitInternal(this, entity);
    }
}