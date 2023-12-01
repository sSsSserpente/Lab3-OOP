// Class representing a point with two numeric fields and one string fieldd
class Point
{
    private double x;
    private double y;
    private string name;

    // Constructor to initialize the fields with arguments
    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    // Properties to get the values of x, y, and name
    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

// Class representing a figure with constructors taking 3 to 5 Point arguments
class Figure
{
    private Point[] points;

    // Constructor to initialize points array with variable number of Point arguments
    public Figure(params Point[] points)
    {
        // Ensure at least 3 points are provided
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("A figure must have 3 to 5 points.");
        }

        this.points = points;
    }

    // Method to calculate the length of a side between two points
    private double GetSideLength(Point A, Point B)
    {
        double sideLength = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        return sideLength;
    }

    // Method to calculate the perimeter of the figure
    public void CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }

        // Closing the figure by adding the last side
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Perimeter of the figure: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        // Creating points for the figure
        Point pointA = new Point(0, 0, "A");
        Point pointB = new Point(0, 4, "B");
        Point pointC = new Point(3, 0, "C");

        // Creating a figure with three points
        Figure triangle = new Figure(pointA, pointB, pointC);

        // Calculating and displaying the perimeter of the figure
        triangle.CalculatePerimeter();
    }
}
