public class Program
{
	public static void Main(string[] args)
	{
		StudentList<Student> studentList = new StudentList<Student>();


		// Populate student list with data 
		studentList.AddNewStudent(new Student(1){ Name = "Kena", Age = 0 , Grade = 1 });
		studentList.AddNewStudent(new Student(5){ Name = "cala", Age = 0, Grade = 1 });
		studentList.AddNewStudent(new Student(3){ Name = "kena", Age = 0 , Grade = 1 });
		studentList.AddNewStudent(new Student(4){ Name = "Kaba", Age = 0 , Grade = 1 });


		// Displaying and doing some searching before serialiazation
		studentList.DisplayAllStudent();
		studentList.SearchByRollNum(1);
		studentList.SearchByName("Kena");

		// Serializing and displaying serialized content
		Console.WriteLine(studentList.SerializeStudentToJSON());
		
		// deserializing the JSON data to Student objects
		studentList.DeserializeStudentFromJSON();
		
		// Display After deserialization
		studentList.DisplayAllStudent();
		studentList.SearchByRollNum(1);
		studentList.SearchByName("Kena");

	}		
}