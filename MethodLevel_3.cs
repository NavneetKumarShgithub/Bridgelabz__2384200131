/*
//1. Create a program to find the shortest, tallest, and mean height of players present in a football team.
using System;
class FootballTeamHeights
{
	static int CalculateSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    static double CalculateMean(int sum, int numberOfElements)
    {
        return (double)sum / numberOfElements;
    }

    static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
    static void Main(string[] args)
    {
        // Create an int array named heights of size 11
        int[] heights = new int[11];
        Random random = new Random();

        // Get random heights in the range 150 cms to 250 cms for each player
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);
        }

        // Find the sum of all the elements present in the array
        int sum = CalculateSum(heights);

        // Find the mean height of the players on the football team
        double meanHeight = CalculateMean(sum, heights.Length);

        // Find the shortest height of the players on the football team
        int shortestHeight = FindShortestHeight(heights);

        // Find the tallest height of the players on the football team
        int tallestHeight = FindTallestHeight(heights);

        // Display the results
        Console.WriteLine("Heights of the players:");
        foreach (int height in heights)
        {
            Console.WriteLine(height + " cm");
        }
        Console.WriteLine("Mean height: "+meanHeight+" cm");
        Console.WriteLine("Shortest height: "+shortestHeight+" cm");
        Console.WriteLine("Tallest height: "+tallestHeight+" cm");
    }
}


//2. Create a NumberChecker utility class 
using System;
class Solution {
    // Extract digits of a number as an array
    public static int[] GetDigits(int number) {
        int length = 0, tempNumber = number;
        while (tempNumber != 0) {
            length++;
            tempNumber /= 10;
        }
        int[] digits = new int[length];
        int i = length - 1; 
        while (number != 0) {
            digits[i] = number % 10;
            i--;
            number /= 10;
        }
        return digits;
    }

    // Check if a number is a Duck Number
    public static bool IsDuckNumber(int number) {
        int[] digits = GetDigits(number);
        if (digits[0] == 0) return false;
        foreach (int digit in digits) {
            if (digit == 0) return true;
        }
        return false;
    }

    // Check if a number is an Armstrong Number
    public static bool IsArmstrongNumber(int number) {
        int[] digits = GetDigits(number);
        int power = digits.Length;
        int sum = 0;
        foreach (int digit in digits) {
            sum += (int)Math.Pow(digit, power);
        }
        return sum == number;
    }

    // Find the largest and second-largest digits
    public static void FindLargestAndSecondLargest(int[] digits) {
        int largest = int.MinValue, secondLargest = int.MinValue;
        foreach (int digit in digits) {
            if (digit > largest) {
                secondLargest = largest;
                largest = digit;
            } else if (digit > secondLargest) {
                secondLargest = digit;
            }
        }
        Console.WriteLine("Largest: {0}, Second Largest: {1}", largest, secondLargest);
    }

    // Find the smallest and second-smallest digits
    public static void FindSmallestAndSecondSmallest(int[] digits) {
        int smallest = int.MaxValue, secondSmallest = int.MaxValue;
        foreach (int digit in digits) {
            if (digit < smallest) {
                secondSmallest = smallest;
                smallest = digit;
            } else if (digit < secondSmallest) {
                secondSmallest = digit;
            }
        }
        Console.WriteLine("Smallest: {0}, Second Smallest: {1}", smallest, secondSmallest);
    }

    // Main Method
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Is Duck Number: {0}", IsDuckNumber(number));
        Console.WriteLine("Is Armstrong Number: {0}", IsArmstrongNumber(number));

        int[] digits = GetDigits(number);
        FindLargestAndSecondLargest(digits);
        FindSmallestAndSecondSmallest(digits);
    }
}



//3. Create a NumberChecker utility class all are static methods
using System;
class NumberChecker
{
	public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    public static int[] StoreDigits(int number)
    {
        int digitCount = CountDigits(number);
        int[] digits = new int[digitCount];
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    public static double SumOfSquares(int[] digits)
    {
        double sumOfSquares = 0;
        foreach (int digit in digits)
        {
            sumOfSquares += Math.Pow(digit, 2);
        }
        return sumOfSquares;
    }

    public static bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }

    public static int[,] FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
    static void Main(string[] args)
    {
        // Take user input for a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Call the different methods and display results
        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number);
        int sumOfDigits = SumOfDigits(digits);
        double sumOfSquares = SumOfSquares(digits);
        bool isHarshadNumber = IsHarshadNumber(number, sumOfDigits);
        int[,] digitFrequency = FindDigitFrequency(digits);

        Console.WriteLine("Count of digits: "+digitCount);
        Console.WriteLine("Digits: "+string.Join(", ", digits));
        Console.WriteLine("Sum of digits: "+sumOfDigits);
        Console.WriteLine("Sum of squares of digits: "+sumOfSquares);
        Console.WriteLine("Is Harshad Number: "+isHarshadNumber);
        Console.WriteLine("Digit frequency:");
        for (int i = 0; i < digitFrequency.GetLength(0); i++)
        {
            Console.WriteLine("Digit : "+digitFrequency[i, 0]+": "+digitFrequency[i, 1]+" times");
        }
    }
}

//4. Create a NumberChecker utility class 
using System;

class NumberChecker
{
	public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    public static int[] StoreDigits(int number)
    {
        int digitCount = CountDigits(number);
        int[] digits = new int[digitCount];
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversedDigits = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversedDigits[i] = digits[digits.Length - 1 - i];
        }
        return reversedDigits;
    }

    public static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = ReverseDigits(digits);
        return CompareArrays(digits, reversedDigits);
    }

    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true;
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        // Take user input for a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Call the different methods and display results
        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigits(digits);
        bool areArraysEqual = CompareArrays(digits, reversedDigits);
        bool isPalindrome = IsPalindrome(digits);
        bool isDuckNumber = IsDuckNumber(digits);

        Console.WriteLine("Count of digits: "+digitCount);
        Console.WriteLine("Digits: "+string.Join(", ", digits));
        Console.WriteLine("Reversed digits: "+string.Join(", ", reversedDigits));
        Console.WriteLine("Are original and reversed arrays equal: "+areArraysEqual);
        Console.WriteLine("Is Palindrome: "+isPalindrome);
        Console.WriteLine("Is Duck Number: "+isDuckNumber);
    }
}


//5.Create a NumberChecker utility pprime number and other types on numbers
using System;
class NumberChecker
{
	public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    public static bool IsSpy(int number)
    {
        int sumOfDigits = 0;
        int productOfDigits = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sumOfDigits += digit;
            productOfDigits *= digit;
            number /= 10;
        }
        return sumOfDigits == productOfDigits;
    }

    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
    static void Main(string[] args)
    {
        // Take user input for a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Call the different methods and display results
        bool isPrime = IsPrime(number);
        bool isNeon = IsNeon(number);
        bool isSpy = IsSpy(number);
        bool isAutomorphic = IsAutomorphic(number);
        bool isBuzz = IsBuzz(number);

        Console.WriteLine("Is Prime Number: "+isPrime);
        Console.WriteLine("Is Neon Number: "+isNeon);
        Console.WriteLine("Is Spy Number: "+isSpy);
        Console.WriteLine("Is Automorphic Number: "+isAutomorphic);
        Console.WriteLine("Is Buzz Number: "+isBuzz);
    }
}


//6. A NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results
using System;
class NumberChecker
{	
    public static int[] FindFactors(int number)
    {
        // First loop to find the count of factors
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Initialize the array with the count of factors
        int[] factors = new int[count];
        int index = 0;

        // Second loop to save the factors into the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    public static int FindGreatestFactor(int[] factors)
    {
        int greatest = factors[0];
        foreach (int factor in factors)
        {
            if (factor > greatest)
            {
                greatest = factor;
            }
        }
        return greatest;
    }

    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    public static int FindProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    public static double FindProductOfCubes(int[] factors)
    {
        double productOfCubes = 1;
        foreach (int factor in factors)
        {
            productOfCubes *= Math.Pow(factor, 3);
        }
        return productOfCubes;
    }

    public static bool IsPerfectNumber(int number, int sumOfFactors)
    {
        return sumOfFactors - number == number;
    }

    public static bool IsAbundantNumber(int number, int sumOfFactors)
    {
        return sumOfFactors - number > number;
    }

    public static bool IsDeficientNumber(int number, int sumOfFactors)
    {
        return sumOfFactors - number < number;
    }

    public static bool IsStrongNumber(int number)
    {
        int sumOfFactorials = 0;
        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);
            temp /= 10;
        }
        return sumOfFactorials == number;
    }

    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    static void Main(string[] args)
    {
        // Take user input for a number
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Call the different methods and display results
        int[] factors = FindFactors(number);
        int greatestFactor = FindGreatestFactor(factors);
        int sumOfFactors = FindSumOfFactors(factors);
        int productOfFactors = FindProductOfFactors(factors);
        double productOfCubes = FindProductOfCubes(factors);
        bool isPerfect = IsPerfectNumber(number, sumOfFactors);
        bool isAbundant = IsAbundantNumber(number, sumOfFactors);
        bool isDeficient = IsDeficientNumber(number, sumOfFactors);
        bool isStrong = IsStrongNumber(number);

        Console.WriteLine("Factors: "+string.Join(", ", factors));
        Console.WriteLine("Greatest factor: "+greatestFactor);
        Console.WriteLine("Sum of factors: "+sumOfFactors);
        Console.WriteLine("Product of factors: "+productOfFactors);
        Console.WriteLine("Product of cubes of factors: "+productOfCubes);
        Console.WriteLine("Is Perfect Number: "+isPerfect);
        Console.WriteLine("Is Abundant Number: "+isAbundant);
        Console.WriteLine("Is Deficient Number: "+isDeficient);
        Console.WriteLine("Is Strong Number: "+isStrong);
    }
}


//7. a program to generate a six-digit OTP number using Math.Random() method. 
using System;

class OTP {
    // Method to generate a 6-digit OTP
    public static int GenerateOTP() {
        Random random = new Random();
        return random.Next(100000, 1000000); 
    }

    // Method to check if all OTPs in the array are unique
    public static bool CheckOTPsUnique(int[] otps) {
        for (int i = 0; i < otps.Length; i++) {
            for (int j = i + 1; j < otps.Length; j++) {
                if (otps[i] == otps[j]) {
                    return false; 
                }
            }
        }
        return true; 
    }

    public static void Main() {
        int[] otps = new int[10]; 

        // Generate 10 OTPs
        for (int i = 0; i < 10; i++) {
            otps[i] = GenerateOTP();
        }

        // Display the generated OTPs
        Console.WriteLine("Generated OTPs: {0}", string.Join(", ", otps));

        // Check if all OTPs are unique
        bool unique = CheckOTPsUnique(otps);

        Console.WriteLine("Are all OTPs unique? {0}" + unique);
    }
}


//8. Create a program to display a calendar for a given month and year
using System;
class Calendar {
    public static string GetMonthName(int month) {
        string[] monthNames = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };
								
        return monthNames[month - 1];
    }
	
	public static bool CheckLeapYear(int year) {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
	
    public static int GetDaysInMonth(int month, int year) {
        if (month == 2) {
            return CheckLeapYear(year) ? 29 : 28;
        }
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		
        return days[month - 1];
    }


    public static int GetFirstDayOfMonth(int month, int year) {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
		
        return (1 + x + (31 * m0) / 12) % 7;
    }

    public static void DisplayCalendar(int month, int year) {
        Console.WriteLine("{0} {1}" , GetMonthName(month) , year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int days = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        for (int i = 0; i < firstDay; i++) {
            Console.Write("    ");
        }

        for (int day = 1; day <= days; day++) {
            Console.Write("{0,3} ", day);
            if ((day + firstDay) % 7 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main(string[] args) {
        Console.WriteLine("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}


//9. a program Euclidean distance between two points as well as the equation of the line using those two points. 
using System;
class EuclideanDistance {
    // Method to calculate the Euclidean distance between two points
    public static double CalculateDistance(double x1, double y1, double x2, double y2) {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		
        return distance;
    }

    // Method to calculate the slope and y-intercept of a line passing through two points
    public static double[] GetLineEquation(double x1, double y1, double x2, double y2) {
        double slope = (y2 - y1) / (x2 - x1); 
        double yIntercept = y1 - slope * x1; 
		
        return new double[] { slope, yIntercept }; 
    }

    public static void Main() {
        // Input for two points
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance: {0}" , distance);

        // Calculate line equation
        double[] lineEquation = GetLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of the Line: y = {0} * x + {1}" , lineEquation[0] ,lineEquation[1]);
    }
}

//10. a program to find the 3 points that are collinear using the slope formulae and area of triangle formulae
using System;

class CollinearityChecker {
    // Method to check collinearity using the slope formula
    public static bool CheckCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3) {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return (slopeAB == slopeAC && slopeAB == slopeBC);
    }

    // Method to check collinearity using the area of the triangle formula
    public static bool CheckCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3) {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) == 0; 
    }

    public static void Main() {
        // Input for three points
        Console.Write("Enter x1, y1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter x2, y2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter x3, y3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Check collinearity using slope formula
        bool collinearSlope = CheckCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Collinear using Slope Formula: {0}" , collinearSlope);

        // Check collinearity using area formula
        bool collinearArea = CheckCollinearUsingArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Collinear using Area Formula: {0}" , collinearArea);
    }
}


//11. a program to find the bonus of 10 employees based on their years of service as well as 
//the total bonus amount the 10-year-old company Zara has to pay as a bonus, along with the old and new salary.
using System;

public class BonusAmount {
    // Generates random salaries (5-digit) and years of service for employees
    public static double[,] GenerateEmployeeData(int numEmployees) {
        double[,] employeeData = new double[numEmployees, 2];
        Random random = new Random();

        for (int i = 0; i < numEmployees; i++) {
            // Generate a random 5-digit salary
            employeeData[i, 0] = random.Next(10000, 100000);

            // Generate random years of service
            employeeData[i, 1] = random.Next(1, 11);
        }

        return employeeData;
    }

    // Calculates the bonus and new salary for each employee
    public static double[,] CalculateBonusAndNewSalary(double[,] employeeData, int numEmployees) {
        double[,] updatedData = new double[numEmployees, 2];

        for (int i = 0; i < numEmployees; i++) {
            // Extract salary and years of service
			
            double salary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonus;

            // Calculate bonus based on years of service
            if (yearsOfService > 5) {
                bonus = salary * 0.05;
            }
            else {
                bonus = salary * 0.02; 
            }

            // Calculate new salary
            double newSalary = salary + bonus;

            // Store bonus and new salary in the array
            updatedData[i, 0] = bonus;
            updatedData[i, 1] = newSalary;
        }

        return updatedData;
    }

    // Displays the employee details along with total salary and bonus amounts
    public static void DisplayResults(double[,] employeeData, double[,] updatedData, int numEmployees)
{
    double totalOldSalary = 0, totalBonus = 0, totalNewSalary = 0;

    // Print table header
    Console.WriteLine("Employee\tSalary\t\tYears\t\tBonus\t\tNew Salary");

    for (int i = 0; i < numEmployees; i++){
        // Extract details
        double salary = employeeData[i, 0];
        double yearsOfService = employeeData[i, 1];
        double bonus = updatedData[i, 0];
        double newSalary = updatedData[i, 1];

        // Print details in a single line
        Console.WriteLine("{0}\t\t{1:F2}\t{2}\t\t{3:F2}\t\t{4:F2}", i + 1, salary, yearsOfService, bonus, newSalary);

        // Update totals
        totalOldSalary += salary;
        totalBonus += bonus;
        totalNewSalary += newSalary;
    }

    // Print totals
    Console.WriteLine("Total\t\t{0:F2}\t\t\t{1:F2}\t{2:F2}", totalOldSalary, totalBonus, totalNewSalary);
}

	
	public static void Main() {
        // Number of employees
        int numEmployees = 10;

        // Generate random salary and years of service for employees
        double[,] employeeData = GenerateEmployeeData(numEmployees);

        // Calculate bonuses and new salaries
        double[,] updatedData = CalculateBonusAndNewSalary(employeeData, numEmployees);

        // Display results and totals
        DisplayResults(employeeData, updatedData, numEmployees);
    }
}


//12. take input marks of students in 3 subjects physics, chemistry, and maths. Compute the total, average, and the percentage score 
using System;

class  StudentsMarks{
    // Method to generate random marks for Physics, Chemistry, and Mathematics for each student
    public static int[,] GenerateMarks(int numStudents) {
        int[,] marks = new int[numStudents, 3];
        Random random = new Random();

        for (int i = 0; i < numStudents; i++) {
            // Generate random marks for Physics, Chemistry, and Mathematics
            marks[i, 0] = random.Next(50, 101);  
            marks[i, 1] = random.Next(50, 101);  
            marks[i, 2] = random.Next(50, 101);  
        }
        return marks;
    }

    // Method to calculate the total, average, and percentage for each student
    public static double[,] CalculateResults(int[,] marks, int numStudents) {
        double[,] results = new double[numStudents, 3];  

        for (int i = 0; i < numStudents; i++) {
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2]; 
            double averageMarks = totalMarks / 3.0;  
            double percentage = Math.Round((totalMarks / 300.0) * 100, 2); 

            results[i, 0] = totalMarks;
            results[i, 1] = Math.Round(averageMarks, 2);  
            results[i, 2] = percentage;
        }

        return results;
    }

    // Method to display the scorecard in a tabular format
    public static void DisplayResults(int[,] marks, double[,] results, int numStudents) {
        // Display table headers
        Console.WriteLine("Student\tPhysics\tChemistry\tMathematics\tTotal\t\tAverage\t\tPercentage");

        for (int i = 0; i < numStudents; i++) {
            // Extract individual student details
            int physics = marks[i, 0];
            int chemistry = marks[i, 1];
            int mathematics = marks[i, 2];
            double total = results[i, 0];
            double average = results[i, 1];
            double percentage = results[i, 2];

            // Display the student results in a tabular format
            Console.WriteLine((i + 1)+"  "+physics+"   "+chemistry+"  "+mathematics+"  "+total+"  "+average+"   "+percentage+"%");
        }
    }
	
	public static void Main() {
        // Prompt for the number of students
        Console.WriteLine("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Generate random marks for Physics, Chemistry, and Mathematics
        int[,] studentMarks = GenerateMarks(numStudents);

        // Calculate total, average, and percentage for each student
        double[,] studentResults = CalculateResults(studentMarks, numStudents);

        // Display the scorecard in tabular format
        DisplayResults(studentMarks, studentResults, numStudents);
    }

}



//13. A program to perform matrix manipulation operations like addition, subtraction, multiplication, and transpose. 
using System;

class Matrix {
    // Create a random matrix with specified rows and columns
    public static double[,] CreateRandomMatrix(int rows, int cols) {
        Random rand = new Random();
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i, j] = rand.Next(1, 10); 
			}
		}
        return matrix;
    }

    // Add two matrices
    public static double[,] AddMatrices(double[,] A, double[,] B, int rows, int cols) {
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i, j] = A[i, j] + B[i, j];
			}
		}
        return result;
    }

    // Subtract two matrices
    public static double[,] SubtractMatrices(double[,] A, double[,] B, int rows, int cols) {
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i, j] = A[i, j] - B[i, j];
			}
		}
        return result;
    }

    // Multiply two matrices
    public static double[,] MultiplyMatrices(double[,] A, double[,] B, int rows, int colsA, int colsB) {
        double[,] result = new double[rows, colsB];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += A[i, k] * B[k, j];
        return result;
    }

    // Transpose a matrix
    public static double[,] TransposeMatrix(double[,] matrix, int rows, int cols) {
        double[,] result = new double[cols, rows];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[j, i] = matrix[i, j];
			}
		}
        return result;
    }

    // Determinant of a 2x2 matrix
    public static double Determinant2x2(double[,] matrix) {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Determinant of a 3x3 matrix
    public static double Determinant3x3(double[,] matrix) {
        double a = matrix[0, 0], b = matrix[0, 1], c = matrix[0, 2];
        double d = matrix[1, 0], e = matrix[1, 1], f = matrix[1, 2];
        double g = matrix[2, 0], h = matrix[2, 1], i = matrix[2, 2];

        return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
    }

    // Inverse of a 2x2 matrix
    public static double[,] Inverse2x2(double[,] matrix) {
        double det = Determinant2x2(matrix);
        if (det == 0) return null; 
        double[,] result = new double[2, 2];
        result[0, 0] = matrix[1, 1] / det;
        result[0, 1] = -matrix[0, 1] / det;
        result[1, 0] = -matrix[1, 0] / det;
        result[1, 1] = matrix[0, 0] / det;
        return result;
    }

    // Inverse of a 3x3 matrix
    public static double[,] Inverse3x3(double[,] matrix) {
        double det = Determinant3x3(matrix);
        if (det == 0) return null; 
        double[,] result = new double[3, 3];

        result[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / det;
        result[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / det;
        result[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / det;

        result[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / det;
        result[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / det;
        result[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / det;

        result[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / det;
        result[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / det;
        result[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / det;

        return result;
    }

    // Display matrix
    public static void DisplayMatrix(double[,] matrix, int rows, int cols, string label = "Matrix") {
        Console.WriteLine(label);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Main() {
        // Define matrix dimensions
        int rows = 3;
        int cols = 3;

        // Create random 3x3 matrices
        double[,] matrixA = CreateRandomMatrix(rows, cols);
        double[,] matrixB = CreateRandomMatrix(rows, cols);

        // Display matrices
        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA, rows, cols);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB, rows, cols);

        // Perform operations and display results
        DisplayMatrix(AddMatrices(matrixA, matrixB, rows, cols), rows, cols, "A + B");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB, rows, cols), rows, cols, "A - B");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB, rows, cols, cols), rows, cols, "A * B");
        DisplayMatrix(TransposeMatrix(matrixA, rows, cols), rows, cols, "Transpose of A");

        // For 3x3 matrices, calculate determinant and inverse
        Console.WriteLine("Determinant of A: " + Determinant3x3(matrixA));
        DisplayMatrix(Inverse3x3(matrixA), 3, 3, "Inverse of A");
    }
}
*/