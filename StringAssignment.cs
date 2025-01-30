/*
//1. Write a C# program to count the number of vowels and consonants in a given string.
using System;

class VowelConsonantCounter
{
    static void Main(string[] args)
    {
        // Take user input for the string
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine().ToLower();

        // Initialize counters for vowels and consonants
        int vowelCount = 0;
        int consonantCount = 0;

        // Define the vowels
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        // Loop through each character in the string
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            bool isVowel = false;

            // Check if the character is a vowel
            for (int j = 0; j < vowels.Length; j++)
            {
                if (c == vowels[j])
                {
                    isVowel = true;
                    break;
                }
            }

            // Increment the appropriate counter
            if (isVowel)
            {
                vowelCount++;
            }
            else if (char.IsLetter(c))
            {
                consonantCount++;
            }
        }

        // Output
        Console.WriteLine("Number of vowels: "+vowelCount);
        Console.WriteLine("Number of consonants: "+consonantCount);
    }
}


//2. Write a C# program to reverse a given string without using any built-in reverse functions
using System;
class ReverseString
{
	static void Main(string[] args)
	{
		Console.Write("Enter the string: ");
		string str = Console.ReadLine();
		
		Console.Write("String is reverse :");
		
		for(int i = str.Length-1;i>=0;i--)
		{
			Console.Write(str[i]);
	     
		}
		
	}
}

//3. Write a C# program to check if a given string is a palindrome (a string that reads the same forward and backward)
using System;
class Palindrome
{
	static void Main(string[] args)
	{
		Console.Write("Enter the string: ");
		string str = Console.ReadLine();
		
		Console.Write("String is reverse :");
		string str2 = "";
		for(int i = str.Length-1;i>=0;i--)
		{
			Console.Write(str[i]);
			str2 = str2 + str[i];
			Console.WriteLine(str2);
	     
		}
		if(str == str2)
		{
			Console.WriteLine("string is a Palindrome");
		}else{
			Console.WriteLine("string is not a Palindrome");
		}
		
	}
}

//4. Write a C# program to remove all duplicate characters from a given string and return the modified string
using System;
class RemoveDuplicates
{
	static string RemoveDuplicateCharacters(string str)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < result.Length; j++)
            {
                if (str[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                result += str[i];
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        // Take user input for the string
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Remove duplicates from the string
        string result = RemoveDuplicateCharacters(input);

        // Output
        Console.WriteLine("String after removing duplicates: "+result);
    }
}


//5. Write a C# program that takes a sentence as input and returns the longest word in the sentence.
using System;
class LongestWordFinder
{
    static string FindLongestWord(string sentence)
    {
        string longestWord = "";
        string currentWord = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }

        // Check the last word in the sentence
        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }
    static void Main(string[] args)
    {
        // Take user input for the sentence
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        // Find the longest word in the sentence
        string longestWord = FindLongestWord(sentence);

        // Output the result
        Console.WriteLine("The longest word in the sentence is: "+longestWord);
    }
}


//6 Write a C# program to count how many times a given substring occurs in a string.
using System;

class SubstringOccurrences
{
	static int CountSubstringOccurrences(string mainString, string substring)
    {
        int count = 0;
        int substringLength = substring.Length;

        for (int i = 0; i <= mainString.Length - substringLength; i++)
        {
            bool isMatch = true;
            for (int j = 0; j < substringLength; j++)
            {
                if (mainString[i + j] != substring[j])
                {
                    isMatch = false;
                    break;
                }
            }
            if (isMatch)
            {
                count++;
            }
        }

        return count;
    }
    static void Main(string[] args)
    {
        // Take user input for the string and the substring
        Console.Write("Enter the main string:");
        string mainString = Console.ReadLine();

        Console.Write("Enter the substring to find:");
        string substring = Console.ReadLine();

        // Count the occurrences of the substring in the main string
        int count = CountSubstringOccurrences(mainString, substring);

        // Output
        Console.WriteLine("The substring "+substring+" occurs "+count+" times in the main string.");
    }
}


//7. Write a C# program to toggle the case of each character in a given string. Convert
//uppercase letters to lowercase and vice versa.
using System;
class ToggleCase
{
    static string ToggleCaseOfCharacters(string str)
    {
        char[] charArray = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c >= 'a' && c <= 'z')
            {
                charArray[i] = (char)(c - 'a' + 'A');
            }
            else if (c >= 'A' && c <= 'Z')
            {
                charArray[i] = (char)(c - 'A' + 'a');
            }
            else
            {
                charArray[i] = c;
            }
        }

        return new string(charArray);
    }
    static void Main(string[] args)
    {
        // Take user input for the string
        Console.Write("Enter a string:");
        string input = Console.ReadLine();

        // Toggle the case of each character in the string
        string result = ToggleCaseOfCharacters(input);

        // Output the result
        Console.WriteLine("String after toggling case: "+result);
    }
}


//8. Write a C# program to compare two strings lexicographically (dictionary order) without using built-in compare methods.
using System;
class StringComparer
{
	
    static int CompareStringsLexicographically(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                return -1;
            }
            else if (str1[i] > str2[i])
            {
                return 1;
            }
        }

        if (str1.Length < str2.Length)
        {
            return -1;
        }
        else if (str1.Length > str2.Length)
        {
            return 1;
        }

        return 0;
    }
    static void Main(string[] args)
    {
        // Take user input for the two strings
        Console.Write("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string:");
        string str2 = Console.ReadLine();

        // Compare the two strings lexicographically
        int comparisonResult = CompareStringsLexicographically(str1, str2);

        // Output
        if (comparisonResult < 0)
        {
            Console.WriteLine(str1+" comes before "+str2+" in lexicographical order.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine(str2+" comes before "+str1+" in lexicographical order.");
        }
        else
        {
            Console.WriteLine(str1+" is equal to "+str2+" in lexicographical order.");
        }
    }
}


//9. Write a C# program to find the most frequent character in a string.
using System;
class MostFrequentCharacter
{
	static char FindMostFrequentCharacter(string str)
    {
        int[] charCount = new int[256]; // Assuming ASCII characters
        int maxCount = 0;
        char mostFrequentChar = '\0';

        // Count the frequency of each character
        for (int i = 0; i < str.Length; i++)
        {
            charCount[str[i]]++;
            if (charCount[str[i]] > maxCount)
            {
                maxCount = charCount[str[i]];
                mostFrequentChar = str[i];
            }
        }

        return mostFrequentChar;
    }
    static void Main(string[] args)
    {
        // Take user input for the string
        Console.Write("Enter a string:");
        string input = Console.ReadLine();

        // Find the most frequent character in the string
        char mostFrequentChar = FindMostFrequentCharacter(input);

        // Output
        Console.WriteLine("The most frequent character in the string is: "+mostFrequentChar);
    }
}

//10. Write a C# program to remove all occurrences of a specific character from a string.
using System;

class RemoveSpecificCharacter
{
	
    static string RemoveCharacter(string str, char charToRemove)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != charToRemove)
            {
                result += str[i];
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        // Take user input for the string
        Console.Write("Enter a string:");
        string input = Console.ReadLine();

        // Take user input for the character to remove
        Console.Write("Enter the character to remove:");
        char charToRemove = Console.ReadLine()[0];

        // Remove the specific character from the string
        string result = RemoveCharacter(input, charToRemove);

        // Output
        Console.WriteLine("Modified string: "+result);
    }
}

//11.  Accepts two strings from the user and checks if the two strings are anagrams of each other
 using System;

class AnagramChecker
{
	
    static bool AreAnagrams(string str1, string str2)
    {
        // If the lengths of the strings are not equal, they cannot be anagrams
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Convert the strings to character arrays
        char[] charArray1 = new char[str1.Length];
        char[] charArray2 = new char[str2.Length];

        for (int i = 0; i < str1.Length; i++)
        {
            charArray1[i] = str1[i];
            charArray2[i] = str2[i];
        }

        // Sort the character arrays
        for (int i = 0; i < charArray1.Length - 1; i++)
        {
            for (int j = i + 1; j < charArray1.Length; j++)
            {
                if (charArray1[i] > charArray1[j])
                {
                    char temp = charArray1[i];
                    charArray1[i] = charArray1[j];
                    charArray1[j] = temp;
                }
                if (charArray2[i] > charArray2[j])
                {
                    char temp = charArray2[i];
                    charArray2[i] = charArray2[j];
                    charArray2[j] = temp;
                }
            }
        }

        // Compare the sorted character arrays
        for (int i = 0; i < charArray1.Length; i++)
        {
            if (charArray1[i] != charArray2[i])
            {
                return false;
            }
        }

        return true;
    }
    static void Main(string[] args)
    {
        // Take user input for the two strings
        Console.Write("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string:");
        string str2 = Console.ReadLine();

        // Check if the two strings are anagrams
        bool areAnagrams = AreAnagrams(str1, str2);

        // Output
        if (areAnagrams)
        {
            Console.WriteLine(str1+" and "+str2+" are anagrams.");
        }
        else
        {
            Console.WriteLine(str1+" and "+str2+" are not anagrams.");
        }
    }
}


//12. Write a replace method in C# that replaces a given word with another word in a sentence
using System;
class WordReplacer
{	
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        string currentWord = "";
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i];
            }
            else
            {
                if (currentWord == oldWord)
                {
                    result += newWord + " ";
                }
                else
                {
                    result += currentWord + " ";
                }
                currentWord = "";
            }
        }

        // Check the last word in the sentence
        if (currentWord == oldWord)
        {
            result += newWord;
        }
        else
        {
            result += currentWord;
        }

        return result;
    }
    static void Main(string[] args)
    {
        // Take user input for the sentence
        Console.Write("Enter a sentence:");
        string sentence = Console.ReadLine();

        // Take user input for the word to replace
        Console.Write("Enter the word to replace:");
        string oldWord = Console.ReadLine();

        // Take user input for the new word
        Console.Write("Enter the new word:");
        string newWord = Console.ReadLine();

        // Replace the word in the sentence
        string result = ReplaceWord(sentence, oldWord, newWord);

        // Output
        Console.WriteLine("Modified sentence: "+result);
    }
}
*/