namespace Aggregations;

public class Manager
{
    private string name;

    // Aggregation relationship
    public List<Worker> workers = new List<Worker>();
    public Manager(string name)
    {
        this.name = name;
    }
    public string Name
    {
        get { return name; }
    }

}