using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    private DefaultEcs.World ecsWorld;
    private List<AFeature<float>> features = new List<AFeature<float>>();

    public void Init()
    {
        ecsWorld = new DefaultEcs.World();
        CreateEntities();
        CreateFeatures();
    }

    private void CreateEntities()
    {
        var entities = GetComponentsInChildren<Entity>();
        
        foreach (var e in entities)
        {
            e.Init(ecsWorld);
        }
    }

    private void CreateFeatures()
    {
        //add some features
        var f = new TestFeature(ecsWorld);
        f.CreateSystems();
        features.Add(f); //add some feature
    }

    public void UpdateWorld(float deltaTime)
    {
        foreach (var feature in features)
        {
            feature.UpdateFeature(deltaTime);
        }
    }
}
