// Run Length Encoding //

using System;

namespace System.Linq
{
	public class Program
	{

		public static string Encode(string input)
		{
			/* 
			counter: how many consecutive letters do we have
			previous_char: holds the previous visited char
			encode: output string
			*/
			int counter = 0;
			char previous_char = '0';
			string encode = "";

			// Check if Input is not empty and doesn't contain special letters such as numbers
			if (input != "" && input.Any(char.IsDigit) != true && input.All(char.IsLetterOrDigit) != false)
			{
				/* 
				Iterate through every letter in Input and check if the visited char is equal to the previous visited char.
				Increment or reset the counter based on the outcome.
				*/
				foreach (char c in input)
				{
					if (previous_char == '0' || previous_char == c)
					{
						previous_char = c;
						counter += 1;
					}
					else if (previous_char != c)
					{
						encode = encode + counter + previous_char;
						previous_char = c;
						counter = 1;
					}
				}
				encode = encode + counter + previous_char;
				return encode;
			}
			else
			{
				return "Please Check if your String is not empty and doesn't contain any numbers or special characters.";
			}
		}

		public static void Main()
		{
			/* 
			Read an Input String from the Console.
			Example Input: aabbaaa
			The Algorithm will compress the Input into a String containing various numbers each followed by letter.
			The Number will indicate how many consecutive letters of the following letter exist in the string.
			Example Output: 2a2b3a
			*/
			Console.WriteLine("Give me your Input!");
			string input = Console.ReadLine();
			string encode = Encode(input);
			Console.WriteLine(encode);
		}

	}
}
