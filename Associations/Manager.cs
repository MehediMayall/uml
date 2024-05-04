namespace Associations;

public class Manager
{
    private string name;
    public Manager(string name)
    {
        this.name = name;
    }

    public string Name{
        get{ return name;}
    }

    public void login(SwipeCard swipeCard)
    {
        swipeCard.swipe(this);
    }

}