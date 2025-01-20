//    Assisted Problems
//1. Welcome to Bridgelabz
using System;
class First_program{
	static void Main(string[] args){
		Console.WriteLine("Welcome to Bridgelabz");
	}
}

//2. Add two numbers
using System;
class Addition{
	static void Main(string[] args){
		Console.Write("Enter your two numbers: ");
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int sum = num1 + num2;
		Console.WriteLine("Sum of two numbers: " + sum);
	}
}

//3. Celsius to Fahrenheit Conversion
using System;
class Temperature{
	static void Main(string[] args){
		Console.Write("Enter temperature in celsius: ");
		double Celsius = double.Parse(Console.ReadLine());
		double Fahrenheit = (Celsius * 9/5) + 32;
		Console.WriteLine("	temperatureemperature in Fahrenheit: " + Fahrenheit);
	}
}

//4. Area of circle
using System;
class Circle{
	static void Main(string[] args){
		double Radius, Area;
		Console.Write("Enter the radius of the circle: " );
		Radius = double.Parse(Console.ReadLine());
		Area = Math.PI * Radius * Radius;
		Console.WriteLine("Area of the circle is: " + Area);
		} 
}

//5.Volume of the Cylinder
using System;
class Cylinder{
	static void Main(string[] args){
		double radius, height, Volume;
		Console.Write("Enter the radius of cylinder: ");
		radius = Convert.ToInt(Console.ReadLine());
		Console.Write("Enter the height if cylinder: ");
		height = Convert.ToInt(Console.ReadLine());
		Volume = Math.PI * radius*radius*height;
		Console.WriteLine("Volume of the cylinder: " + Volume);
	}
}

//6.Calculate Simple Interest
using System;
class Simple_Interest{
	static void Main(string[] args){
		double principal, rate, time, Simple_Interest;
		Console.Write("Enter the principal amount: ");
		principal = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the rate of interest: ");
		rate = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the time: ");
		time = Convert.ToDouble(Console.ReadLine());
		Simple_Interest = (principal*rate*time)/100;
		Console.WriteLine("Simple_Interest: "+ Simple_Interest);
	}
}

//7.Perimeter of the Rectangle
using System;
class Rectangle{
	static void Main(string[] args){
		double length, width, perimeter;
		Console.Write("Enter the length: ");
		length = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the width: ");
		width = Convert.ToDouble(Console.ReadLine());
		perimeter = 2*(length + width);
		Console.WriteLine("Perimeter of the Rectangle: "+ perimeter);
	}
}

//8.Power Calculation
using System;
class Power{
    static void Main(){
		double baseNum, exponent, result;
        Console.Write("Enter the Base number: ");
        baseNum = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the Exponent: ");
        exponent = Convert.ToDouble(Console.ReadLine());
		result = Math.Pow(baseNum, exponent);
		Console.WriteLine("Result: "+ result);
    }
}

//9.Calculate average of three numbers
using System;
class Average{
    static void Main(){
		double num1, num2, num3, average;
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the third number: ");
        num3 = Convert.ToDouble(Console.ReadLine());
		average = (num1 + num2 + num3) / 3;
		Console.WriteLine("Average: "+ average);
    }
}

//10.Convert kilometer to miles
using System;
class Program{
    static void Main(){
		double kilometers, miles;
        Console.Write("Enter distance in Kilometers: ");
        kilometers = Convert.ToDouble(Console.ReadLine());
		miles = kilometers * 0.621371;
		Console.WriteLine("Kilometers into miles: "+ miles);
    }
}