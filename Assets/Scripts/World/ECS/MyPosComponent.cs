using UnityEngine;

[RequireComponent(typeof(Transform))]
public class MyPosComponent : MonoBehaviour, IComponent
{
    [SerializeField]
    public Transform transform;

    public void Init()
    {
        if (transform == null)
        {
            transform = gameObject.transform;
        }
    }
}