using System;
using System.Text.RegularExpressions;

namespace  WordFrequencyCount
{
	class Program
	{
		public static Dictionary<string, int>  getFrequencyDictionary(string sample)
		{	
			string[] substrings = sample.Split(" ");

			Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

			foreach (string word in substrings)
			{
				if (wordFrequency.ContainsKey(word))
				{
					wordFrequency[word] += 1;
				}
				else
				{
					wordFrequency[word] = 1;
				}
			}
			
			return wordFrequency;

		}

		static void Main()
		{
			Console.WriteLine("\n           Well come to Word Frequency Counter   ");
	
			Console.Write("Give me the Input : ");
			string input = Console.ReadLine() ?? string.Empty;

			string pattern = @"\p{P}";
			string result = Regex.Replace(input, pattern, "").ToLower();

			Console.WriteLine("\n Here is the Word Frequency List");
			foreach (KeyValuePair<string, int> kvp in getFrequencyDictionary(result))
			{
				Console.WriteLine($"{kvp.Key} : {kvp.Value}");
			}

		}
	}	
}