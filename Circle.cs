namespace OOP;

//Circle class to represent a circle with a specific radius
public class Circle
{
    //Properties of the object
    private double Radius { get; set; }

    //Constructor to initialize the circle
    public Circle(double radius)
    {
        this.Radius = radius; //Refers to the value of the current instance of radius when the object is created
    }

    //Method to calculate the perimeter
    public double GetPerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    //Method to calculate the area of the circle
    public double GetArea() //Cm2
    {
        return Math.Round((Math.PI * Math.Pow(this.Radius, 2)), 2);
    }

    //Method for calculating the volume if the circle was a sphere
    public double GetVolume() //Cm3
    {
        return Math.Round((Math.Pow(Radius, 3) * Math.PI * 4) / 3, 2);
    }
}