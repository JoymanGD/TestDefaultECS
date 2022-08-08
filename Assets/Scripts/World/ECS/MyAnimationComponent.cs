using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Animator))]
public class MyAnimationComponent : BaseComponent
{
    [FormerlySerializedAs("transform")] [SerializeField]
    public Animator animator;
    
    protected override void InitInternal<T>(T t, DefaultEcs.Entity entity)
    {
        if (animator == null)
        {
            animator = gameObject.GetComponent<Animator>();
        }
        base.InitInternal(this, entity);
    }
}