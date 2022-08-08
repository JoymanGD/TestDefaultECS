public class TestFeature : AFeature<float>
{
    public TestFeature(DefaultEcs.World world) : base(world){}

    public override void CreateSystems()
    {
        systems.Add(new TestSystem(world));
    }
}