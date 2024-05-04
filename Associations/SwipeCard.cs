namespace Associations;

public class SwipeCard
{
    private string cardNo;
    public SwipeCard(string CardNo)
    {
        this.cardNo = CardNo;
    }
    public string CardNo
    {
        get { return this.CardNo;}
    }

    public void swipe(Manager manager)
    {
        System.Console.WriteLine($"{this.cardNo} is verified. Thank you, {manager.Name}");
    }
}