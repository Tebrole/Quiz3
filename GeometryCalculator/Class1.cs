namespace GeometryCalculator;

interface IShape
{
    public double CalculatePerimeter();
    public double CalculateArea();
}

public class Triangle : IShape
{
    private double _height;
    private double _baseValue;
    private double _side1;
    private double _side2;

    public Triangle(double height, double baseValue, double side1, double side2)
    {
        _height = height;
        _baseValue = baseValue;
        _side1 = side1;
        _side2 = side2;
    }

    public double CalculatePerimeter()
    {
        double perimeter = _baseValue + _side1 + _side2;
        return perimeter;
    }


    public double CalculateArea()
        {
            double area = _height * _baseValue / 2;
            return area;
        }
}


public class Rectangle : IShape
{
    private double _side1;
    private double _side2;

    public Rectangle(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }
    
    public double CalculatePerimeter()
    {
        double perimeter = _side1 * 2 + _side2 * 2;
        return perimeter;
    }

    public double CalculateArea()
    {
        double area = _side1 * _side2 / 2;
        return area;
    }
}

public class Trapezoid : IShape
{
    private double _upperSide; 
    private double _lowerSide;
    private double _side1;
    private double _side2;
    private double _height;

    public Trapezoid(double upperSide, double lowerSide, double height, double side1, double side2)
    {
        _upperSide = upperSide;
        _lowerSide = lowerSide;
        _height = height;
        _side1 = side1;
        _side2 = side2;
    }

    public double CalculatePerimeter()
    {
        double perimeter = _side1 + _side2 + _lowerSide + _upperSide;
        return perimeter;
    }

    public double CalculateArea()
    {
        double area = (_lowerSide + _upperSide) / 2 * _height;
        return area;
    }
}

public class Triangularprism : IShape
{
    //assuming all sides of the triangle are equal
    private double _triangleside;
    private double _prismHeight;
    private double _triangleHeight;

    public Triangularprism(double triangleside, double prismHeight, double triangleHeight)
    {
        _triangleside = triangleside;
        _prismHeight = prismHeight;
        _triangleHeight = triangleHeight;
    }


    public double CalculatePerimeter()
    {
        double basePerimeter = _triangleside * 3;
        return basePerimeter;
    }

    public double CalculateArea()
    {
        double surfaceArea = _triangleside * _triangleHeight + _prismHeight * 3 * _triangleside;
        return surfaceArea;
    }
}