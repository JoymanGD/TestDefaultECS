using UnityEngine;

public class App : MonoBehaviour
{
    [SerializeField]
    private World world;

    void Start()
    {
        world?.Init();
    }

    private void Update()
    {
        world.UpdateWorld(Time.deltaTime);
    }
}
