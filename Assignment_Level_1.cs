// 1.Current age of Harry
// using System;
// class AgeOfHarry{
	// static void Main(string[] args){
	// double Current_year, Birth_year, age_of_harry;
	// Birth_year = 2000;
	// Current_year = 2024;
	// age_of_harry = Current_year - Birth_year;
	// Console.WriteLine("Harry's age in 2024 is " + age_of_harry);
	// }
// }

// 2.Average percentage Mark in PCM
// using System;
// class Average_Percent{
	// static void Main(string[] args){
		// double average, maths_mark, chemistry_mark, physics_mark;
		// maths_mark = 94;
		// chemistry_mark = 96;
		// physics_mark = 95;
		// average = (maths_mark + chemistry_mark + physics_mark)/3;
		// Console.WriteLine("Sam’s average mark in PCM is " + average);
	// }
// }

// 3.Convert distance into miles
// using System;
// class Convert_distance{
	// static void Main(string[] args){
		// double kilometer, miles;
		// kilometer = 10.8;
		// miles = kilometer/1.6;
		// Console.WriteLine("The distance "+kilometer+" km in miles is "+miles);
	// }
// }

// 4.Calculate profit and loss
// using System;
// class Cal_Profit_loss{
	// static void Main(string[] args){
		// double cost_price = 129, selling_price = 191, profit, profit_percentage;
		// profit = selling_price - cost_price;
		// profit_percentage = (profit/cost_price)*100;
		// Console.WriteLine("The Cost Price is INR "+cost_price+ " and Selling Price is INR "+selling_price+"\nThe Profit is INR "+profit+" and the Profit Percentage is "+ profit_percentage);
	// }
// }

// 5.Divides pens among Students
// using System;
// class Student{
	// static void Main(string[] args){
		// int total_pens = 14, total_students = 3;
		// int pens_per_student = total_pens/total_students;
		// int remaining_pens = total_pens%total_students;
		// Console.WriteLine("The Pen Per Student is "+pens_per_student+ " and the remaining pen not distributed is "+remaining_pens);
	// }
// }

// 6. Discounted Fee Calculation
// using System;
// class Calculate_Discount{
    // static void Main(string[] args) {
        // double fee = 125000;
        // double discountPercent = 10;
        // double discount = (discountPercent / 100) * fee;
        // double discountedFee = fee - discount;
		// Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+discountedFee);
    // }
// }

// 7.Volume of Earth
// using System;
// class Volume_of_Earth {
    // static void Main(string[] args) {
        // double radius = 6378; // in km
        // double volumeKm = (4/3) * Math.PI * Math.Pow(radius, 3);//volume in cubic kilometers
        // double volumeMiles = volumeKm / Math.Pow(1.6, 3);
		// Console.WriteLine("The volume of earth in cubic kilometers is "+volumeKm+ "and cubic miles is " +volumeMiles);
    // }
// }

// 8.Convert distance kilometes into miles
// using System;
// class Kilometer_into_miles {
    // static void Main(string[] args) {
        // Console.Write("Enter distance in kilometers: ");
        // double kilometers = Convert.ToDouble(Console.ReadLine());
        // double miles = kilometers / 1.6;

        // Console.WriteLine("The total miles is "+miles+ "mile for the given "+kilometers+ "km");
    // }
// }

// 9.Discounted Fee Calculation
// using System;

// class Program {
    // static void Main() {
		//user enter the fee
        // Console.Write("Enter the fee: ");
        // double fee = Convert.ToDouble(Console.ReadLine());
        ////user enter the discountPercent
        // Console.Write("Enter the discount percentage: ");
        // double discountPercent = Convert.ToDouble(Console.ReadLine());
		////find the discount using formula
        // double discount = (discountPercent / 100) * fee;
        // double discountedFee = fee - discount;

        // Console.WriteLine("The discount amount is INR " +discount+ " and final discounted fee is INR "+discountedFee);
    // }
// }


// 10. Height Conversion
// using System;
// class Program {
    // static void Main() {
		////user enter the height in cm
        // Console.Write("Enter your height in cm: ");
        // double heightCm = Convert.ToDouble(Console.ReadLine());
        ////convert the height in cm to inches
        // double totalInches = heightCm / 2.54;
		////convert the inches into feet
        // int feet = (int)(totalInches / 12);
        // double inches = totalInches % 12;

        // Console.WriteLine("Your Height in cm is "+heightCm+ " while in feet is "+feet+ " and inches is "+inches);
//     }
// }

// 11.Basic calculator
// using System;

// class BasicCalculator
// {
    // static void Main()
    // {
        // user enter the two numbers
        // Console.Write("Enter the first number: ");
        // float number1 = float.Parse(Console.ReadLine());
        // Console.Write("Enter the second number: ");
        // float number2 = float.Parse(Console.ReadLine());

        // arithmetic operations
        // float addition = number1 + number2;
        // float subtraction = number1 - number2;
        // float multiplication = number1 * number2;
        // float division = number1 / number2;

        // Print result
        // Console.WriteLine("The addition, subtraction, multiplication, and division of "+number1+ "and" +number2+ "are" +addition+","+subtraction+"," +multiplication+"," +division+ "respectively.");
    // }
// }

//12. Area of a Triangle
using System;
class TriangleArea
{
    static void Main()
    {
        ////Taking base and height as input
        Console.Write("Enter the base of the triangle (in cm): ");
        double baseValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle (in cm): ");
        double height = Convert.ToDouble(Console.ReadLine());

       //// Calculating area
        double area = 0.5f * baseValue * height;

        /////Print result
        Console.WriteLine("The area of the triangle is "+area+ "square cm.");
    }
}

//13. Side of a Square

// using System;
// class SquareSide
// {
    // static void Main()
    // {
        // Taking perimeter as input
        // Console.Write("Enter the perimeter of the square: ");
        // float perimeter = float.Parse(Console.ReadLine());

        // Calculating side length
        // float side = perimeter / 4;

        // Print result
        // Console.WriteLine("The length of the side is "+side+ " whose perimeter is "+perimeter);
    // }
// }

//14.Distance Conversion

// using System;
// class DistanceConversion
// {
    // static void Main()
    // {
        // Taking distance in feet as input
        // Console.Write("Enter the distance in feet: ");
        // float distanceInFeet = float.Parse(Console.ReadLine());

        // Calculating yards and miles
        // float yards = distanceInFeet / 3;
        // float miles = yards / 1760;

        // Print result
        // Console.WriteLine("The distance is " +yards+ " yards or "+miles+" miles.");
    // }
// }

//15. Total Purchase Price

// using System;
// class TotalPrice
// {
    // static void Main()
    // {
        // Taking unit price and quantity as input
        // Console.Write("Enter the unit price of the item (INR): ");
        // float unitPrice = float.Parse(Console.ReadLine());
        // Console.Write("Enter the quantity: ");
        // int quantity = int.Parse(Console.ReadLine());

        // Calculating total price
        // float totalPrice = unitPrice * quantity;

        // Print results
        // Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity is "+quantity+ " and unit price is INR "+unitPrice);
    // }
// }

//16.Maximum Handshakes
// using System;
// class Handshakes
// {
    // static void Main()
    // {
        //Taking number of students as input
        // Console.Write("Enter the number of students: ");
        // int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        //Calculating maximum handshakes using combination formula
        // int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        //Print result
        // Console.WriteLine("The maximum number of handshakes among "+numberOfStudents+ " students is "+handshakes);
//     }
// }