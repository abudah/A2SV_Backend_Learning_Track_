using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n                  This is Student Grade Calculator  \n ");
        Console.WriteLine("Please Enter Your name and Number of Subjects You take");
    
        Console.Write("Name : ");    
        string studName = Console.ReadLine();
        Console.Write("Number of Subjects : ");
        int numSubject = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, double> record = new Dictionary<string, double>();


        for(int i = 0; i < numSubject; i++ )
        {
            bool validInput = false;

            while(!validInput)
            {
                Console.Write($"Name of Subject {i + 1} : ");
                string subName = Console.ReadLine();
                Console.Write($"Grade of Subject {i + 1} : ");
                Double subGrade = Convert.ToDouble(Console.ReadLine());


                if((subGrade >= 0) && (subGrade <= 100))
                    {
                        try
                        {
                            record.Add(subName, subGrade);
                            validInput = true;
                        }catch(ArgumentException)
                        {
                            Console.WriteLine($"A subject with {subName}  already exists.");
                        }
                    }
                else
                {
                    Console.WriteLine("Please Grade values are within a range");
                }
            }
            
            
            

        }
            Console.WriteLine("\n Here is Your Calculated Grade ");
            Console.WriteLine($" Name : {studName}");
            Console.WriteLine("\n subjects with their grades ");
            
            foreach(KeyValuePair<string, double> grade in record)
            {
                Console.WriteLine($" {grade.Key} : {grade.Value}");
            }

            Console.WriteLine();
            Console.WriteLine($"Your Calculated Average Grade is {calculateAverageGrade(record)}");
            

        


    }
    static double calculateAverageGrade(Dictionary<string, double> grades)
        {
            double totalGrade = 0.0;
            foreach(KeyValuePair<string, double> grade in grades)
            {
                totalGrade += grade.Value;
            }
            double average = totalGrade/grades.Count;

            return average;

        }
}