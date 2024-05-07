namespace DependencySolutions;

public class Car
{
    private Engine engine;
    public Car(Engine engine)
    {
        this.engine = engine;
    }    

    public void Start()
    {
        engine.Start();
    }
}