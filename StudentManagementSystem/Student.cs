using System.Text.Json.Serialization;
public class Student
{
	public string? Name { get; set; }
	public int Age { get; set; }
	    
	[JsonInclude]
	[JsonPropertyName("RollNumber")]
	public  readonly int RollNumber;
	public int Grade { get; set; }

	public Student(int rollNumber){
		RollNumber = rollNumber;
	}
	public void Print()
	{
		Console.WriteLine($"Name: {Name}, Age: {Age}, RollNumber: {RollNumber}, Grade: {Grade}");
	
	}
	
}