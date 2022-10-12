namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        B obj1 = new B(3.6f,7.3f,2.4f);
        B obj2 = new B(2.4f);
        A obj3 = new A();
        A obj4 = new A(3.6f, 7.3f);
        Console.WriteLine(obj1.C1);
        Console.WriteLine(obj1.C2);
        Console.WriteLine(obj1.C3);
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

class B: A
{
    private float d;

    public B(float d)
    {
        this.d = d;
    }

    public B(float a, float b, float d) : base(a, b)
    {
        this.d = d;
    }

    public float C3
    {
        get
        {
            float value = C1;
            if(C1 != C2) value = d; return value;
        }
    }
}
