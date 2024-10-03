using System.ComponentModel;

namespace OOP;

// Mowitz Almstedt .NET24

/*================================================
 * A geometry calculator! here we use classes with
 * methods to calculate both perimeter, area,
 * and volume based on user input.
 * There is basically endless room for scaling, adding
 * both more shapes and methods. The triangle class could
 * also be improved by adding more choices with methods.
 =================================================*/

public class Program
{
    public static void Main(string[] args)
    {
        bool mainLoop = true; //Main loop to run the program

        while (mainLoop)
        {
            Console.Clear();
            int menuChoice = ShowMenu(); //Get main menu choice

            switch (menuChoice)
            {
                case 1: //Circle
                    bool circleLoop = true; //Flag to loop the circle
                    
                    Console.Write("Radius (cm): ");
                    int radius = GetValidInput(null, null);
                    Circle circle = new Circle(radius); //Create instance of object
                    
                    while (circleLoop)
                    {
                        Console.Clear();
                        Console.WriteLine($"Radius: {radius} cm");
                        int circleChoice = CircleMenu();
                        switch (circleChoice)
                        {
                            case 1: //Calculate perimeter
                                Console.WriteLine($"Perimeter: {circle.GetPerimeter()} cm");
                                Console.ReadKey();
                                break;
                            case 2: //Calculate area
                                Console.WriteLine($"Area: {circle.GetArea()} cm2");
                                Console.ReadKey();
                                break;
                            case 3: //Calculate volume
                                Console.WriteLine($"Volume: {circle.GetVolume()} cm3");
                                Console.ReadKey();
                                break;
                            case 4: //Return
                                circleLoop = false;
                                break;
                        }
                    }
                    break;
                
                case 2: //Triangle
                    bool triangleLoop = true; //Flag to loop the triangle
                    
                    Console.Write("Base (cm): "); 
                    int tBase = GetValidInput(null, null);
                    Console.Write("Height (cm): ");
                    int tHeight = GetValidInput(null, null); 
                    Triangle triangle = new Triangle(tBase, tHeight); //Create instance of the object

                    while (triangleLoop)
                    {
                        Console.Clear();
                        Console.WriteLine($"Base: {tBase} cm");
                        Console.WriteLine($"Height: {tHeight} cm");
                        var triangleChoice = TriangleMenu();

                        switch (triangleChoice)
                        {
                            case 1: //Calculate area
                                Console.WriteLine($"Area: {triangle.GetArea()} cm");
                                Console.ReadKey();
                                break;
                            case 2: //Return
                                triangleLoop = false;
                                break;
                        }
                    }
                    break;
                
                case 3: //Exit
                    Console.WriteLine("Exiting...");
                    mainLoop = false;
                    break;
            }
        }
    }

    //Method for the main menu
    public static int ShowMenu()
    {
        Console.WriteLine("Geometry Calculator");
        Console.WriteLine("Select an option:");
        Console.WriteLine("[1] Circle");
        Console.WriteLine("[2] Triangle");
        Console.WriteLine("[3] Exit");
        Console.Write("[ ]");
        Console.SetCursorPosition(1, Console.CursorTop);

        return GetValidInput(1, 3);
    }
    
    //Method to get a valid user input
    //Both min and max are nullable allowing for a scale between numbers, but also no set values
    public static int GetValidInput(int? min, int? max)
    {
        int input;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out input) || 
                (min.HasValue && input < min.Value) ||
                (max.HasValue && input > max.Value))
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                break;
            }
        } while (true);
        return input;
    }
    
    //Method for the circle menu
    public static int CircleMenu()
    {
        Console.WriteLine("Calculate Circle:");
        Console.WriteLine("[1] Perimeter");
        Console.WriteLine("[2] Area");
        Console.WriteLine("[3] Volume");
        Console.WriteLine("[4] Return");
        Console.Write("[ ]");
        Console.SetCursorPosition(1, Console.CursorTop);
        
        return GetValidInput(1, 4);
    }

    //Method for the triangle menu
    public static int TriangleMenu()
    {
        Console.WriteLine("Calculate Triangle:");
        Console.WriteLine("[1] Area");
        Console.WriteLine("[2] Return");
        Console.Write("[ ]");
        Console.SetCursorPosition(1, Console.CursorTop);
        
        return GetValidInput(1, 2);
    }
}


