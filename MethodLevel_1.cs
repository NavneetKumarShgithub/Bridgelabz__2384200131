/*
//0.
using System;
public class UnitConverter
{
    // Method to convert kilometers to miles
    public double ConvertKmToMiles(double km)
    {
        double kmToMilesFactor = 0.621371;
        return km * kmToMilesFactor;
    }

    public static void Main(string[] args)
    {
        // Create a UnitConverter object
        UnitConverter unitConverter = new UnitConverter();

        // Take input from the user
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
        double miles = unitConverter.ConvertKmToMiles(km);
        Console.WriteLine("Distance in miles: " + miles);
    }
}

//0.
using System;
class Program
{
    static void Main()
    {
        // Square root
        int number = 25;
        Console.WriteLine("Square root of "+number+" is: "+Math.Sqrt(number));

        // Power
        int baseValue = 2, powerValue = 3;
        Console.WriteLine(baseValue+" raised to "+powerValue+" is: "+Math.Pow(baseValue, powerValue));

        // Random number
        Random random = new Random();
        Console.WriteLine("Random number: " + random.Next(1, 101)); // Random number between 1 and 100
    }
}


//0.
using System;

class SumOfDigits
{
    // Generate a 4-digit random number
    public int Get4DigitRandomNumber()
    {
        Random random = new Random();
        return random.Next(1000, 10000); // Generates a random number between 1000 and 9999
    }

    // Count the number of digits in a given number
    public int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Extract digits from the number and store them in an array
    public int[] GetDigits(int number, int count)
    {
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Calculate the sum of the digits in the array
    public int SumArray(int[] array)
    {
        int sum = 0;
        foreach (int digit in array)
        {
            sum += digit;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        // Instantiate the SumOfDigits class
        SumOfDigits sumOfDigits = new SumOfDigits();

        // Generate a 4-digit random number
        int number = sumOfDigits.Get4DigitRandomNumber();
        Console.WriteLine("The Random Number is: " + number);

        // Count the number of digits
        int count = sumOfDigits.CountDigits(number);
        Console.WriteLine("The Count of Digits is: " + count);

        // Extract digits into an array
        int[] digits = sumOfDigits.GetDigits(number, count);

        // Calculate the sum of the digits
        int sum = sumOfDigits.SumArray(digits);

        // Display the sum of the digits
        Console.WriteLine("Sum of Digits: " + sum);
    }
}

//1. Write a method to calculate the simple interest given principle, rate and time as parameters calculate Simple Interest.
using System;

class SimpleInterestCalculator
{
    static void Main(string[] args)
    {
        // Take user input for principal, rate, and time
        Console.Write("Enter the Principal amount:");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the Rate of Interest:");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter the Time (in years):");
        double time = double.Parse(Console.ReadLine());

        // Calculate the simple interest
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        // Output the result
        Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+", and Time "+time+" years.");
    }

    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}


//2. Write a method to use the combination formulae to calculate the number of handshakes
using System;
class HandshakeCalculator
{
    static void Main(string[] args)
    {
        // Get integer input for number of students
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculate the maximum number of handshakes
        int maxHandshakes = CalculateHandshakes(numberOfStudents);

        // Output the result
        Console.WriteLine("The maximum number of handshakes among "+numberOfStudents+" students is "+maxHandshakes);
    }

    static int CalculateHandshakes(int n)
    {
        // Use the combination formula to calculate the number of handshakes
        return (n * (n - 1)) / 2;
    }
}

//3. Write a method to use the combination formulae to calculate the number of handshakes
using System;
class HandshakeCalculator
{
    static void Main(string[] args)
    {
        // Get integer input for number of students
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculate the maximum number of handshakes
        int maxHandshakes = CalculateHandshakes(numberOfStudents);

        // Output the result
        Console.WriteLine("The maximum number of handshakes among "+numberOfStudents+" students is "+maxHandshakes);
    }

    static int CalculateHandshakes(int n)
    {
        // Use the combination formula to calculate the number of handshakes
        return (n * (n - 1)) / 2;
    }
} 

//4.
using System;

class TriangularParkRun
{
    static void Main(string[] args)
    {
        // Take user input for the 3 sides of the triangle
        Console.WriteLine("Enter the length of side 1 (in meters):");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2 (in meters):");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3 (in meters):");
        double side3 = double.Parse(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds needed to complete 5 km
        double rounds = CalculateRounds(perimeter, 5000); // 5000 meters = 5 km

        // Output the result
        Console.WriteLine("The athlete needs to complete "+Math.Ceiling(rounds)+" rounds to run 5 km.");
    }

    static double CalculateRounds(double perimeter, double distance)
    {
        return distance / perimeter;
    }
}


//5. To check whether a number is positive, negative, or zero.
using System;
class NumberChecker
{
	static void Main(string[] args)
	{
		Console.Write("Entar a number: ");
		double Number = Convert.ToDouble(Console.ReadLine());
		
		double result = CheckNumber(Number);
		
		if(Number == -1)
		{
			Console.WriteLine("Number is negative");
		}else if(Number == 1)
		{
			Console.WriteLine("Number is positive");
		}else
		{
			Console.WriteLine("Number is zero");
		}
	}
	static double CheckNumber(double Number)
	{
		if(Number > 0)
		{
			return 1;
		}else if(Number < 0)
		{
			return -1;
		}else
		{
			return 0;
		}
	}
}

//6. A program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”
using System;
class SpringSeasonChecker
{   static bool IsSpringSeason(int month, int day)
    {
        // Spring Season is from March 20 to June 20
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        // Take user input for month and day
        Console.WriteLine("Enter the month (1 for January, 2 for February, etc.):");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the day:");
        int day = int.Parse(Console.ReadLine());

        // Check if it's a Spring Season
        bool isSpring = IsSpringSeason(month, day);

        // Output the result
        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}


//7. A program to find the sum of n natural numbers using loop
using System;
class NaturalNumberSum
{   // method 
	static int NaturalNumber(int number)
	{
		int sum = 0;
		for(int i = 1; i <= number; i++)
		{
			sum = sum +i;
		}
		return sum;
	}
	static void Main(string[] args)
	{   // Take input from user
		Console.Write("Enter the sum natural number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		// the sum of n natural number
		int sum = NaturalNumber(number);
		
		// output
		Console.WriteLine("Sum of the natural number : "+ sum);
		
	}
}


//8. Write a single method to find the smallest and largest of the three numbers
using System;
class Program
{
	public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        // Initialize smallest and largest variables
        int smallest = number1;
        int largest = number1;

        // Check for smallest
        if (number2 < smallest) smallest = number2;
        if (number3 < smallest) smallest = number3;

        // Check for largest
        if (number2 > largest) largest = number2;
        if (number3 > largest) largest = number3;

        // Return results as an array
        return new int[] { smallest, largest };
    }
    static void Main(string[] args)
    {
        // Taking user input for 3 numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Calling the method to find the smallest and largest numbers
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Displaying the results
        Console.WriteLine("The smallest number is: "+result[0]);
        Console.WriteLine("The largest number is: "+result[1]);
    }
}

//9. Write Method to find the reminder and the quotient of a number 
using System;
class QuotientAndRemainder
{
	public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
    static void Main(string[] args)
    {
        // Take user input for two numbers
        Console.Write("Enter the first number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (divisor):");
        int divisor = int.Parse(Console.ReadLine());

        // Find the quotient and remainder
        int[] result = FindRemainderAndQuotient(number, divisor);

        // Output the result
        Console.WriteLine("The quotient is "+result[0]+" and the remainder is "+result[1]);
    }
}

//10. Write the method to find the number of chocolates each child gets and number of remaining chocolates
using System;
class ChocolateDivision
{
	public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
    static void Main(string[] args)
    {
        // Get integer input for the number of chocolates and number of children
        Console.Write("Enter the number of chocolates:");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children:");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Find the number of chocolates each child gets and the remaining chocolates
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // Output the result
        Console.WriteLine("Each child will get "+result[0]+" chocolates");
        Console.WriteLine("The remaining chocolates are "+result[1]);
    }  
}

//11. Write a method to calculate the wind chill temperature 
using System;
class WindChillCalculator
{
	public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }
    static void Main(string[] args)
    {
        // Take user input for temperature and wind speed
        Console.Write("Enter the temperature (in Fahrenheit):");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter the wind speed (in mph):");
        double windSpeed = double.Parse(Console.ReadLine());

        // Calculate the wind chill temperature
        double windChill = CalculateWindChill(temperature, windSpeed);

        // Output the result
        Console.WriteLine("The wind chill temperature is "+windChill+" degrees Fahrenheit");
    }
}

//12. Method to calculate various trigonometric functions, Firstly convert to radians and then use Math function to find sine, cosine and tangent.
using System;
class TrigonometricFunctions
{
	public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert the angle from degrees to radians
        double angleInRadians = angle * (Math.PI / 180);

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);

        return new double[] { sine, cosine, tangent };
    }
    static void Main(string[] args)
    {
        // Take user input for the angle in degrees
        Console.Write("Enter the angle in degrees:");
        double angleInDegrees = double.Parse(Console.ReadLine());

        // Calculate the trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angleInDegrees);

        // Output the results
        Console.WriteLine("Sine of "+angleInDegrees+" degrees: "+results[0]);
        Console.WriteLine("Cosine of "+angleInDegrees+" degrees: "+results[1]);
        Console.WriteLine("Tangent of "+angleInDegrees+" degrees: "+results[2]);
    }
}
*/
