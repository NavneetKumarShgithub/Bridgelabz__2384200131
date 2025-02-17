
/*
//1.  Search a Target in a Large Dataset
using System;
using System.Diagnostics;
using System.Linq;

public class SearchComparison
{
    public static void Main(string[] args)
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        int target = -1; // Assuming the target is not in the datasets for performance comparison

        foreach (int size in datasetSizes)
        {
            int[] dataset = GenerateDataset(size);

            // Linear Search
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            LinearSearch(dataset, target);
            stopwatch.Stop();
            Console.WriteLine($"Linear Search - Dataset Size: {size}, Time: {stopwatch.ElapsedMilliseconds} ms");

            // Binary Search
            stopwatch.Restart();
            Array.Sort(dataset);
            BinarySearch(dataset, target);
            stopwatch.Stop();
            Console.WriteLine($"Binary Search - Dataset Size: {size}, Time: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine();
        }
    }

    public static int[] GenerateDataset(int size)
    {
        Random random = new Random();
        return Enumerable.Range(0, size).Select(_ => random.Next()).ToArray();
    }

    public static bool LinearSearch(int[] array, int target)
    {
        foreach (int num in array)
        {
            if (num == target)
            {
                return true;
            }
        }
        return false;
    }

    public static bool BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (array[mid] == target)
            {
                return true;
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
            Console.ReadKey();
        }

        return false;
    }
}


//2.  Sorting Large Data Efficiently
using System;
using System.Diagnostics;

class SortingAlgorithms
{
    // Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort
    static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        // Split the array into two halves
        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        // Recursively sort both halves
        MergeSort(left);
        MergeSort(right);

        // Merge the sorted halves
        Merge(arr, left, right);
    }

    static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k++] = left[i++];
            }
            else
            {
                arr[k++] = right[j++];
            }
        }

        // Copy remaining elements of left and right arrays
        while (i < left.Length)
        {
            arr[k++] = left[i++];
        }
        while (j < right.Length)
        {
            arr[k++] = right[j++];
        }
    }

    // Quick Sort
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high); // Partitioning index
            QuickSort(arr, low, pi - 1);  // Sort left partition
            QuickSort(arr, pi + 1, high); // Sort right partition
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Pivot element
        int i = low - 1; // Index of smaller element

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                // Swap
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Swap pivot element
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    // Generate a random array
    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 100000); // Random numbers between 1 and 100,000
        }
        return arr;
    }

    // Benchmark sorting algorithms
    static void BenchmarkSorting(int[] arr, string algorithm)
    {
        int[] arrCopy = new int[arr.Length];
        Array.Copy(arr, arrCopy, arr.Length);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        switch (algorithm)
        {
            case "BubbleSort":
                BubbleSort(arrCopy);
                break;
            case "MergeSort":
                MergeSort(arrCopy);
                break;
            case "QuickSort":
                QuickSort(arrCopy, 0, arrCopy.Length - 1);
                break;
            default:
                throw new ArgumentException("Invalid algorithm name");
        }

        stopwatch.Stop();
        Console.WriteLine($"{algorithm} took {stopwatch.ElapsedMilliseconds} ms");
    }

    static void Main(string[] args)
    {
        int[] sizes = { 1000, 10000, 1000000 }; // Dataset sizes

        foreach (int size in sizes)
        {
            Console.WriteLine($"\nDataset Size: {size}");
            int[] arr = GenerateRandomArray(size);

            if (size <= 10000) // Skip Bubble Sort for large datasets
            {
                BenchmarkSorting(arr, "BubbleSort");
            }
            BenchmarkSorting(arr, "MergeSort");
            BenchmarkSorting(arr, "QuickSort");
            Console.ReadLine();
        }
    }
}


//3.  String Concatenation Performance
using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int N = 1000000; // Number of concatenations
        string baseString = "a"; // Base string to concatenate

        // Measure performance of string concatenation
        Stopwatch sw = Stopwatch.StartNew();
        string resultString = "";
        for (int i = 0; i < N; i++)
        {
            resultString += baseString; // Creates a new string object each time
        }
        sw.Stop();
        Console.WriteLine($"String concatenation took: {sw.ElapsedMilliseconds} ms");
        // Expected output: String concatenation took: [very high number, e.g., 30000+ ms]

        // Measure performance of StringBuilder
        sw.Restart();
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            stringBuilder.Append(baseString); // Appends to the same mutable object
        }
        string resultStringBuilder = stringBuilder.ToString();
        sw.Stop();
        Console.WriteLine($"StringBuilder concatenation took: {sw.ElapsedMilliseconds} ms");
        // Expected output: StringBuilder concatenation took: [low number, e.g., 10-50 ms]

        // Measure performance of StringBuffer (simulated with StringBuilder and thread safety)
        sw.Restart();
        StringBuilder stringBuffer = new StringBuilder();
        object lockObject = new object(); // For thread safety
        for (int i = 0; i < N; i++)
        {
            lock (lockObject) // Simulate thread safety
            {
                stringBuffer.Append(baseString);
            }
        }
        string resultStringBuffer = stringBuffer.ToString();
        sw.Stop();
        Console.WriteLine($"StringBuffer (simulated) concatenation took: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine();
        Console.ReadLine();
        // Expected output: StringBuffer (simulated) concatenation took: [slightly higher than StringBuilder, e.g., 20-100 ms]
    }
}




//4.  Large File Reading Efficiency
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Prompt user for file path
        Console.Write("Enter the file path (e.g., largefile.txt): ");
        string filePath = Console.ReadLine();

        // Prompt user for file size in MB
        Console.Write("Enter the file size in MB (e.g., 500): ");
        if (!int.TryParse(Console.ReadLine(), out int fileSizeMB) || fileSizeMB <= 0)
        {
            Console.WriteLine("Invalid file size. Please enter a positive integer.");
            return;
        }

        // Create the large file if it doesn't exist
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File '{filePath}' does not exist. Creating a {fileSizeMB}MB file...");
            CreateLargeFile(filePath, fileSizeMB);
        }
        else
        {
            Console.WriteLine($"Using existing file: {filePath}");
        }

        Console.WriteLine("Starting performance comparison...");

        // Measure performance of StreamReader
        Stopwatch sw = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null) // Read line by line
            {
                // Do nothing, just read
            }
        }
        sw.Stop();
        Console.WriteLine($"StreamReader took: {sw.ElapsedMilliseconds} ms");

        // Measure performance of FileStream
        sw.Restart();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            int bytesRead;
            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                // Convert bytes to string (if needed)
                string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        Console.WriteLine($"FileStream took: {sw.ElapsedMilliseconds} ms");

        // Clean up (optional)
        Console.Write("Do you want to delete the test file? (y/n): ");
        string deleteChoice = Console.ReadLine();
        if (deleteChoice?.ToLower() == "y")
        {
            File.Delete(filePath);
            Console.WriteLine("File deleted.");
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static void CreateLargeFile(string filePath, int sizeMB)
    {
        Console.WriteLine($"Creating a {sizeMB}MB file...");
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            byte[] data = new byte[1024 * 1024]; // 1MB of data
            Random rng = new Random();
            for (int i = 0; i < sizeMB; i++)
            {
                rng.NextBytes(data); // Fill with random data
                fs.Write(data, 0, data.Length);
            }
        }
        Console.WriteLine("File created successfully.");
    }
}


//5. Recursive vs Iterative Fibonacci Computation
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Prompt user for file path
        Console.Write("Enter the file path (e.g., largefile.txt): ");
        string filePath = Console.ReadLine();

        // Prompt user for file size in MB
        Console.Write("Enter the file size in MB (e.g., 500): ");
        if (!int.TryParse(Console.ReadLine(), out int fileSizeMB) || fileSizeMB <= 0)
        {
            Console.WriteLine("Invalid file size. Please enter a positive integer.");
            return;
        }

        // Create the large file if it doesn't exist
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File '{filePath}' does not exist. Creating a {fileSizeMB}MB file...");
            CreateLargeFile(filePath, fileSizeMB);
        }
        else
        {
            Console.WriteLine($"Using existing file: {filePath}");
        }

        Console.WriteLine("Starting performance comparison...");

        // Measure performance of StreamReader
        Stopwatch sw = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null) // Read line by line
            {
                // Do nothing, just read
            }
        }
        sw.Stop();
        Console.WriteLine($"StreamReader took: {sw.ElapsedMilliseconds} ms");

        // Measure performance of FileStream
        sw.Restart();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            int bytesRead;
            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                // Convert bytes to string (if needed)
                string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        Console.WriteLine($"FileStream took: {sw.ElapsedMilliseconds} ms");

        // Clean up (optional)
        Console.Write("Do you want to delete the test file? (y/n): ");
        string deleteChoice = Console.ReadLine();
        if (deleteChoice?.ToLower() == "y")
        {
            File.Delete(filePath);
            Console.WriteLine("File deleted.");
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static void CreateLargeFile(string filePath, int sizeMB)
    {
        Console.WriteLine($"Creating a {sizeMB}MB file...");
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            byte[] data = new byte[1024 * 1024]; // 1MB of data
            Random rng = new Random();
            for (int i = 0; i < sizeMB; i++)
            {
                rng.NextBytes(data); // Fill with random data
                fs.Write(data, 0, data.Length);
            }
        }
        Console.WriteLine("File created successfully.");
        Console.ReadKey();
    }
}
*/






