namespace Compositions;

public class Car
{
    private Engine engine = new Engine();
    public void start()
    {
        engine.Start();
    }
}