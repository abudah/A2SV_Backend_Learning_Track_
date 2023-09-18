public class Program
{
	public static void Main(string[] args)
	{
		StudentList<Student> studentList = new StudentList<Student>();

		studentList.AddNewStudent(new Student{ Name = "Kena", Age = 0, RollNumber = 1 , Grade = 1 });
		studentList.AddNewStudent(new Student { Name = "cala", Age = 0, RollNumber = 2 , Grade = 1 });
		studentList.AddNewStudent(new Student { Name = "Kaba", Age = 0, RollNumber = 1 , Grade = 1 });
		studentList.AddNewStudent(new Student { Name = "kena", Age = 0, RollNumber = 3 , Grade = 1 });

		studentList.DisplayAllStudent();

	

		

		


	}		
}