public class TaskManager
{
    public List<Task> Tasks = new List<Task>();

    public void AddNewTask(Task task)
    {
        Tasks.Add(task);
    }

    public void DisplayTasks()
    {
        Console.WriteLine("Those are All Tasks in Task Manager");
        
        for(int i = 0; i < Tasks.Count ; i++)
        {
            Task task = Tasks[i];

            Console.WriteLine($"{i}, Name: {task.Name} Description: {task.Description} Category: {task.Category}.  Status: {task.IsCompleted}");
        }
    }
    public void DisplayPersonalTasks()
    {

        var PersonalTasks = Tasks.Where(task => task.Category == TaskCategory.Personal).ToList();

        Console.WriteLine("Those are Personal Tasks in Task Manager");
        
        for(int i = 0; i < PersonalTasks.Count ; i++)
        {
            Task task = PersonalTasks[i];

            Console.WriteLine($"{i}, Name: {task.Name} Description: {task.Description} Category: {task.Category}.  Status: {task.IsCompleted}");
        }
        
    }




    public void DisplayWorkTasks()
    {

        var WorkTasks = Tasks.Where(task => task.Category == TaskCategory.Work).ToList();

        Console.WriteLine("Those are Work Tasks in Task Manager");
        
        for(int i = 0; i < WorkTasks.Count ; i++)
        {
            Task task = WorkTasks[i];

            Console.WriteLine($"{i}, Name: {task.Name} Description: {task.Description} Category: {task.Category}.  Status: {task.IsCompleted}");
        }
        
    }


    public void WriteToCsv(string filepath,Task task)
    {
        using( var writer = new StreamWriter(filepath, true)){
            string line = $"{task.Name},{task.Description},{task.Category},{task.IsCompleted}";
            writer.WriteLine(line);
        }
    }

    public async void ReadCsv(string filepath)
    {
        try
        {
         using( var reader = new StreamReader(filepath))
         {
            while(!reader.EndOfStream)
            {
                string? line = await reader.ReadLineAsync();
                string[] fields = line.Split(",");
                Task task = new Task{Name = fields[0], Description = fields[1], Category= (TaskCategory)Enum.Parse(typeof(TaskCategory), fields[2]), IsCompleted = bool.Parse(fields[3])};
                Tasks.Add(task);
            }
         }   
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not Found: {filepath}");
        }
        catch(IOException ex){
            Console.WriteLine($"An IO error occured while trying to read a file: {ex.Message}");
        }
         
    }

    

     
}