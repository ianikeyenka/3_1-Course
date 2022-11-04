namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        B obj = new B(5);
        if (obj)
        {
            Console.WriteLine("True");
        } else
        {
            Console.WriteLine("False");
        }

        bool result = obj & 5;
        Console.WriteLine(result);
    }
}

class B
{
    private int value;

    public B(int value)
    {
        this.value = value;
    }

    public static bool operator true(B obj)
    {
        return obj.value >= 0;
    }

    public static bool operator false(B obj)
    {
        return obj.value < 0;
    }

    public static bool operator &(B obj, int value)
    {
        if (obj.value == value)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    
}
