using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
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

	public void SearchByName(string name)
	{
		var st = students.Where(student => student is Student && ((Student)(object)student).Name == name).ToList();

		Console.WriteLine("Searching by Name...");
		Console.WriteLine("Those are the search results");

		foreach (T? student in st)
		{
			student?.ToString();
		}
	}

	public void SearchByRollNum(int rollNumber)
	{
		var st = students.Where(student => student is Student && ((Student)(object)student).RollNumber == rollNumber);
		Console.WriteLine("Searching by roll number...");
		Console.WriteLine("Those are the search results ");

		foreach (T? student in  st)
		{
			student?.ToString();
		}
	}

	public void DisplayAllStudent()
	{
		foreach (T? student in  students)
		{
			student?.ToString();
		}
	}

	public string  SerializeStudentToJSON()
	{
		// serializing....
		return JsonSerializer.Serialize(students);
		// string SerializeStudentToJSON = 
		// File.WriteAllText("data.json", SerializeStudentToJSON);
	}

	public void DeserializeStudentFromJSON(string jsonString)
	{
		// Deserializing....	
		// string serializedData = File.ReadAllText("data.json");
		students? = JsonSerializer.Deserialize<List<T>>(jsonString);
		Console.WriteLine(students?);
	}

}