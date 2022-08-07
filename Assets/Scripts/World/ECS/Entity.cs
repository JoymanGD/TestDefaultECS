using System.Reflection;
using UnityEngine;

public class Entity : MonoBehaviour
{
    private static MethodInfo method;

    public void Init(DefaultEcs.World world)
    {
        var entity = world.CreateEntity();

        var components = GetComponents<Component>();

        foreach (var c in components)
        {
            //skip entity component
            if(c == this)
            {
                continue;
            }

            if(method == null)
            {
                method = typeof(Entity).GetMethod("SetComponent");
            }

            method.MakeGenericMethod(c.GetType()).Invoke(null, new object[] { c, entity });
        }
    }

    public static void SetComponent<T>(in T component, DefaultEcs.Entity entity)
    {
        entity.Set<T>(component);
    }
}