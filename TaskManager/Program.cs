public class Program
{
    public static void Main(string[] args)
    {
        // Create Our new Task Manager
        TaskManager taskManager = new TaskManager();

        // Populate our tasks using object initializer
        Task task1 = new Task{Name = "Task 1", Category = TaskCategory.Work, Description = "task description for task 1", IsCompleted = false};
        Task task2 = new Task{Name = "Task 2", Category = TaskCategory.Work, Description = "task description for task 1", IsCompleted = true};
        Task task3 = new Task{Name = "Task 3", Category = TaskCategory.Personal, Description = "task description for task 1", IsCompleted = false};
        Task task4 = new Task{Name = "Task 4", Category = TaskCategory.Personal, Description = "task description for task 1", IsCompleted = true};
        
        taskManager.AddNewTask(task1);
        taskManager.AddNewTask(task2);
        taskManager.AddNewTask(task3);
        taskManager.AddNewTask(task4);

        // Display Tasks according to their categories and as a whole in one
        taskManager.DisplayTasks();
        taskManager.DisplayWorkTasks();
        taskManager.DisplayPersonalTasks();

        //Write Tasks to CSV file 
        taskManager.WriteToCsv("file.csv", task1);
        taskManager.WriteToCsv("file.csv", task2);
        taskManager.WriteToCsv("file.csv", task3);
        taskManager.WriteToCsv("file.csv", task4);        

        
        //Read Tasks from CSV file 
        taskManager.ReadCsv("file.csv");

        
        taskManager.DisplayTasks();
        taskManager.DisplayWorkTasks();
        taskManager.DisplayPersonalTasks();

        //Read Tasks from wrong CSV file 
        taskManager.ReadCsv("filed.csv");
    }
}
