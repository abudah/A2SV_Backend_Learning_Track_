public class Student
{
	public string? Name { get; set; }
	public int Age { get; set; }
	public  int RollNumber { get; set; }
	public int Grade { get; set; }

	override public string ToString(){
		return $"Name: {Name}, Age: {Age}, RollNumber: {RollNumber}, Grade: {Grade}";
	}
	
}