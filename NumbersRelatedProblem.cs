/*
//1. Write a program where the user thinks of a number between 1 and 100, and 
//the computer tries to guess the number by generating random guesses. 
using System;
class NumberGuessingGame
{
	static void PlayGame()
    {
        int min = 1;
        int max = 100;
        bool correctGuess = false;

        while (!correctGuess)
        {
            int guess = GenerateGuess(min, max);
            Console.WriteLine("Is your number "+guess+" ? (Enter 'high', 'low', or 'correct')");
            string feedback = GetUserFeedback();

            if (feedback == "correct")
            {
                Console.WriteLine("Yay! I guessed your number!");
                correctGuess = true;
            }
            else if (feedback == "high")
            {
                max = guess - 1;
            }
            else if (feedback == "low")
            {
                min = guess + 1;
            }
        }
    }

    static int GenerateGuess(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }

    static string GetUserFeedback()
    {
        string feedback = Console.ReadLine().ToLower();
        while (feedback != "high" && feedback != "low" && feedback != "correct")
        {
            Console.WriteLine("Please enter 'high', 'low', or 'correct'.");
            feedback = Console.ReadLine().ToLower();
        }
        return feedback;
    }
    static void Main(string[] args)
    {
        Console.Write("Think of a number between 1 and 100, and I will try to guess it.");
        PlayGame();
    }
}


//2. Write a program that takes three integer inputs from the user and
// finds the maximum of the three numbers. 
using System;
class MaximumOfThreeNumbers
{
    // Function to take integer input from the user
    static int GetIntegerInput(string prompt)
    {
        Console.WriteLine(prompt);
        return int.Parse(Console.ReadLine());
    }

    // Function to find the maximum of three numbers
    static int FindMaximum(int num1, int num2, int num3)
    {
        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        return max;
    }
    static void Main(string[] args)
    {
        // Take three integer inputs from the user
        int num1 = GetIntegerInput("Enter the first number:");
        int num2 = GetIntegerInput("Enter the second number:");
        int num3 = GetIntegerInput("Enter the third number:");

        // Find the maximum of the three numbers
        int max = FindMaximum(num1, num2, num3);

        // Output the result
        Console.WriteLine("The maximum of the three numbers is: "+max);
    }
}

//3. Create a program that checks whether a given number is a prime number.
using System;
class PrimeNumberChecker
{
    // Function to check if a number is a prime number
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a prime number
        bool isPrime = IsPrime(number);

        // Output the result
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

//4. Write a program that generates the Fibonacci sequence up to a specified number of terms entered by the user. 
using System;
class FibonacciSequenceGenerator
{
    // Function to generate and print the Fibonacci sequence
    static void GenerateAndPrintFibonacci(int terms)
    {
        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci sequence:");

        for (int i = 0; i < terms; i++)
        {
            if (i <= 1)
            {
                next = i;
            }
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.Write(next + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        // Take user input for the number of terms
        Console.Write("Enter the number of terms:");
        int terms = int.Parse(Console.ReadLine());

        // Generate and print the Fibonacci sequence
        GenerateAndPrintFibonacci(terms);
    }
}


//5. Write a program that checks if a given string is a palindrome 
//(a word, phrase, or sequence that reads the same backward as forward). 
using System;
class PalindromeChecker
{
    static void Main(string[] args)
    {
        // Take user input for the string
        string input = GetInput();

        // Check if the string is a palindrome
        bool isPalindrome = CheckPalindrome(input);

        // Display the result
        DisplayResult(input, isPalindrome);
    }

    // Function to take user input
    static string GetInput()
    {
        Console.Write("Enter a string:");
        return Console.ReadLine();
    }

    // Function to check if a string is a palindrome
    static bool CheckPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    // Function to display the result
    static void DisplayResult(string str, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine(str+" is a palindrome.");
        }
        else
        {
            Console.WriteLine(str+" is not a palindrome.");
        }
    }
}


//6. Write a program that calculates the factorial of a number using a recursive function. 
using System;
class FactorialCalculator
{
    static void Main(string[] args)
    {
        // Take user input for the number
        int number = GetInput();

        // Calculate the factorial using recursion
        long factorial = CalculateFactorial(number);

        // Display the result
        DisplayResult(number, factorial);
    }

    // Function to take user input
    static int GetInput()
    {
        Console.Write("Enter a number:");
        return int.Parse(Console.ReadLine());
    }

    // Recursive function to calculate the factorial of a number
    static long CalculateFactorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        else
        {
            return number * CalculateFactorial(number - 1);
        }
    }

    // Function to display the result
    static void DisplayResult(int number, long factorial)
    {
        Console.WriteLine("The factorial of "+number+" is "+factorial);
    }
}


//7. Create a program that calculates the Greatest Common Divisor (GCD) and 
//Least Common Multiple (LCM) of two numbers using functions.
using System;
class GCDAndLCMCalculator
{
    static void Main(string[] args)
    {
        // Take user input for the two numbers
        int num1 = GetIntegerInput("Enter the first number:");
        int num2 = GetIntegerInput("Enter the second number:");

        // Calculate the GCD
        int gcd = CalculateGCD(num1, num2);

        // Calculate the LCM
        int lcm = CalculateLCM(num1, num2, gcd);

        // Output the results
        Console.WriteLine("The GCD of "+num1+" and "+num2+" is: "+gcd);
        Console.WriteLine("The LCM of "+num1+" and "+num2+" is: "+lcm);
    }

    // Function to take integer input from the user
    static int GetIntegerInput(string prompt)
    {
        Console.WriteLine(prompt);
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate the GCD of two numbers using the Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate the LCM of two numbers
    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}


//8. Write a program that converts temperatures between Fahrenheit and Celsius.
using System;

class TemperatureConverter
{
    // Function to convert Fahrenheit to Celsius
    static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    static void Main(string[] args)
    {
        // Take user input for the temperature and the conversion type
        Console.Write("Enter the temperature:");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter the conversion type (F to C or C to F):");
        string conversionType = Console.ReadLine().ToUpper();

        // Perform the conversion based on the user's input
        if (conversionType == "F TO C")
        {
            double celsius = ConvertFahrenheitToCelsius(temperature);
            Console.WriteLine(temperature+" Fahrenheit is equal to "+celsius+" Celsius.");
        }
        else if (conversionType == "C TO F")
        {
            double fahrenheit = ConvertCelsiusToFahrenheit(temperature);
            Console.WriteLine(temperature+" Celsius is equal to "+fahrenheit+" Fahrenheit.");
        }
        else
        {
            Console.WriteLine("Invalid conversion type. Please enter 'F to C' or 'C to F'.");
        }
    }
}


//9. Write a program that performs basic mathematical operations (addition, subtraction, multiplication, division) based on user input. 
using System;
class BasicMathOperations
{
    // Function to perform the chosen operation
    static double PerformOperation(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "+":
                return Add(num1, num2);
            case "-":
                return Subtract(num1, num2);
            case "*":
                return Multiply(num1, num2);
            case "/":
                return Divide(num1, num2);
            default:
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                return 0;
        }
    }

    // Function to add two numbers
    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Function to subtract two numbers
    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    // Function to multiply two numbers
    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    // Function to divide two numbers
    static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return num1 / num2;
    }
    static void Main(string[] args)
    {
        // Take user input for the two numbers
		Console.Write("Enter the first number: ");
		double num1 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter the first number: ");
		double num2 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to choose an operation
        Console.WriteLine("Choose an operation: +, -, *, /");
        string operation = Console.ReadLine();

        // Perform the chosen operation
        double result = PerformOperation(num1, num2, operation);

        // Output the result
        Console.WriteLine("The result of "+num1+" "+operation+" "+num2+" is: "+result);
    }

    // Function to take double input from the user
    static double GetDoubleInput(string prompt)
    {
        Console.WriteLine(prompt);
        return double.Parse(Console.ReadLine());
    }
}
*/