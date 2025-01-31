/*
//0.
using System;
using System.Globalization; 
class DateTimeExample 
{	
 static void Main() 
 { 
 // Step 1: Input date in dd-MM-yyyy format 
 Console.Write("Enter a date (dd-MM-yyyy): ");
 string inputDate = Console.ReadLine(); 
 // Step 2: Parse input date using DateTime.ParseExact 
 DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", CultureInfo.InvariantCulture); 
 // Step 3: Find the day of the week 
 Console.WriteLine("Day of the Week: " + date.DayOfWeek); 
 // Step 4: Calculate the difference between input date and current date  
 DateTime currentDate = DateTime.Now; 
 TimeSpan difference = currentDate - date; 
 Console.WriteLine("Days between input date and current date: " + difference.Days); 
 // Step 5: Display the current date and time in a formatted way  
Console.WriteLine("Current Date and Time: " + currentDate.ToString("dd-MM-yyyy HH:mm:ss")); 
 } 
} 

//1.
using System; 
using System.Globalization; 
class DateTimeExample 
{	
 static void Main() 
 { 
 // Step 1: Get user input date in dd-MM-yyyy format 
 string inputDate = GetInputDate(); 
 // Step 2: Parse the input date to DateTime 
 DateTime parsedDate = ParseDate(inputDate); 
 // Step 3: Find and display the day of the week for the input date  DisplayDayOfWeek(parsedDate); 
 // Step 4: Calculate and display the number of days between input date and current date 
 DisplayDaysBetween(parsedDate);
 // Step 5: Display the current date and time in a formatted way  DisplayCurrentDateTime(); 
 } 
 // Step 1: Function to get user input 
 static string GetInputDate() 
 { 
 Console.WriteLine("Enter a date (dd-MM-yyyy): "); 
 return Console.ReadLine(); 
 } 
 // Step 2: Function to parse the input date 
 static DateTime ParseDate(string inputDate) 
 { 
 return DateTime.ParseExact(inputDate, "dd-MM-yyyy", 
CultureInfo.InvariantCulture); 
 } 
 // Step 3: Function to display the day of the week for the input date  static void DisplayDayOfWeek(DateTime date) 
 { 
 Console.WriteLine("Day of the Week: " + date.DayOfWeek);  } 
 // Step 4: Function to display the number of days between the input date and the current date 
 static void DisplayDaysBetween(DateTime date) 
 { 
 DateTime currentDate = DateTime.Now; 
 TimeSpan difference = currentDate - date; 
 Console.WriteLine("Days between input date and current date: " + difference.Days); 
 } 
 // Step 5: Function to display the current date and time in a formatted way  static void DisplayCurrentDateTime() 
 { 
 DateTime currentDateTime = DateTime.Now; 
 Console.WriteLine("Current Date and Time: " + 
currentDateTime.ToString("dd-MM-yyyy HH:mm:ss")); 
 } 
}


//1. Write a program that displays the current time in different time 
using System;
class TimeZoneDisplay
{
    static void Main(string[] args)
    {
        // Get the current time in UTC
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;
        Console.WriteLine("Current UTC time: "+utcTime);

        // Display time in GMT (Greenwich Mean Time)
        TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
        Console.WriteLine("Current GMT time: "+gmtTime);

        // Display time in IST (Indian Standard Time)
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        Console.WriteLine("Current IST time: "+istTime);

        // Display time in PST (Pacific Standard Time)
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);
        Console.WriteLine("Current PST time: "+pstTime);
		
		// DISPLAY TIME IN CST (China standard time)
		TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("China standard time");
		DateTimeOffset cstTime = TimeZoneInfo.ConvertTime(utcTime , cstZone);
		Console.WriteLine("Current CST time: "+cstTime);
    }
}


//2. Create a program that: 
//Takes a date input and adds 7 days, 1 month, and 2 years to it.
//Then subtracts 3 weeks from the result. 

using System;
class DateArithmetic
{
    static void Main(string[] args)
    {
        // Take user input for the date
        Console.WriteLine("Enter a date (yyyy-mm-dd):");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        // Add 7 days, 1 month, and 2 years to the input date
        DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        Console.WriteLine("Date after adding 7 days, 1 month, and 2 years: "+modifiedDate.ToString("yyyy-MM-dd"));

        // Subtract 3 weeks from the modified date
        DateTime finalDate = modifiedDate.AddDays(-21);
        Console.WriteLine("Date after subtracting 3 weeks: "+finalDate.ToString("yyyy-MM-dd"));
    }
}


//3.Write a program that: 
//Displays the current date in three different formats: 

using System;
using System.Globalization;
class DateFormatting
{
    static void Main(string[] args)
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Display the current date in dd/MM/yyyy format
        string format1 = currentDate.ToString("dd/MM/yyyy");
        Console.WriteLine("Current date in dd/MM/yyyy format: "+format1);

        // Display the current date in yyyy-MM-dd format
        string format2 = currentDate.ToString("yyyy-MM-dd");
        Console.WriteLine("Current date in yyyy-MM-dd format: "+format2);

        // Display the current date in EEE, MMM dd, yyyy format
        string format3 = currentDate.ToString("ddd, MMM dd, yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Current date in EEE, MMM dd, yyyy format: "+format3);
    }
}


//4. Write a program that: 
// Takes two date inputs and compares them to check if the first date is before, after, or the same as the second date.

using System;
class DateComparison
{
    static void Main(string[] args)
    {
        // Take user input for the first date
        Console.WriteLine("Enter the first date (yyyy-mm-dd):");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        // Take user input for the second date
        Console.WriteLine("Enter the second date (yyyy-mm-dd):");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        // Compare the two dates using DateTime.Compare()
        int comparisonResult = DateTime.Compare(date1, date2);

        // Output the result
        if (comparisonResult < 0)
        {
            Console.WriteLine("The first date "+date1.ToString("yyyy-MM-dd")+" is before the second date "+date2.ToString("yyyy-MM-dd"));
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("The first date "+date1.ToString("yyyy-MM-dd")+" is after the second date "+date2.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("The first date "+date1.ToString("yyyy-MM-dd")+" is the same as the second date "+date2.ToString("yyyy-MM-dd"));
        }
    }
}
*/
