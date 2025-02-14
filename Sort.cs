/*
//1. . Bubble Sort - Sort Student Marks
using System;
class BubbleSortExample
{
    // Function to perform Bubble Sort
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        bool swapped;

        // Traverse through the array multiple times
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            // Compare adjacent elements and swap them if needed
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // Swap the elements
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no swapping happened in the inner loop, the array is already sorted
            if (!swapped)
                break;
        }
    }

    // Main function to take user input and display sorted marks
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];

        // Taking user input for marks
        Console.WriteLine("Enter the marks of students:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the marks using Bubble Sort
        BubbleSort(marks);

        // Display the sorted marks
        Console.WriteLine("\nSorted Marks in Ascending Order:");
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine(); // New line for better formatting
        Console.ReadKey();
    }
}



//2.  Insertion Sort - Sort Employee IDs
using System;
class InsertionSortExample
{
    // Function to perform Insertion Sort
    static void InsertionSort(int[] empIds)
    {
        int n = empIds.Length;

        // Iterate through each element from index 1 to n-1
        for (int i = 1; i < n; i++)
        {
            int key = empIds[i]; // The element to be inserted in the sorted part
            int j = i - 1;

            // Move elements of the sorted part that are greater than key, one position ahead
            while (j >= 0 && empIds[j] > key)
            {
                empIds[j + 1] = empIds[j];
                j--;
            }

            // Insert key at the correct position
            empIds[j + 1] = key;
        }
    }

    // Main function to take user input and display sorted employee IDs
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] empIds = new int[n];

        // Taking user input for employee IDs
        Console.WriteLine("Enter the Employee IDs:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Employee {i + 1}: ");
            empIds[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the employee IDs using Insertion Sort
        InsertionSort(empIds);

        // Display the sorted employee IDs
        Console.WriteLine("\nSorted Employee IDs in Ascending Order:");
        foreach (int id in empIds)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine(); // New line for better formatting
        Console.ReadKey();
    }
}


//3.  Merge Sort - Sort an Array of Book Prices
using System;

class MergeSortExample
{
    // Function to merge two halves of the array
    static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Create temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temporary arrays
        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];

        // Merge the temporary arrays
        int x = 0, y = 0, k = left;
        while (x < n1 && y < n2)
        {
            if (leftArray[x] <= rightArray[y])
            {
                prices[k] = leftArray[x];
                x++;
            }
            else
            {
                prices[k] = rightArray[y];
                y++;
            }
            k++;
        }

        // Copy any remaining elements from leftArray
        while (x < n1)
        {
            prices[k] = leftArray[x];
            x++;
            k++;
        }

        // Copy any remaining elements from rightArray
        while (y < n2)
        {
            prices[k] = rightArray[y];
            y++;
            k++;
        }
    }

    // Function to implement Merge Sort
    static void MergeSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Recursively sort first and second halves
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);

            // Merge the sorted halves
            Merge(prices, left, mid, right);
        }
    }

    // Main function to take user input and display sorted prices
    static void Main()
    {
        Console.Write("Enter the number of books: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];

        // Taking user input for book prices
        Console.WriteLine("Enter the prices of books:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Book {i + 1}: ");
            prices[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the book prices using Merge Sort
        MergeSort(prices, 0, n - 1);

        // Display the sorted book prices
        Console.WriteLine("\nSorted Book Prices in Ascending Order:");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine(); // New line for better formatting
        Console.ReadKey();
    }
}


//4.  Quick Sort - Sort Product Prices
using System;

class QuickSortExample
{
    // Function to partition the array
    static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high]; // Choosing the last element as the pivot
        int i = low - 1; // Index of smaller element

        for (int j = low; j < high; j++)
        {
            // If current element is smaller than or equal to pivot
            if (prices[j] < pivot)
            {
                i++;
                // Swap prices[i] and prices[j]
                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }

        // Swap prices[i+1] and pivot (prices[high])
        int temp1 = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = temp1;

        return i + 1; // Return partition index
    }

    // Function to implement Quick Sort
    static void QuickSort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            // Partition the array and get the pivot index
            int pi = Partition(prices, low, high);

            // Recursively sort elements before and after partition
            QuickSort(prices, low, pi - 1);
            QuickSort(prices, pi + 1, high);
        }
    }

    // Main function to take user input and display sorted prices
    static void Main()
    {
        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];

        // Taking user input for product prices
        Console.WriteLine("Enter the product prices:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Product {i + 1}: ");
            prices[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the product prices using Quick Sort
        QuickSort(prices, 0, n - 1);

        // Display the sorted product prices
        Console.WriteLine("\nSorted Product Prices in Ascending Order:");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine(); // New line for better formatting
        Console.ReadKey();
    }
}


//5. Selection Sort - Sort Exam Scores
using System;
class SelectionSortExample
{
    // Function to perform Selection Sort
    static void SelectionSort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i; // Assume the first unsorted element is the smallest

            // Find the index of the minimum element in the remaining unsorted part
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element of the unsorted part
            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }

    // Main function to take user input and display sorted scores
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];

        // Taking user input for exam scores
        Console.WriteLine("Enter the exam scores:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Student {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the exam scores using Selection Sort
        SelectionSort(scores);

        // Display the sorted exam scores
        Console.WriteLine("\nSorted Exam Scores in Ascending Order:");
        foreach (int score in scores)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine(); // New line for better formatting
        Console.ReadKey();
    }
}


//6. Heap Sort - Sort Job Applicants by Salary
using System;
class HeapSortExample
{
    // Function to heapify a subtree rooted at index i
    static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i; // Assume root (i) is the largest
        int left = 2 * i + 1; // Left child
        int right = 2 * i + 2; // Right child

        // Check if left child is larger than root
        if (left < n && salaries[left] > salaries[largest])
            largest = left;

        // Check if right child is larger than the current largest
        if (right < n && salaries[right] > salaries[largest])
            largest = right;

        // If largest is not root, swap and continue heapifying
        if (largest != i)
        {
            int temp = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = temp;

            // Recursively heapify the affected subtree
            Heapify(salaries, n, largest);
        }
    }

    // Function to perform Heap Sort
    static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;

        // Build a max heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        // Extract elements from heap one by one
        for (int i = n - 1; i > 0; i--)
        {
            // Move the current root (largest) to the end
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            // Heapify the reduced heap
            Heapify(salaries, i, 0);
        }
    }

    // Main function to take user input and display sorted salaries
    static void Main()
    {
        Console.Write("Enter the number of job applicants: ");
        int n = int.Parse(Console.ReadLine());

        int[] salaries = new int[n];

        // Taking user input for salary demands
        Console.WriteLine("Enter the expected salaries:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Applicant {i + 1}: ");
            salaries[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the salary demands using Heap Sort
        HeapSort(salaries);

        // Display the sorted salary demands
        Console.WriteLine("\nSorted Salary Demands in Ascending Order:");
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine(); // New line for better formatting
        Console.ReadKey();
    }
}


//7.  Counting Sort - Sort Student Ages
using System;
class CountingSortExample
{
    // Function to perform Counting Sort
    static void CountingSort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1; // Age range (10-18 → 9 values)
        int[] count = new int[range]; // Count array
        int[] output = new int[ages.Length]; // Output sorted array

        // Step 1: Count occurrences of each age
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        // Step 2: Compute cumulative counts
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        // Step 3: Place elements in correct position in output array
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        // Copy sorted output to original array
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    // Main function to take user input and display sorted ages
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];

        // Taking user input for student ages
        Console.WriteLine("Enter the student ages (between 10 and 18):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());

            // Validate age input
            if (ages[i] < 10 || ages[i] > 18)
            {
                Console.WriteLine("Invalid age! Please enter a value between 10 and 18.");
                i--; // Retry input for the same student
            }
        }

        // Sorting the student ages using Counting Sort
        CountingSort(ages, 10, 18);

        // Display the sorted student ages
        Console.WriteLine("\nSorted Student Ages in Ascending Order:");
        foreach (int age in ages)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine(); // New line for better formatting
        Console.ReadKey();
    }
}
*/

