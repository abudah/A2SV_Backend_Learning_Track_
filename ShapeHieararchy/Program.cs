
public class Program
{

	public static void PrintShapeArea(Shape obj)
	{
		Console.WriteLine($"{obj.Name} has an area of {obj.CalculateArea()}");		
	}

	public static void Main()
	{

		Circle circle = new Circle("circle", 4.0);
		Rectangle rectangle = new Rectangle("rectangle",4.0,5.0);
		Triangle triangle = new Triangle("triangle",4.0, 3.0);

		PrintShapeArea(circle);
		PrintShapeArea(rectangle);	
		PrintShapeArea(triangle);
	}
	
}






















