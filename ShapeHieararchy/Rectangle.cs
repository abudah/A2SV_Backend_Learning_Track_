public class Rectangle: Shape
{
	private Double Width;
	private Double Height;
	
	public Rectangle(String name, double width, double height)
	{
		this.Name = name;
		this.Width = width;
		this.Height = height;
	}	
	public override Double CalculateArea()
	{
		return Width * Height;
	}
}
