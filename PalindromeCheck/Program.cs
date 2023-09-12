using System;

class Program
{
    public static bool checkPalindrome(string input){

        int left_pointer = 0;
        int right_pointer = input.Length - 1;

        while (left_pointer <= right_pointer){
            if (input[left_pointer] != input[right_pointer])
            {
                return false;
            }
            left_pointer ++;
            right_pointer --;
        }

        return true;

    }

    static void Main()
    {
        Console.WriteLine("                   \n This Application is used to check for Palindrome          ");
        
        Console.Write("Give me the sample string : ");
        string sample_string = Console.ReadLine() ?? string.Empty;

        // remove spaces
        sample_string = sample_string.Replace(" ", "");

        // remove punctuations using regex and treat the string as a lowercase.
        List<string> punctuationList = new List<string>()
        {
            ".", ",", "?", "!", ":", ";", "\"", "'", "(", ")", "[", "]", "{", "}", "-", "--", "...",
            "/", "\\", "&", "$", "%", "#", "@", "*", "+", "-", "=", "<", ">", "_"
        };

        foreach(string c in punctuationList)
        {
            if(sample_string.Contains(c))
            {
                sample_string = sample_string.Replace(c,""); 
            }
        }
        
        // Check the palindrome

        if(checkPalindrome(sample_string.ToLower()))
        {
            Console.WriteLine("The String is Palindrome. ");
        }
        else
            Console.WriteLine("The String is not Palindrome.");

    }
}