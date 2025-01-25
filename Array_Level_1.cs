//1.
/*using System;
class Array
{
	static void Main(string[] args)
	{
		int[,] arr = new int[3, 3]; 
int sum = 0; 
Console.WriteLine("Enter elements for the 2D Array:");
for (int i = 0; i < 2; i++) {
 for (int j = 0; j < 2; j++) {
 arr[i, j] = int.Parse(Console.ReadLine());
 sum += arr[i, j];
 }
}
Console.WriteLine("The elements of the 2D Array are:");
for (int i = 0; i < 2; i++) {
 for (int j = 0; j < 2; j++) {
 Console.Write(arr[i, j] + " ");
 }
 Console.WriteLine();
}
Console.WriteLine("The sum of the elements of the 2D Array is: " + sum);

	}
}

//2.
using System;
class StudentResultIndicator
{
 static void Main(string[] args)
 {
 // Get student score from the user
 Console.WriteLine("Enter grade:");
 int studentGrade = int.Parse(Console.ReadLine());
 // Condition for invalid score
 if (studentGrade < 0 || studentGrade > 100)
 {
 Console.Error.WriteLine("Invalid grade.");
 Environment.Exit(0);
 }
 // Check for pass/fail
 if (studentGrade >= 50)
 {
 Console.WriteLine("Congratulations!");
 Console.WriteLine("You passed the examination.");
 }
 else
 {
 Console.WriteLine("Sorry.\nYou failed the examination.");
 }
 }
}

// Create SumOfDigit Class to compute the sum of all digits of a number using
// an array
using System;
class SumOfDigits
{
 static void Main(string[] args)
 {
 // Take input for a number
 Console.Write("Enter a number: ");
 int number = int.Parse(Console.ReadLine());
 // Validate the input
 if (number < 0)
 {
 Console.Error.WriteLine("Invalid Number.");
 Environment.Exit(0);
 }
 // Find the count of digits
 int count = 0, temp = number;
 while (temp > 0)
 {
 count++;
 temp /= 10;
 }
 // Save the digits in an array
 int[] digits = new int[count];
 for (int i = 0; i < count; i++)
 {
 digits[i] = number % 10;
 number /= 10;
 }
 // Calculate the sum of digits
 int sum = 0;
 foreach (int digit in digits)
 {
 sum += digit;
 }
 // Display the sum
 Console.WriteLine("\nSum of Digits: " + sum);
 }
}


//1.Using array check the student is valid for vote depending on his/her age is greater or equal to 18
using System;
class CheckStudentEligibility_for_voting
{
	static void Main(string[] args)
	{
		//define an array of 10 student age
		int[] age = new int[10];
		
		//enter the age of the student
		for(int i = 0; i < age.Length;i++)
		{
			Console.Write("Enter the age of Students " + (i + 1)+": ");
			age[i] = Convert.ToInt32(Console.ReadLine());
		}
		for(int i = 0;i < age.Length;i++)
		{
			// if the age is negative
			if(age[i] < 0)
			{
				Console.WriteLine("The student with the age "+(i+1)+" cannot vote.");
			}
			//age is greater than 18 or equal to 18
			else if(age[i] >= 18)
			{
				Console.WriteLine("The student with the age "+age[i]+" can vote.");
			}
			// if the age is less than 18
			else
			{
				Console.WriteLine("The student with the age "+age[i]+" cannot vote.");
			}
		}
	}
}


//2.user input 5 number check the is positive , negative and zero. If the number is positive than 
//check the odd or even number and at last compare the first and the last number.
using System;
class CheckNumber_odd_even
{
	static void Main(string[] args)
	{
		//difine an array of 5 numbers
		int[] number = new int[5];
		
		//enter the 5 numbers
        for(int i = 0; i < number.Length;i++)
		{
			Console.Write("Enter the numbers"+ (i + 1)+": ");
			number[i] = Convert.ToInt32(Console.ReadLine());
		}
		// loop through the array using the length
        for(int i = 0; i < number.Length;i++)
		{		
			// check the number is postive , negative and zero
			if(number[i] < 0 )
			{
				Console.WriteLine("Input number is negative :"+number[i]);
			}else if(number[i] > 0)
			{
				Console.WriteLine("Input number is positive :"+number[i]);
				
				//check number is even odd 
				if(number[i] % 2 == 0)
				{
					Console.WriteLine("Number is even :"+number[i]);
				}
				else
				{
					Console.WriteLine("Number is odd :"+number[i]);
				}	
			}else
			{
				Console.WriteLine("Input number is zero :"+number[i]);
			}
		}
		// compare the first and last elementof the array
		if(number[0] == number[4])
		{
            Console.WriteLine("The first and last number are equal.");
        }
        else if (number[0] > number[4])
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else
        {
            Console.WriteLine("The first number is less than the last number.");
        }
	}
}


//3.A program to print a multiplication table of a number
using System;
class MultiplicationTable
{
	static void Main(string[] args)
	{
		//enter a number for multiplication table
		Console.Write("Enter a number for the multipliction table of that number: ");
		int table = Convert.ToInt32(Console.ReadLine());
		
		//loop for table 1 to 10 in an array
		int[] number = new int[10];
        
        for(int i = 0; i < number.Length;i++)
		{
			Console.WriteLine(table+" * "+(i+1)+" = "+ table * (i+1));
		}			
	}
}

//4.Store multiple value not zero or negative if it is than break the loop and sum the numbers
using System;
class StoreValues
{
    static void Main(string[] args)
    {
        // Create a variable to store an array of 10 elements of type double
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        // Use infinite while loop
        while (true)
        {
            // Take the user entry
            Console.Write("Enter a number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            // Check if the user entered 0 or a negative number to break the loop
            if (input <= 0 || index == 10)
            {
                break;
            }

            // Assign the number to the array element and increment the index value
            numbers[index] = input;
            index++;
        }

        // Loop to get the values of each element and add it to the total
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }

        // Display all the numbers
        Console.Write("The numbers entered are: ");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Display the total value
        Console.WriteLine("The sum of all numbers is: "+total);
    }
}

//5. the multiplication table of a number entered by the user from 6 to 9
using System;
class MultiplicationTablefrom_6_to_9
{
	static void Main(string[] args)
	{
		//enter a number for multiplication table
		Console.Write("Enter a number for the multipliction table of that number: ");
		int table = Convert.ToInt32(Console.ReadLine());
		
		//loop for table 1 to 10 in an array
		int[] number = new int[10];
        
        for(int i = 6; i < number.Length;i++)
		{
			Console.WriteLine(table+" * "+(i)+" = "+ table * (i));
		}			
	}
}

//6.The mean height of players present in a football team
using System;
class Mean
{
	static void Main(string[] args)
	{
		//an create array of 11 index
		int[] player = new int[11];
		double sum = 0;
		
		// loop for the chaning index
		for(int i = 0; i < player.Length; i++)
		{
			//enter the heights of the players
		    Console.Write("enter the height of the player "+ (i + 1) +": " );
		    player[i] = Convert.ToInt32( Console.ReadLine());
		}	
		for(int i = 0; i < player.Length; i++)
		{	
			// sum of all the height of the 11 players
			sum += player[i];
		}
		Console.WriteLine("The mean height of the football team =" + sum/player.Length);
	}
}

//7.save odd and even numbers into odd and even arrays between 1 and the number entered by the user:
using System;
class OddEvenArrays
{
    static void Main(string[] args)
    {
        // Get an integer input from the user
        Console.WriteLine("Enter a natural number:");
        int number = int.Parse(Console.ReadLine());

        // natural number
        if (number <= 0)
        {
            Console.Write("Error: Please enter a natural number greater than 0.");
            return;
        }

        // Create integer arrays for even and odd numbers
        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];

        // Create index variables for odd and even numbers
        int evenIndex = 0;
        int oddIndex = 0;

        // Iterate from 1 to the number
        for (int i = 1; i <= number; i++)
        {
            // Save the odd or even number into the corresponding array
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        // Print the odd numbers array
        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.WriteLine(oddNumbers[i]);
        }

        // Print the even numbers array
        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.WriteLine(evenNumbers[i]);
        }
    }
}

//8. A number taken as user input, store the factors in an array, and display the factors
using System;

class FactorsFinder
{
    static void Main(string[] args)
    {
        // Take the input for a number
        Console.Write("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize variables
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Loop through the numbers from 1 to the number to find factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                // Add the factor to the array
                if (index == maxFactor)
                {
                    // Resize the array if needed
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }
                factors[index] = i;
                index++;
            }
        }

        // Display the factors
        Console.WriteLine("Factors of "+number+" are:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }
}

//9. Create a 2D Array and Copy the 2D Array into a single dimension array
using System;
class MultiDimensionalArray
{
    static void Main(string[] args)
    {
        // Take user input for rows and columns
        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int columns = int.Parse(Console.ReadLine());

        // Create a 2D array (Matrix)
        int[,] matrix = new int[rows, columns];

        // Take user input for the elements of the matrix
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Create a 1D array to store the elements of the 2D array
        int[] array = new int[rows * columns];
        int index = 0;

        // Copy the elements of the 2D array into the 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }

        // Display the elements of the 1D array
        Console.WriteLine("The elements of the 1D array are:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

//10. a program FizzBuzz
using System;
class FizzBuzz
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (number > 0)
        {
            // Create a string array to save the results
            string[] results = new string[number + 1];

            // Loop from 0 to the user input number
            for (int i = 0; i <= number; i++)
            {
                // Check for multiples of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i] = "FizzBuzz";
                }
                // Check for multiples of 3
                else if (i % 3 == 0)
                {
                    results[i] = "Fizz";
                }
                // Check for multiples of 5
                else if (i % 5 == 0)
                {
                    results[i] = "Buzz";
                }
                // Save the number if not a multiple of 3 or 5
                else
                {
                    results[i] = i.ToString();
                }
            }

            // Print the array results for each index position
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("Position "+i+" = "+results[i]);
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
*/
