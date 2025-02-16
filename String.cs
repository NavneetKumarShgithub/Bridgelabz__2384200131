/*
//1. StringBuilder Problem 1: Reverse a String Using StringBuilder
using System;
using System.Text;
class Reverse
{
    static void Main(string[] args)
    {
        Console.Write("Enter Any String : ");
        string str = Console.ReadLine();
        StringBuilder sb = new StringBuilder(str);
        Console.Write("Reverse the input String: ");
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            Console.Write(sb[i]);
        } 
        Console.ReadKey();
    }
}


//2. StringBuilder Problem 2: Remove Duplicates from a String Using StringBuilder
using System;
using System.Text;

public class RemoveDuplicates
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        bool[] seen = new bool[256]; // Assuming ASCII characters

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (!seen[c])
            {
                sb.Append(c);
                seen[c] = true;
            }
        }

        string result = sb.ToString();
        Console.WriteLine("String without duplicates: " + result);
        Console.ReadKey();
    }
}


//3. Concatenate Strings Efficiently Using StringBuilder
using System;
using System.Text;

public class ConcatenateStrings
{
    public static void Main(string[] args)
    {
        // enteer string by user
        Console.WriteLine("Enter the number of strings: ");
        int numberOfStrings = int.Parse(Console.ReadLine());

        // Initialize a string array 
        string[] stringArray = new string[numberOfStrings];

        // Read each string from the user
        for (int i = 0; i < numberOfStrings; i++)
        {
            Console.WriteLine("Enter string " + (i + 1) + ": ");
            stringArray[i] = Console.ReadLine();
        }

        // Initialize a StringBuilder object
        StringBuilder sb = new StringBuilder();

        // Loop through each string in the array
        foreach (string str in stringArray)
        {
            // Append each string to the StringBuilder
            sb.Append(str);
        }

        // Convert the StringBuilder to a string
        string result = sb.ToString();

        // Print the concatenated string
        Console.WriteLine("Concatenated string: " + result);
        Console.ReadKey();
    }
}



//4. Compare StringBuilder Performance
using System;
using System.Diagnostics;
using System.Text;

public class ComparePerformance
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of iterations
        Console.WriteLine("Enter the number of iterations: ");
        int iterations = int.Parse(Console.ReadLine());

        // Prompt the user to enter the sample text
        Console.WriteLine("Enter the sample text to concatenate: ");
        string sampleText = Console.ReadLine();

        // Measure performance of string concatenation using '+'
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        string result1 = string.Empty;
        for (int i = 0; i < iterations; i++)
        {
            result1 += sampleText;
        }
        stopwatch1.Stop();
        long elapsed1 = stopwatch1.ElapsedMilliseconds;

        // Measure performance of string concatenation using StringBuilder
        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append(sampleText);
        }
        string result2 = sb.ToString();
        stopwatch2.Stop();
        long elapsed2 = stopwatch2.ElapsedMilliseconds;

        // Print the results
        Console.WriteLine("Time taken with string concatenation using '+': " + elapsed1 + " ms");
        Console.WriteLine("Time taken with StringBuilder: " + elapsed2 + " ms");
        Console.ReadKey();
    }
}


//5.  Read a File Line by Line Using StreamReader
using System;
using System.IO;

public class ReadFileLineByLine
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the file path
        Console.WriteLine("Enter the path to the file: ");
        string filePath = Console.ReadLine();

        // Check if the file exists
        if (File.Exists(filePath))
        {
            try
            {
                // Open the file using StreamReader
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    // Read the file line by line
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Print each line to the console
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                // Handle any I/O errors
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
            Console.ReadKey();
        }
    }
}



//6. Count the Occurrence of a Word in a File Using StreamReader
using System;
using System.IO;

public class CountWordOccurrences
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the file path
        Console.WriteLine("Enter the path to the file: ");
        string filePath = Console.ReadLine();

        // Prompt the user to enter the word to count
        Console.WriteLine("Enter the word to count: ");
        string wordToCount = Console.ReadLine();

        int wordCount = 0;

        // Check if the file exists
        if (File.Exists(filePath))
        {
            try
            {
                // Open the file using StreamReader
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    // Read the file line by line
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Split the line into words using a simple space character
                        string[] words = line.Split(' ');

                        // Count the occurrences of the word in the line
                        foreach (string word in words)
                        {
                            // Trim any leading or trailing white space from the word
                            string trimmedWord = word.Trim();

                            if (trimmedWord.Equals(wordToCount, StringComparison.OrdinalIgnoreCase))
                            {
                                wordCount++;
                            }
                        }
                    }
                }

                // Print the total count of the word
                Console.WriteLine($"The word '{wordToCount}' appears {wordCount} times in the file.");
            }
            catch (IOException e)
            {
                // Handle any I/O errors
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
            Console.ReadKey();
        }
    }
}


//7. Convert Byte Stream to Character Stream Using StreamReader
using System;
using System.IO;
using System.Text;

public class ConvertByteStream
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the file path
        Console.WriteLine("Enter the path to the file: ");
        string filePath = Console.ReadLine();

        // Prompt the user to enter the encoding to use
        Console.WriteLine("Enter the encoding (e.g., UTF-8, ASCII): ");
        string encodingName = Console.ReadLine();
        Encoding encoding = Encoding.GetEncoding(encodingName);

        // Check if the file exists
        if (File.Exists(filePath))
        {
            try
            {
                // Open the file using FileStream
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // Create a StreamReader with the specified encoding
                    using (StreamReader sr = new StreamReader(fs, encoding))
                    {
                        string line;
                        // Read the file line by line
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Print each line to the console
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                // Handle any I/O errors
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
            Console.ReadKey();
        }
    }
}



//8. Read User Input and Write to File Using StreamReader
using System;
using System.IO;

public class WriteToFile
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the file path
        Console.WriteLine("Enter the path to the file where you want to write: ");
        string filePath = Console.ReadLine();

        // Open the file using StreamWriter
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                string input;
                Console.WriteLine("Enter text (type 'exit' to finish): ");

                // Read user input until 'exit' is entered
                while (!(input = Console.ReadLine()).Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    // Write the input to the file
                    sw.WriteLine(input);
                }
            }

            Console.WriteLine("User input has been written to the file successfully.");
        }
        catch (IOException e)
        {
            // Handle any I/O errors
            Console.WriteLine("An error occurred: " + e.Message);
            Console.ReadKey();
        }
    }
}


// Linear Search
//1. Search for the First Negative number
using System;

public class LinearSearchFirstNegative
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of elements in the array
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // Read the array elements from the user
        Console.Write("Enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // Perform linear search to find the first negative number
        int firstNegativeIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegativeIndex = i;
                break;
            }
        }

        if (firstNegativeIndex != -1)
        {
            Console.WriteLine("The first negative number is " + array[firstNegativeIndex] + " at index " + firstNegativeIndex);
        }
        else
        {
            Console.WriteLine("There are no negative numbers in the array.");
            Console.ReadKey();
        }
    }
}


//2. Search for a specific word in a list of a sentences
using System;
using System.Linq;

public class LinearSearchSpecificWord
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of sentences
        Console.WriteLine("Enter the number of sentences: ");
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];

        // Read the sentences from the user
        Console.WriteLine("Enter the sentences: ");
        for (int i = 0; i < n; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        // Prompt the user to enter the word to search for
        Console.WriteLine("Enter the word to search for: ");
        string wordToSearch = Console.ReadLine();

        // Perform linear search to find the first sentence containing the specific word
        int sentenceIndex = -1;
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(wordToSearch, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                sentenceIndex = i;
                break;
            }
        }

        if (sentenceIndex != -1)
        {
            Console.WriteLine("The first sentence containing the word '" + wordToSearch + "' is: " + sentences[sentenceIndex]);
        }
        else
        {
            Console.WriteLine("No sentence contains the word '" + wordToSearch + "'.");
        }
        Console.ReadKey();
    }
}


// Binary Search
//1. Find the rotation point in a rotated sorted array
using System;

public class FindRotationPoint
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of elements in the array
        Console.WriteLine("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // Read the array elements from the user
        Console.WriteLine("Enter the elements of the rotated sorted array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int rotationPointIndex = FindRotationPointIndex(array);

        if (rotationPointIndex != -1)
        {
            Console.WriteLine("The smallest element is at index: " + rotationPointIndex);
        }
        else
        {
            Console.WriteLine("The array is not rotated.");
        }
    }


    public static int FindRotationPointIndex(int[] array)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (array[mid] > array[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
        
    }
}


//2. Find the peek element in an array
using System;

public class FindPeakElement
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of elements in the array
        Console.WriteLine("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // Read the array elements from the user
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int peakIndex = FindPeak(array);

        if (peakIndex != -1)
        {
            Console.WriteLine("A peak element is " + array[peakIndex] + " at index " + peakIndex);
        }
        else
        {
            Console.WriteLine("No peak element found.");
        }
    }

    public static int FindPeak(int[] array)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (array[mid] < array[mid + 1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }
}


//3. Search for the target value in a 2D sorted matrix
using System;

public class Search2DMatrix
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of rows and columns
        Console.WriteLine("Enter the number of rows in the matrix: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns in the matrix: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        // Read the matrix elements from the user
        Console.WriteLine("Enter the elements of the matrix row by row: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Prompt the user to enter the target value
        Console.WriteLine("Enter the target value to search for: ");
        int target = int.Parse(Console.ReadLine());

        bool found = SearchMatrix(matrix, target);

        if (found)
        {
            Console.WriteLine("The target value " + target + " is found in the matrix.");
        }
        else
        {
            Console.WriteLine("The target value " + target + " is not found in the matrix.");
        }
    }

    public static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int low = 0;
        int high = rows * columns - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int midElement = matrix[mid / columns, mid % columns];

            if (midElement == target)
            {
                return true;
            }
            else if (midElement < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return false;
        Console.ReadKey();
    }
}


//4. Find the First and Last Occurrence of an Element in a Sorted array
using System;
public class FindFirstAndLastOccurrence
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of elements in the array
        Console.WriteLine("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // Read the array elements from the user
        Console.WriteLine("Enter the elements of the sorted array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // Prompt the user to enter the target element
        Console.WriteLine("Enter the target element to search for: ");
        int target = int.Parse(Console.ReadLine());

        int firstOccurrence = FindFirstOccurrence(array, target);
        int lastOccurrence = FindLastOccurrence(array, target);

        if (firstOccurrence != -1 && lastOccurrence != -1)
        {
            Console.WriteLine($"The first occurrence of {target} is at index {firstOccurrence}.");
            Console.WriteLine($"The last occurrence of {target} is at index {lastOccurrence}.");
        }
        else
        {
            Console.WriteLine($"The target element {target} is not present in the array.");
        }
    }

    public static int FindFirstOccurrence(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (array[mid] == target)
            {
                result = mid;
                high = mid - 1; // Look for earlier occurrences
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }

    public static int FindLastOccurrence(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (array[mid] == target)
            {
                result = mid;
                low = mid + 1; // Look for later occurrences
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }
}


//5. Linear Search for the first missing positive integer And Binary Search for the target index
using System;
using System.Collections.Generic;
public class SearchProgram
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter the list of integers
        Console.WriteLine("Enter the number of elements in the list: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // Read the list elements from the user
        Console.WriteLine("Enter the elements of the list: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // Find the first missing positive integer
        int missingPositive = FindFirstMissingPositive(array);
        Console.WriteLine("The first missing positive integer is: " + missingPositive);

        // Prompt the user to enter the target element
        Console.WriteLine("Enter the target element to search for: ");
        int target = int.Parse(Console.ReadLine());

        // Sort the array for binary search
        Array.Sort(array);

        // Find the index of the target element using binary search
        int targetIndex = BinarySearch(array, target);

        if (targetIndex != -1)
        {
            Console.WriteLine("The target element " + target + " is at index " + targetIndex);
        }
        else
        {
            Console.WriteLine("The target element " + target + " is not present in the array.");
        }
    }

    public static int FindFirstMissingPositive(int[] array)
    {
        int n = array.Length;
        bool[] visited = new bool[n + 1];

        // Mark the visited numbers in the array
        for (int i = 0; i < n; i++)
        {
            if (array[i] > 0 && array[i] <= n)
            {
                visited[array[i]] = true;
            }
        }

        // Find the first missing positive integer
        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                return i;
            }
        }

        return n + 1;
    }

    public static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
}
*/
