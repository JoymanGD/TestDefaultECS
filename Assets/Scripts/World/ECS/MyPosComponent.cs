using UnityEngine;

[RequireComponent(typeof(Transform))]
public class MyPosComponent : BaseComponent
{
    [SerializeField]
    public Transform transform;
    
    protected override void InitInternal<T>(T t, DefaultEcs.Entity entity)
    {
        if (transform == null)
        {
            transform = gameObject.transform;
        }
        base.InitInternal(this, entity);
    }

}