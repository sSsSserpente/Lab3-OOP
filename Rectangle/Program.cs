class Rectangle
{
    // Fields to describe the lengths of sides
    private double side1;
    private double side2;

    // Constructor to initialize the sides
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Method to calculate the area of the rectangle
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Method to calculate the perimeter of the rectangle
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Properties to get the area and perimeter
    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        // Getting input from the user
        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Creating a Rectangle object
        Rectangle rectangle = new Rectangle(side1, side2);

        // Displaying the results
        Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
        Console.WriteLine($"Area: {rectangle.Area}");
    }
}
