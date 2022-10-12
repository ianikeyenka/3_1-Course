namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        B objB = new B(8.0f);
        foreach (var array in objB.Arr)
        {
            Console.WriteLine(array);
        }
    }
}

class A
{
    private float a;
    private float b;

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
    private float[] arr;

    public B(float d, float[] arr)
    {
        this.d = d; 
        this.arr = arr;
    }
    
    public B(float a, float b, float d) : base(a, b)
    {
        this.d = d;
    }

    public B(float a) : this(a, 5.0f, 3.0f) 
    {
        arr = new float[Convert.ToInt32(a)];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = C3 * i;
        }
    }

    public float[] Arr
    {
        get
        {
            return arr;
        }
    }

    public float C3
    {
        get
        {
            float value = C2;
            if(C1 != C2) value = d; return value;
        }
    }
}
