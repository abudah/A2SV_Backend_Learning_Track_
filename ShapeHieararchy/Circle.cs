
public class Circle: Shape
{
	public static Double PI = Math.PI;
	private Double Radius;

	public Circle(String name, double radius)
	{
		this.Name = name;
		this.Radius = radius;
	}
	
	public override Double CalculateArea()
	{
		return PI * Radius * Radius;
	}
}