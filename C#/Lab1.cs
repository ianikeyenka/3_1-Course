namespace Lab;

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine(a.C1);
        Console.WriteLine(a.C2);
    }
}

class A
{
    private float a = 6.0f;
    private float b = 5.0f;

    public A()
    {
    }

    public A(float a, float b)
    {
        this.a = a;
        this.b = b;
    }
    
    public float C1
    {
        get
        {
            return a / b;
        }
    }

    public float C2
    {
        get
        {
            return a - b;
        }
    }
}
