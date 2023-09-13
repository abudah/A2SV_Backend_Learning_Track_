public class Triangle: Shape
{
	private  Double Base;
	private Double Height;

	public Triangle(String name, double bas, double height)
	{
		this.Name = name;
		this.Base = bas;
		this.Height = height;
	}

	public override Double CalculateArea()
	{
		return (Base * Height)/2;
	}
}
