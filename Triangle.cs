namespace OOP;

public class Triangle
{
    //Properties of the object
    private double B { get; set; }
    private double H { get; set; }

    //Construct to initialize object
    public Triangle(double b, double h)
    {
        this.B = b;
        this.H = h;
    }

    //Method to calculate area
    public double GetArea()
    { 
        var triangle = (B * H) / 2;
        return triangle;
    }
}