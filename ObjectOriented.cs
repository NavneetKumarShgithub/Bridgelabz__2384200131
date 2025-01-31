/*
//1. Program to Display Employee Details
using System;
class Employee
{
    // Attributes
    private string name;
    private int id;
    private double salary;

    // Constructor to initialize the attributes
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display the employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Name  : "+name);
        Console.WriteLine("ID    : "+id);
        Console.WriteLine("Salary: "+salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee("Rohan Kumar", 12345, 50000);

        // Display the employee details
        employee.DisplayDetails();
    }
}


//2. Program to Compute Area of a Circle
using System;
class Circle
{
    // Attribute
    private double radius;

    // Constructor to initialize the radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate the area of the circle
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate the circumference of the circle
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display the area and circumference of the circle
    public void DisplayDetails()
    {
        Console.WriteLine("Radius       : "+radius);
        Console.WriteLine("Area         : "+CalculateArea());
        Console.WriteLine("Circumference: "+CalculateCircumference());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Circle object
        Circle circle = new Circle(5.0);

        // the details of the circle
        circle.DisplayDetails();
    }
}


//3. Program to Handle Book Details
using System;
class Book
{
    // Attributes
    private string title;
    private string author;
    private double price;

    // Constructor to initialize the attributes
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display the book details
    public void DisplayDetails()
    {
        Console.WriteLine("Title : "+title);
        Console.WriteLine("Author: "+author);
        Console.WriteLine("Price : "+price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Book object
        Book book = new Book("The Post Office", "Rabindra Nath Tagore", 100.99);

        // Display the book details
        book.DisplayDetails();
    }
}
*/