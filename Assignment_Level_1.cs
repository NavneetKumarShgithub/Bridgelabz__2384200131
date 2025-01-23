/*1.  check if a number is divisible by 5
using System;
class Number_divisible{
	static void Main(string[] args){
		Console.Write("Enter a number: ");
		// enter a number
		int number = Convert.ToInt32(Console.ReadLine());
		
		// a number divisible by 5 or not
		if(number % 5 == 0){
			Console.WriteLine("The number is divisible by 5.");
		}else{
			Console.WriteLine("The number is not divisible by 5.");
		}
	}
}

//2. Check if the first is the smallest of the 3 numbers.
using System;
class First_number_is_smaller{
	static void Main(string[] args){
		// Enter number1, number2 and number3
		Console.Write("Enter the value of all three numbers Number1: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the value number2: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the value number3: ");
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		//To check first number1 is smallest of the three number
		if(number1< number2 && number1<number3){
			Console.WriteLine(" Is the first number the smallest? Yes");
		}else{
			Console.WriteLine(" Is the first number the smallest? No");
		}
		
	}
}

//3. Check if the first, second, or third number is the largest of the three
using System;
class Check_largest_number{
	static void Main(string[] args){
	    // Enter number1, number2 and number3
		Console.Write("Enter the value of all three numbers Number1: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the value number2: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the value number3: ");
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		//Check if the first, second, or third number is the largest of the three
		if(number1 > number2 && number1 > number3){
			Console.WriteLine("Is the first number the largest? Yes");
		}else if(number2 > number1 && number2 > number3){
			Console.WriteLine("Is the Second number the largest? Yes");
		}else{
			Console.WriteLine("Is the third number the largest? Yes");
		}
	}
}

//4.check for the natural number and write the sum of n natural numbers
using System;
class Natural_number_And_Sum{
	static void Main(string[] args){
		// enter a number
		Console.Write("Enter a Number: ");
		int Number = Convert.ToInt32(Console.ReadLine());
		
		//check for the natural number
		if(Number > 0){
			Console.WriteLine("the number is natural number");
			
			//if number is natural number than sum of n natural number
			int sum = Number*(Number + 1)/2;
			Console.WriteLine("The sum of "+Number+" natural numbers is "+sum);
		}
		//if number is natural number than sum of n natural number
		else {
			Console.WriteLine("The number "+Number+" is not a natural number");
		}
		
	}
}

//5. Check if a person can vote
using System;
class Person_can_vote
{
    static void Main(string[] args)
    {
        // enter the age 
        Console.Write("Enter the person age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Check if the person can vote
        if (age >= 18)
        {
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }
        else
        {
            Console.WriteLine("The person's age is "+age+" and cannot vote.");
        }
    }
}

//6. To check whether a number is positive, negative, or zero
using System;
class Check_a_number
{
	static void Main(string[] args)
	{
		// Enter a number
		Console.Write("Enter a Number: ");
		int Number = Convert.ToInt32(Console.ReadLine());
		
		// check whether a number is positive, negative, or zero
		if(Number > 0)
		{
			Console.WriteLine("Positive Number");
		}else if(Number < 0)
		{
			Console.WriteLine("Negative Number");
		}else
		{
			Console.WriteLine("Zero");
		}
	}
}

//7. Check for Spring Season
using System;
class Check_Spring
{
    static void Main(string[] args)
    {   
	    // enter month number 
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
		
         // enter day in between 1 to 31
        Console.Write("Enter day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());
           
		// Checkout for Spring Season
        if ((month >=1 && month <=12) 
		|| (month == 3 && day>=20 && day<= 31) 
		|| (month == 4 && 1<= day && day <=30) 
		|| (month == 5 && 1<= day && day <=31) 
		|| (month == 6 && 1<= day && day <= 20))
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}

//8: Countdown Using While Loop
using System;
class Countdown
{
    static void Main(string[] args)
    {
		//enter the coutdown start number
        Console.Write("Enter the countdown start value: ");
        int number = Convert.ToInt32(Console.ReadLine());
		
		// using while loop the for continous  
        while (number > 0)
        {
            Console.WriteLine(number);
            number--;
        }
		
        // output
        Console.WriteLine("Rocket Launch!");
    }
}


//9: Countdown Using For Loop
using System;
class Countdown
{
    static void Main(string[] args)
    {
		// enter the number count down start
        Console.Write("Enter the countdown start value: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = number; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        
		//output
        Console.WriteLine("Rocket Launch!");
    }
}

//10: Sum Until User Enters Zero
using System;
class SumUntilZero
{
    static void Main(string[] args)
    {
        double total = 0.0;//initialize total to 0.0
        double number;// variable to store user input

        // loop  until number is zero
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            number = Convert.ToDouble(Console.ReadLine());
            total += number;
        } while (number != 0);

        // output total sum
        Console.WriteLine("Total sum: " + total);
    }
}

//11. Sum Until User Enters Zero or negative
using System;
class SumUntilZeroOrNegative
{
    static void Main(string[] args)
    {
        double total = 0.0; // Initialize total to 0.0
        double userInput; // Variable to store user input

        Console.WriteLine("Enter numbers to sum. Enter 0 or a negative number to stop.");

        // Infinite loop
        while (true)
        {
            userInput = Convert.ToDouble(Console.ReadLine()); // Read user input
            if (userInput <= 0) // Check if input is 0 or negative
            {
                break; // Exit the loop
            }
            total += userInput; // Add user input to total
        }

        // output total sum
        Console.WriteLine("The total sum is: "+ total);
    }
}

//12. Sum of natural numbers
using System;
class SumOfNaturalNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine()); // Read user input

        if (n <= 0)
        {
            Console.Write("The number is not a natural number.");
            return;
        }

        // Calculate sum using formula
        int formulaSum = n * (n + 1) / 2;

        // Calculate sum using while loop
        int loopSum = 0;
        int i = 0;
        while (i <= n)
        {
            loopSum += i;
            i++;
        }

        // Display the results
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Sum using while loop: " + loopSum);

        // Compare the results
        if (formulaSum == loopSum)
        {
            Console.WriteLine("Both computations are correct.");
        }
        else
        {
            Console.WriteLine("There is a difference between the computations.");
        }
    }
}

//13. Sum of natural number using for loop
using System;
class SumOfNaturalNumbersForLoop
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a natural number:");
        int n = int.Parse(Console.ReadLine()); // Read user input

        if (n <= 0)
        {
            Console.Write("The number is not a natural number."); 
			return;
        }

        // Calculate sum using formula
        int formulaSum = n * (n + 1) / 2;

        // Calculate sum using for loop
        int loopSum = 0;
        for (int i = 1; i <= n; i++)
        {
            loopSum += i;
        }

        // output
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Sum using for loop: " + loopSum);

        // Compare the results
        if (formulaSum == loopSum)
        {
            Console.WriteLine("Both computations are correct.");
        }
        else
        {
            Console.WriteLine("There is a discrepancy between the computations.");
        }
    }
}


//14. find the factorial of an integer entered by the user
using System;
class FactorialWhileLoop
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer:");
        int n = Convert.ToInt32(Console.ReadLine()); // Read user input

        if (n < 0)
        {
            Console.WriteLine("The number is not a positive integer.");
            return;
        }

        // Calculate factorial using while loop
        int factorial = 1;
        int i = 1;
        while (i <= n)
        {
            factorial = factorial*i;
            i++;
        }

        // Display the result
        Console.WriteLine("The factorial of " + n + " is: " + factorial);
    }
}

//15. find the factorial of an integer entered by the user using for loop
using System;
class FactorialForLoop
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer:");
        int n = int.Parse(Console.ReadLine()); // Read user input

        if (n < 0)
        {
            Console.WriteLine("The number is not a positive integer.");
            return;
        }

        // Calculate factorial using for loop
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial* i;
        }

        // Display the result
        Console.WriteLine("The factorial of " + n + " is: " + factorial);
    }
}

//16. Odd and even numbers between 1 to the number entered by the user
using System;
class OddandEven
{
	static void Main(string[] args)
	{
		// enter a number 
		Console.Write("Enter the number to find the odd and even numbers upto user enter number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		// check the number is natural number
		if(n<=0)
		{
			Console.WriteLine("the user enter number is not natural number. ");
			return;
		}
		// find the odd and even number using for loop
		for(int i=1; i<=n; i++)
		{
			if (i % 2 == 0)
            {
                Console.WriteLine(i + " is an even number.");
            }
            else
            {
                Console.WriteLine(i + " is an odd number.");
            }
		}
	}
}

//17. the bonus of employees based on their years of service
using System;
class EmployeeBonus
{
    static void Main(string[] args)
    {
        Console.Write("Enter the salary:");
        double salary = Convert.ToDouble(Console.ReadLine()); // Read salary input

        Console.Write("Enter the years of service:");
        int yearsOfService = Convert.ToInt32(Console.ReadLine()); // Read years of service input

        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05; // Calculate 5% bonus
            Console.WriteLine("The bonus amount is: " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus for less than 5 years of service.");
        }
    }
}

//18. the multiplication table of a number entered by the user from 6 to 9
using System;
class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine()); // Read user input

        // Iterate from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
*/