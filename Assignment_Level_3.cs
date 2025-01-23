/*//1. A number is Armstrong or not.
using System;
class ArmstrongNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        //sum variable and initialize it to zero
        int sum = 0;

        // originalNumber variable and assign it to the input number
        int originalNumber = number;

        // Use the while loop till the originalNumber is not equal to zero
        while (originalNumber != 0)
        {
            // Find the remainder number by using the modulus operator
            int remainder = originalNumber % 10;

            // Find the cube of the number and add it to the sum variable
            sum += remainder * remainder * remainder;

            // Find the quotient of the number and assign it to the originalNumber
            originalNumber /= 10;
        }

        // Check if the number and the sum are the same
        if (number == sum)
        {
            Console.WriteLine(number+" is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(number+" is not an Armstrong number.");
        }
    }
}

//2. Count the number of digits in an integer.
using System;
class DigitCounter
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        // Initialize the count variable to 0
        int count = 0;

        // Use a loop to iterate until number is not equal to 0
        while (number != 0)
        {
            // Remove the last digit from number
            number /= 10;

            // Increase count by 1 in each iteration
            count++;
        }

        //  the count to show the number of digits
        Console.WriteLine("The number of digits is "+count);
    }
}

//3. Check if a number taken from the user is a Harshad Number.

using System;

class HarshadNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        // Define sum variable and initialize it to zero
        int sum = 0;

        // Define originalNumber variable and assign it to the input number
        int originalNumber = number;

        // Use a while loop to access each digit of the number
        while (originalNumber != 0)
        {
            // Find the remainder number by using the modulus operator
            int remainder = originalNumber % 10;

            // Add each digit of the number to sum
            sum += remainder;

            // Remove the last digit from originalNumber
            originalNumber /= 10;
        }

        // Check if the number is perfectly divisible by the sum
        if (number % sum == 0)
        {
            Console.WriteLine(number+" is a Harshad Number.");
        }
        else
        {
            Console.WriteLine(number+" is not a Harshad Number.");
        }
    }
}

//4.  Check if a number is an Abundant Number
using System;
class AbundantNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        // Define sum variable and initialize it to zero
        int sum = 0;

        // Run a for loop from i = 1 to i < number
        for (int i = 1; i < number; i++)
        {
            // Check if the number is divisible by i
            if (number % i == 0)
            {
                // Add i to sum
                sum += i;
            }
        }

        // Check if the sum is greater than the number
        if (sum > number)
        {
            Console.WriteLine(number+" is an Abundant Number.");
        }
        else
        {
            Console.WriteLine(number+" is not an Abundant Number.");
        }
    }
}


//5. A program DayOfWeek that takes a date as input and prints the day of the week that the date falls on
using System;
class DayOfWeekCalculator
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter the month (1 for January, 2 for February, etc.):");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter the day:");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter the year:");
        int y = int.Parse(Console.ReadLine());

        // Calculate y0, x, m0, and d0 using the provided formulas
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        // Print the day of the week
        Console.WriteLine("The day of the week for "+m+"/"+d+"/"+y+" is "+d0+" (0 for Sunday, 1 for Monday, etc.).");
    }
}

//6. To create a calculator using switch...case.
using System;
class Calculator
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter the first number:");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double second = double.Parse(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        // Perform specific operations using switch...case statement
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: "+(first + second));
                break;
            case "-":
                Console.WriteLine("Result: "+(first - second));
                break;
            case "*":
                Console.WriteLine("Result: "+(first * second));
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result: "+(first / second));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
*/
