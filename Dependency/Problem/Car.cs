namespace DependencyProblem;

public class Car
{
    private CombustionEngine engine;
    public Car(CombustionEngine engine)
    {
        this.engine = engine;
    }    

    public void Start()
    {
        engine.Start();
    }
}