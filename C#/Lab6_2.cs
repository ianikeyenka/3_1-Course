using System.Collections;

namespace lab6_2;

interface IGeometricFigure
{ 
    double Space { get; } 
    string Information();
}

public class Square : IGeometricFigure 
{ 
    private int side;
    public Square(int side) 
    { 
        this.side = side;
    }

    public int Side { get { return side; }}
    public int Perimeter { get { return 4 * side; } } 
    public double Space { get { return (side * side); } }
    public string Information() 
    { 
        return string.Format("\t\tSquare\nSide - {0}\nPerimeter - {1}\nSpace - {2}\n", side, Perimeter, Space);
    }
}

public class Circle : IGeometricFigure 
{ 
    private int radius; 
    private string color;
    
    public Circle(int radius, string color) 
    {
        this.radius = radius; 
        this.color = color;
    }
        
    public int Radius { get { return radius;} }
    
    public string Color { get { return color; } }

    public double Space { get { return Math.PI * Math.Pow(radius, 2); } } 
    public string Information() 
    { 
        return string.Format("\t\tCircle\nRadius - {0}\nColor - {1}\nSpace - {2:F3}\n", radius, color, Space);
    }
}

class ArrayOfFigures: IEnumerable
{
    IGeometricFigure[] geometricFigure;
 
    public ArrayOfFigures(params IGeometricFigure[] gf)
    {
        geometricFigure = gf;
    }
        
    IEnumerator IEnumerable.GetEnumerator()
    {
        return geometricFigure.GetEnumerator();
    }
}

public class Program 
{ 
    static void Main(string[] args)
    {
        ArrayOfFigures figure = new ArrayOfFigures(
            new Square(3),
            new Square(4),
            new Circle(3, "green"),
            new Circle(4, "blue"));
        
        foreach (IGeometricFigure value in figure) 
        { 
            Console.WriteLine(value.Information());
        }
    }
}
