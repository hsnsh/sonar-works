namespace SnrConsole;

public class TestClass
{
    public int Balance { get; private set; }

    public void Add(int x)
    {
        this.Balance += x;
    }

    public void Reset()
    {
        this.Balance = 0;
    }
}