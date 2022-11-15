namespace SnrConsole;

public class TestClass
{
    public decimal Balance { get; private set; }

    public void Add(decimal x)
    {
        this.Balance += x;
    }

    public void Reset()
    {
        this.Balance = 0;
    }

    public void Subtract(decimal x)
    {
        this.Balance -= x;
    }

    public void Pow(decimal x)
    {
        this.Balance *= x;
    }

    public void Div(decimal x)
    {
        this.Balance /= x;
    }
}