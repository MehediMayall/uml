namespace DependencySolutions;

public class Car
{
    private IEngine engine;
    public Car(IEngine engine)
    {
        this.engine = engine;
    }    

    public void Start()
    {
        engine.Start();
    }
}