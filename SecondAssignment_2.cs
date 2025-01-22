/*1. Program to Calculate Quotient and Remainder
using System;
class Quotient_and_Remainder
{
    static void Main(string[] args)
    {
        //Input two numbers
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        //Calculate quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        //Output
        Console.WriteLine("The Quotient is "+quotient+ " and Remainder is "+remainder+ " of two numbers "+number1+ " and "+number2);
    }
}

//2. Integer Operations
using System;
class IntOperation
{
    static void Main(string[] args)
    {
        // Input values for a, b, and c
        Console.Write("Enter value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Perform operations
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        // Output
        Console.WriteLine("The results of Int Operations are "+result1+"," +result2+"," +result3+", and" + result4);
    }
}

//3. Double Operations
using System;
class DoubleOpt
{
    static void Main(string[] args)
    {
        // Input values for a, b, and c
        Console.Write("Enter value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Perform operations
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        // Output
        Console.WriteLine("The results of Double Operations are "+result1+"," +result2+"," +result3+", and" +result4);
    }
}

//4. Celsius to Fahrenheit Conversion
using System;
class TemperatureConversion
{
    static void Main(string[] args)
    {
        // Input Celsius temperature
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Output result
        Console.WriteLine("The "+celsius+ " Celsius is " +fahrenheit+ " Fahrenheit");
    }
}

//5. Fahrenheit to Celsius Conversion
using System;
class TemperatureConversion
{
    static void Main(string[] args)
    {
        // Input Fahrenheit temperature
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Output result
        Console.WriteLine("The "+fahrenheit+ " Fahrenheit is "+celsius+ " Celsius");
    }
}

//6. Calculate Total Income
using System;
class IncomeCalculator
{
    static void Main(string[] args)
    {
        // Input salary and bonus
        Console.Write("Enter your salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculate total income
        double totalIncome = salary + bonus;

        // Output
        Console.WriteLine("The salary is INR " +salary+ " and bonus is INR " +bonus+". Hence Total Income is INR "+totalIncome);
    }
}

//7. Swap Two Numbers
using System;
class SwapNumbers
{
    static void Main(string[] args)
    {
        // Input two numbers
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap logic
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // swapped numbers
        Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
    }
}

//8. Rewrite Sample Program with User Inputs
using System;
class TripDetails
{
    static void Main(string[] args)
    {
        // Input trip details
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter your destination city: ");
        string toCity = Console.ReadLine();

        // Input distances and time
        Console.Write("Enter distance from starting city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from via city to destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Output trip
        Console.WriteLine("The trip details for "+name+" are:");
        Console.WriteLine("From "+fromCity+" via "+viaCity+" to "+toCity);
        Console.WriteLine("Total distance: "+fromToVia + viaToFinalCity+" miles");
        Console.WriteLine("Time taken: "+timeTaken+" hours");
    }
}

//9. Calculate Number of Rounds in a Triangular Park
using System;
class Program
{
    static void Main(string[] args)
    {
        // Input: Sides of the triangular park
        Console.WriteLine("Enter side 1 of the triangular park (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side 2 of the triangular park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side 3 of the triangular park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Convert 5 km to meters
        double distance = 5000;

        // Calculate the number of rounds
        double rounds = distance / perimeter;

        // Output
        Console.WriteLine("The total number of rounds the athlete will run is "+Math.Ceiling(rounds)+" to complete 5 km.");
    }
}

//10. Divide Chocolates Among Children
using System;
class Divide_Chocolates
{
    static void Main(string[] args)
    {
        // Enter Number of chocolates 
        Console.WriteLine("Enter the number of chocolates:");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        // Enter number of children   
        Console.WriteLine("Enter the number of children:");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Output the result
        Console.WriteLine("The number of chocolates each child gets is "+chocolatesPerChild+" and the number of remaining chocolates is "+remainingChocolates);
    }
}

//11. Calculate Simple Interest
using System;
class Simple_Interest
{
    static void Main(string[] args)
    {
        // Input: Principal, Rate, and Time
        Console.WriteLine("Enter the Principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Rate of Interest:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Time (in years):");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Output
        Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+", and Time "+time);
    }
}*/

//12. Convert Pounds to Kilograms
using System;
class Convert_Pounds_into_Kilograms
{
    static void Main(string[] args)
    {
        // Enter Weight in pounds
        Console.WriteLine("Enter the weight (in pounds):");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms
        double weightInKilograms = weightInPounds / 2.2;

        // Output
        Console.WriteLine("The weight of the person in pounds is "+weightInPounds+" and in kilograms is "+weightInKilograms);
    }
}
