using System.Collections;

namespace lab6_2;

interface GeometricFigure
{ 
    double Space { get; } 
    string Information();
}

public class Square : GeometricFigure 
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

public class Circle : GeometricFigure 
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

class ArrayOfFigures : IEnumerable 
{ 
    private string[] geometricFigure;
    
    public ArrayOfFigures(string[] geometricFigure) 
    { 
        this.geometricFigure = geometricFigure;
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
        Square sqare1 = new Square(3); 
        Square sqare2 = new Square(4);
        Circle circle1 = new Circle(3, "green"); 
        Circle circle2 = new Circle(4, "blue");
        string[] informFigure = 
        { 
            sqare1.Information(), 
            sqare2.Information(), 
            circle1.Information(), 
            circle2.Information(),
        };
        ArrayOfFigures array = new ArrayOfFigures(informFigure); 
        foreach (string value in informFigure) 
        { 
            Console.WriteLine(value);
        }
    }
}
