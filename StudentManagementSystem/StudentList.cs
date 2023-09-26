
using System.Text.Json;

public class StudentList<T> : List<Student>

{
	private List<T> students;

	
	public StudentList()
	{
		students = new List<T>();
	}

	public void AddNewStudent(T student)
	{
		students.Add(student);
	}


	// Using LINQ Queries Implement search functionality using Name of the student and ID.
	public void SearchByName(string name)
	{
		var st = students.OfType<Student>().Where(student => student.Name == name);;

		Console.WriteLine("Searching by Name...");

		if(!st.Any())
			Console.WriteLine("No Students found by this name");
		else
		
		Console.WriteLine("Those are the search results");
			foreach (Student? student in st)
			{
				student.Print();
			}
	}
		
	public void SearchByRollNum(int rollNumber)
	{
		var st = students.OfType<Student>().Where(student => student.RollNumber == rollNumber);
		Console.WriteLine("Searching by roll number...");
		if(!st.Any())
			Console.WriteLine("No Students found by this name");
		else	
			Console.WriteLine("Those are the search results");
			foreach (Student? student in st)
			{
				student.Print();
			}
	}

	// Display all students in our list.
	public void DisplayAllStudent()
	{
		Console.WriteLine("Displaying All students Data...");

		var st = students.OfType<Student>();
		if(!st.Any())
			Console.WriteLine("No Students found by this name");
		else	
			foreach (Student student in st)
			{
				student.Print();
			}
	}


	// Serialize the student data to store it into JSON Format into a file.
	public string  SerializeStudentToJSON()
	{
		// serializing....
		string SerializeStudentToJSON = JsonSerializer.Serialize(students); 
		File.WriteAllText("data.json", SerializeStudentToJSON);
		return JsonSerializer.Serialize(students);

	}

	// Deserialize the JSON data into the objects.

	public void DeserializeStudentFromJSON()
	{
		// Deserializing....	
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			IncludeFields  = true,
		};
		string? serializedData = File.ReadAllText("data.json");
		students = JsonSerializer.Deserialize<List<T>>(serializedData, options) ?? students;
	}

}