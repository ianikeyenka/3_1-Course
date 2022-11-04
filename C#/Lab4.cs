namespace lab4;

class Program
{
    static void Main(string[] args)
    {
        B objB = new B(new int[] {2, 3, 6});
        for (int i = 0; i < objB.A1.Length; i++)
        {
            Console.WriteLine(objB[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < objB.A2.GetLength(0); i++)
        {
            for (int j = 0; j < objB.A2.GetLength(1); j++)
            {
                Console.WriteLine(objB[i, j]);    
            }
        }
        C<string>.value = "string";
        C<int>.value = "int";
        Console.WriteLine("\n" + C<string>.value + "\t" + C<int>.value);
    }
}

class B
{
    private int[] firstArray;
    private int[,] secondArray = { {1, 2}, {3, 4}};

    public B()
    {
    }

    public B(int[] firstArray)
    {
        this.firstArray = firstArray;
    }

    public int this[int ind1]
    {
        get { return firstArray[ind1]; }
        set { firstArray[ind1] = value; }
    }
    
    public int this[int ind1, int ind2]
    {
        get { return secondArray[ind1, ind2]; }
        set { secondArray[ind1, ind2] = value; }
    }

    public int[] A1
    {
        get { return firstArray; }
    }
    
    public int[,] A2
    {
        get { return secondArray; }
    }
}

public class C<T>
{
    public static string value;
}
