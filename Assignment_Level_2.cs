/*//1. Leap Year Check with Multiple If-Else Statements
using System;
class LeapYearCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year (>= 1582):");
        int year = int.Parse(Console.ReadLine()); // Read user input

        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or later.");
            return;
        }

        // Check if the year is a leap year
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(year + " is a Leap Year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
} 
//2. Determine Leap Year with single if condition using logical and && and or || operators
using System;

class LeapYearChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is a leap year using a single if condition
        if ((year >= 1582) && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
        {
            Console.WriteLine(year+" is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year+" is not a Leap Year.");
        }
    }
}


//3. the percentage and then calculate the grade as per the following guidelines

using System;

class calculategrade
{
    static void Main()
    {
        // Input marks for Physics, Chemistry, and Maths
        Console.Write("Enter marks for Physics: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        int maths = int.Parse(Console.ReadLine());

        // Calculate total, average, and percentage
        int total = physics + chemistry + maths;
        double average = total / 3.0; // Calculate average
        double percentage = (total / 300.0) * 100; // Assuming each subject has max 100 marks

        // Determine grade and remarks
        char grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = 'A';
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = 'B';
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = 'C';
            remarks = "Level 2, below, but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = 'D';
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = 'E';
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = 'R';
            remarks = "Remedial standards";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Total Marks: "+total);
        Console.WriteLine("Average Marks: "+average);
        Console.WriteLine("Percentage: "+percentage);
        Console.WriteLine("Grade: "+grade);
        Console.WriteLine("Remarks: "+remarks);
    }
}

//4. Check if the given number is a prime number or not
using System;
class PrimeNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Initialize isPrime to true
        bool isPrime = true;

        // Check if the number is greater than 1
        if (number > 1)
        {
            // Loop through all numbers from 2 to the user input number
            for (int i = 2; i < number; i++)
            {
                // Check if the remainder is zero
                if (number % i == 0)
                {
                    // If divisible by some other number, set isPrime to false and break the loop
                    isPrime = false;
                    break;
                }
            }
        }
        else
        {
            // Numbers less than or equal to 1 are not prime
            isPrime = false;
        }

        // Display the result
        if (isPrime)
        {
            Console.WriteLine(number+" is a prime number.");
        }
        else
        {
            Console.WriteLine(number+" is not a prime number.");
        }
    }
}

//5. FizzBuzz program using for loop
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
            // Loop from 0 to the user input number
            for (int i = 0; i <= number; i++)
            {
                // Check for multiples of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check for multiples of 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check for multiples of 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Print the number if not a multiple of 3 or 5
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}

//6. fizzbuzz program uding while loop
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
            int i = 0;
            // Loop from 0 to the user input number using while loop
            while (i <= number)
            {
                // Check for multiples of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check for multiples of 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check for multiples of 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Print the number if not a multiple of 3 or 5
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}

//7. find the BMI of a person
using System;

class Program
{
    static void Main()
    {
        // Input weight in kilograms
        Console.Write("Enter weight in kilograms (kg): ");
        double weight = double.Parse(Console.ReadLine());

        // Input height in centimeters
        Console.Write("Enter height in centimeters (cm): ");
        double heightCm = double.Parse(Console.ReadLine());

        // Convert height from centimeters to meters
        double heightMeters = heightCm / 100;

        // Calculate BMI using the formula BMI = weight / (height * height)
        double bmi = weight / (heightMeters * heightMeters);

        // Determine weight status based on BMI
        string status;
        if (bmi <= 18.4)
        {
            status = "Underweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            status = "Normal";
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }

        // Display BMI and weight status
        Console.WriteLine("\nResults:");
        Console.WriteLine("BMI: "+bmi);
        Console.WriteLine("Weight Status: "+status);
    }
}

//8. The youngest friends among 3 Amar, Akbar, and Anthony
using System;
class FriendsComparison
{
    static void Main(string[] args)
    {
        // Input ages and heights for the three friends
        Console.WriteLine("Enter the age of Amar:");
        int ageAmar = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of Amar (in cm):");
        double heightAmar = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age of Akbar:");
        int ageAkbar = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of Akbar (in cm):");
        double heightAkbar = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age of Anthony:");
        int ageAnthony = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of Anthony (in cm):");
        double heightAnthony = double.Parse(Console.ReadLine());

        // Determine the youngest friend
        string youngestFriend;
        if (ageAmar < ageAkbar && ageAmar < ageAnthony)
        {
            youngestFriend = "Amar";
        }
        else if (ageAkbar < ageAmar && ageAkbar < ageAnthony)
        {
            youngestFriend = "Akbar";
        }
        else
        {
            youngestFriend = "Anthony";
        }

        // Determine the tallest friend
        string tallestFriend;
        if (heightAmar > heightAkbar && heightAmar > heightAnthony)
        {
            tallestFriend = "Amar";
        }
        else if (heightAkbar > heightAmar && heightAkbar > heightAnthony)
        {
            tallestFriend = "Akbar";
        }
        else
        {
            tallestFriend = "Anthony";
        }

        // output
        Console.WriteLine("The youngest friend is "+youngestFriend);
        Console.WriteLine("The tallest friend is "+tallestFriend);
    }
}

//9. the greatest factor of a number
using System;
class GreatestFactor
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        // Define the greatestFactor variable and assign it to 1
        int greatestFactor = 1;

        // Create a for loop that runs from last but one till 1
        for (int i = number - 1; i >= 1; i--)
        {
            // Check if the number is perfectly divisible by i
            if (number % i == 0)
            {
                // Assign i to greatestFactor and break the loop
                greatestFactor = i;
                break;
            }
        }

        // Display the greatestFactor variable
        Console.WriteLine("The greatest factor of "+number+" besides itself is "+greatestFactor);
    }
}

//10. the power of a number
using System;

class PowerCalculator
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter the base number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the power:");
        int power = int.Parse(Console.ReadLine());

        // Initialize the result variable to 1
        int result = 1;

        // Run a for loop from i = 1 to i <= power
        for (int i = 1; i <= power; i++)
        {
            // Multiply the result with the number in each iteration
            result *= number;
        }

        // Print the result
        Console.WriteLine(number+" raised to the power of "+power+" is "+result);
    }
}

//11.  the factors of a number taken as user input
using System;

class FactorsFinder
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Run a for loop from i = 1 to i < number
        Console.WriteLine("Factors of "+number+" are:");
        for (int i = 1; i < number; i++)
        {
            // Check if the number is perfectly divisible by i
            if (number % i == 0)
            {
                // Print the value of i
                Console.WriteLine(i);
            }
        }
    }
}

//12.  the multiple of a number taken as user input below 100.
using System;
class MultiplesFinder
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Run a for loop backward from 100 to 1
        Console.WriteLine("Multiples of "+number+" below 100 are: ");
        for (int i = 100; i >= 1; i--)
        {
            // Check if i perfectly divides the number
            if (i % number == 0)
            {
                // Print the number
                Console.WriteLine(i);
            }
        }
    }
}
*/