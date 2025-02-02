/*
//1. Create a Book class with attributes title, author, and price.
using System;
class Book
{
    // Attributes
    private string title;
    private string author;
    private double price;

    // Default constructor
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
        price = 0.0;
    }

    // Parameterized constructor
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
        // Create a Book object using the default constructor
        Book defaultBook = new Book();
        Console.WriteLine("Default Book Details:");
        defaultBook.DisplayDetails();

        // Create a Book object using the parameterized constructor
        Book parameterizedBook = new Book("The Discovery oF India", "Jawaharlal Nehru", 100);
        Console.WriteLine("\nParameterized Book Details:");
        parameterizedBook.DisplayDetails();
    }
}


//2. Write a Circle class with a radius attribute.
using System;
class Circle
{
    // Attribute
    private double radius;

    // Default constructor
    public Circle() : this(1.0) // Default radius is 1.0
    {
    }

    // Parameterized constructor
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
        // Create a Circle object using the default constructor
        Circle defaultCircle = new Circle();
        Console.WriteLine("Default Circle Details:");
        defaultCircle.DisplayDetails();

        // Create a Circle object using the parameterized constructor
        Circle parameterizedCircle = new Circle(5.0);
        Console.WriteLine("\nParameterized Circle Details:");
        parameterizedCircle.DisplayDetails();
    }
}


//3.Create a Person class with a copy constructor that clones another person's attributes
using System;
class Person
{
    // Attributes
    private string name;
    private int age;
    private string address;

    // Default constructor
    public Person()
    {
        name = "Unknown";
        age = 0;
        address = "Unknown";
    }

    // Parameterized constructor
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Copy constructor
    public Person(Person other)
    {
        this.name = other.name;
        this.age = other.age;
        this.address = other.address;
    }

    // Method to display the person details
    public void DisplayDetails()
    {
        Console.WriteLine("Name   : "+name);
        Console.WriteLine("Age    : "+age);
        Console.WriteLine("Address: "+address);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Person object using the parameterized constructor
        Person person1 = new Person("Tushar", 30, "123 Mathura");

        // Create a Person object using the copy constructor
        Person person2 = new Person(person1);

        // Display the details of both persons
        Console.WriteLine("Person 1 Details:");
        person1.DisplayDetails();

        Console.WriteLine("\nPerson 2 Details:");
        person2.DisplayDetails();
    }
}


//4. Create a HotelBooking class with attributes guestName, roomType, and nights.
using System;
class HotelBooking
{
    // Attributes
    private string guestName;
    private string roomType;
    private int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "Unknown Guest";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    // Method to display the booking details
    public void DisplayDetails()
    {
        Console.WriteLine("Guest Name: "+guestName);
        Console.WriteLine("Room Type: "+roomType);
        Console.WriteLine("Nights: "+nights);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a HotelBooking object using the default constructor
        HotelBooking defaultBooking = new HotelBooking();
        Console.WriteLine("Default Booking Details:");
        defaultBooking.DisplayDetails();

        // Create a HotelBooking object using the parameterized constructor
        HotelBooking parameterizedBooking = new HotelBooking("Tushar Saraswat", "Deluxe", 3);
        Console.WriteLine("\nParameterized Booking Details:");
        parameterizedBooking.DisplayDetails();

        // Create a HotelBooking object using the copy constructor
        HotelBooking copyBooking = new HotelBooking(parameterizedBooking);
        Console.WriteLine("\nCopy Booking Details:");
        copyBooking.DisplayDetails();
    }
}


//5. Create a Book class with attributes title, author, price, and availability.
using System;
class Book
{
    // Attributes
    private string title;
    private string author;
    private double price;
    private bool isAvailable;

    // Default constructor
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
        price = 0.0;
        isAvailable = true;
    }

    // Parameterized constructor
    public Book(string title, string author, double price, bool isAvailable)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = isAvailable;
    }

    // Method to borrow the book
    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("You have successfully borrowed "+title+" by "+author);
        }
        else
        {
            Console.WriteLine("Sorry, "+title+" by "+author+" is currently not available.");
        }
    }

    // Method to display the book details
    public void DisplayDetails()
    {
        Console.WriteLine("Title : "+title);
        Console.WriteLine("Author: "+author);
        Console.WriteLine("Price : "+price);
        Console.WriteLine("Availability: "+(isAvailable ? "Available" : "Not Available"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Book object using the parameterized constructor
        Book book1 = new Book("2002", "The King", 25.99, true);

        // Display the book details
        Console.WriteLine("Book Details:");
        book1.DisplayDetails();

        // Borrow the book
        Console.WriteLine("\nAttempting to borrow the book:");
        book1.BorrowBook();

        // Display the book details again to show the updated availability
        Console.WriteLine("\nUpdated Book Details:");
        book1.DisplayDetails();
    }
}


//6. Create a CarRental class with attributes customerName, carModel, and rentalDays.
using System;
class CarRental
{
    // Attributes
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;

    // Default constructor
    public CarRental()
    {
        customerName = "Unknown Customer";
        carModel = "Unknown Model";
        rentalDays = 0;
        totalCost = 0.0;
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        CalculateTotalCost(dailyRate);
    }

    // Copy constructor
    public CarRental(CarRental other)
    {
        this.customerName = other.customerName;
        this.carModel = other.carModel;
        this.rentalDays = other.rentalDays;
        this.totalCost = other.totalCost;
    }

    // Method to calculate the total cost
    private void CalculateTotalCost(double dailyRate)
    {
        totalCost = rentalDays * dailyRate;
    }

    // Method to display the rental details
    public void DisplayDetails()
    {
        Console.WriteLine("Customer Name: "+customerName);
        Console.WriteLine("Car Model    : "+carModel);
        Console.WriteLine("Rental Days  : "+rentalDays);
        Console.WriteLine("Total Cost   : "+totalCost);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a CarRental object using the default constructor
        CarRental defaultRental = new CarRental();
        Console.WriteLine("Default Rental Details:");
        defaultRental.DisplayDetails();

        // Create a CarRental object using the parameterized constructor
        CarRental parameterizedRental = new CarRental("Ravi", "Toyota", 6, 500.0);
        Console.WriteLine("\nParameterized Rental Details:");
        parameterizedRental.DisplayDetails();

        // Create a CarRental object using the copy constructor
        CarRental copyRental = new CarRental(parameterizedRental);
        Console.WriteLine("\nCopy Rental Details:");
        copyRental.DisplayDetails();
    }
}


// 1. Instance vs. Class Variables and Methods
//1.  Product Inventory
using System;
class Product
{
    // Instance variables
    private string productName;
    private double price;

    // Class variable
    private static int totalProducts = 0;

    // Default constructor
    public Product()
    {
        productName = "Unknown Product";
        price = 0.0;
        totalProducts++;
    }

    // Parameterized constructor
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    // Instance method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: "+productName);
        Console.WriteLine("Price: "+price);
    }

    // Class method to display total number of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: "+totalProducts);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Product objects using the parameterized constructor
        Product product1 = new Product("Laptop", 500.99);
        Product product2 = new Product("Smartphone", 200.99);

        // Display the details of each product
        Console.WriteLine("Product 1 Details:");
        product1.DisplayProductDetails();

        Console.WriteLine("\nProduct 2 Details:");
        product2.DisplayProductDetails();

        // Display the total number of products created
        Product.DisplayTotalProducts();
    }
}


//2.  Online Course Management
using System;
class Course
{
    // Instance variables
    private string courseName;
    private int duration; // Duration in weeks
    private double fee;

    // Class variable
    private static string instituteName = "Default Institute";

    // Default constructor
    public Course()
    {
        courseName = "Unknown Course";
        duration = 0;
        fee = 0.0;
    }

    // Parameterized constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute Name: "+instituteName);
        Console.WriteLine("Course Name: "+courseName);
        Console.WriteLine("Duration: "+duration+" weeks");
        Console.WriteLine("Fee: "+fee);
    }

    // Class method to update the institute name
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Course objects using the parameterized constructor
        Course course1 = new Course("Computer Science", 12, 1500.0);
        Course course2 = new Course("Mathematics", 10, 1200.0);

        // Display the details of each course
        Console.WriteLine("Course 1 Details:");
        course1.DisplayCourseDetails();

        Console.WriteLine("\nCourse 2 Details:");
        course2.DisplayCourseDetails();

        // Update the institute name
        Course.UpdateInstituteName("Tech Academy");

        // Display the details of each course again to show the updated institute name
        Console.WriteLine("\nUpdated Course 1 Details:");
        course1.DisplayCourseDetails();

        Console.WriteLine("\nUpdated Course 2 Details:");
        course2.DisplayCourseDetails();
    }
}

//3. Vehicle Registration
using System;

class Vehicle
{
    // Instance variables
    private string ownerName;
    private string vehicleType;

    // Class variable
    private static double registrationFee = 100.0;

    // Default constructor
    public Vehicle()
    {
        ownerName = "Unknown Owner";
        vehicleType = "Unknown Type";
    }

    // Parameterized constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name      : "+ownerName);
        Console.WriteLine("Vehicle Type    : "+vehicleType);
        Console.WriteLine("Registration Fee: "+registrationFee);
    }

    // Class method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Vehicle objects using the parameterized constructor
        Vehicle vehicle1 = new Vehicle("Abhishek", "BMW");
        Vehicle vehicle2 = new Vehicle("Uday", "SUV");

        // Display the details of each vehicle
        Console.WriteLine("Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("\nVehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();

        // Update the registration fee
        Vehicle.UpdateRegistrationFee(220.0);

        // Display the details of each vehicle again to show the updated registration fee
        Console.WriteLine("\nUpdated Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("\nUpdated Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();
    }
}



// 2. Access Modifiers
//1. University Management System
using System;
class Student
{
    // Public attribute
    public int rollNumber;

    // Protected attribute
    protected string name;

    // Private attribute
    private double CGPA;

    // Default constructor
    public Student()
    {
        rollNumber = 0;
        name = "Unknown";
        CGPA = 0.0;
    }

    // Parameterized constructor
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public method to get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to set CGPA
    public void SetCGPA(double CGPA)
    {
        this.CGPA = CGPA;
    }

    // Method to display student details
    public void DisplayDetails()
    {
        Console.WriteLine("Roll Number: "+rollNumber);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("CGPA: "+CGPA);
    }
}

class PostgraduateStudent : Student
{
    // Additional attribute for PostgraduateStudent
    private string researchTopic;

    // Parameterized constructor
    public PostgraduateStudent(int rollNumber, string name, double CGPA, string researchTopic)
        : base(rollNumber, name, CGPA)
    {
        this.researchTopic = researchTopic;
    }

    // Method to display postgraduate student details
    public void DisplayPostgraduateDetails()
    {
        DisplayDetails();
        Console.WriteLine("Research Topic: "+researchTopic);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Student object using the parameterized constructor
        Student student = new Student(101, "Robin", 7.8);
        Console.WriteLine("Student Details:");
        student.DisplayDetails();

        // Modify the CGPA using public methods
        student.SetCGPA(6.9);
        Console.WriteLine("\nUpdated Student Details:");
        student.DisplayDetails();

        // Create a PostgraduateStudent object using the parameterized constructor
        PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Shobit", 4.0, "Artificial Intelligence");
        Console.WriteLine("\nPostgraduate Student Details:");
        pgStudent.DisplayPostgraduateDetails();
    }
}


//2. Book Library System
using System;
class Book
{
    // Public attribute
    public string ISBN;

    // Protected attribute
    protected string title;

    // Private attribute
    private string author;

    // Default constructor
    public Book()
    {
        ISBN = "Unknown ISBN";
        title = "Unknown Title";
        author = "Unknown Author";
    }

    // Parameterized constructor
    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public method to get the author name
    public string GetAuthor()
    {
        return author;
    }

    // Public method to set the author name
    public void SetAuthor(string author)
    {
        this.author = author;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("ISBN  : "+ISBN);
        Console.WriteLine("Title : "+title);
        Console.WriteLine("Author: "+author);
    }
}

class EBook : Book
{
    // Additional attribute for EBook
    private double fileSize;

    // Parameterized constructor
    public EBook(string ISBN, string title, string author, double fileSize)
        : base(ISBN, title, author)
    {
        this.fileSize = fileSize;
    }

    // Method to display eBook details
    public void DisplayEBookDetails()
    {
        DisplayDetails();
        Console.WriteLine("File Size: "+fileSize+" MB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Book object using the parameterized constructor
        Book book = new Book("123-456-789", "The Sun", "Rohit");
        Console.WriteLine("Book Details:");
        book.DisplayDetails();

        // Modify the author name using public methods
        book.SetAuthor("Yesh");
        Console.WriteLine("\nUpdated Book Details:");
        book.DisplayDetails();

        // Create an EBook object using the parameterized constructor
        EBook ebook = new EBook("987-654-321", "1984", "Roy", 1.5);
        Console.WriteLine("\nEBook Details:");
        ebook.DisplayEBookDetails();
    }
}


//3.  Bank Account Management
using System;
class BankAccount
{
    // Public attribute
    public int accountNumber;

    // Protected attribute
    protected string accountHolder;

    // Private attribute
    private double balance;

    // Default constructor
    public BankAccount()
    {
        accountNumber = 0;
        accountHolder = "Unknown";
        balance = 0.0;
    }

    // Parameterized constructor
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public method to get the balance
    public double GetBalance()
    {
        return balance;
    }

    // Public method to set the balance
    public void SetBalance(double balance)
    {
        this.balance = balance;
    }

    // Method to display account details
    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: "+accountNumber);
        Console.WriteLine("Account Holder: "+accountHolder);
        Console.WriteLine("Balance: "+balance);
    }
}

class SavingsAccount : BankAccount
{
    // Additional attribute for SavingsAccount
    private double interestRate;

    // Parameterized constructor
    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        this.interestRate = interestRate;
    }

    // Method to display savings account details
    public void DisplaySavingsDetails()
    {
        DisplayDetails();
        Console.WriteLine("Interest Rate: "+interestRate+"%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a BankAccount object using the parameterized constructor
        BankAccount account = new BankAccount(12345, "Nikhil", 50000.0);
        Console.WriteLine("Bank Account Details:");
        account.DisplayDetails();

        // Modify the balance using public methods
        account.SetBalance(5500.0);
        Console.WriteLine("\nUpdated Bank Account Details:");
        account.DisplayDetails();

        // Create a SavingsAccount object using the parameterized constructor
        SavingsAccount savingsAccount = new SavingsAccount(789012, "Saurav", 10000.0, 2.5);
        Console.WriteLine("\nSavings Account Details:");
        savingsAccount.DisplaySavingsDetails();
    }
}


//4. Employee Records
using System;
class Employee
{
    // Public attribute
    public int employeeID;

    // Protected attribute
    protected string department;

    // Private attribute
    private double salary;

    // Default constructor
    public Employee()
    {
        employeeID = 0;
        department = "Unknown";
        salary = 0.0;
    }

    // Parameterized constructor
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // Public method to get the salary
    public double GetSalary()
    {
        return salary;
    }

    // Public method to set the salary
    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: "+employeeID);
        Console.WriteLine("Department : "+department);
        Console.WriteLine("Salary: "+salary);
    }
}

class Manager : Employee
{
    // Additional attribute for Manager
    private string team;

    // Parameterized constructor
    public Manager(int employeeID, string department, double salary, string team)
        : base(employeeID, department, salary)
    {
        this.team = team;
    }

    // Method to display manager details
    public void DisplayManagerDetails()
    {
        DisplayDetails();
        Console.WriteLine("Team: "+team);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object using the parameterized constructor
        Employee employee = new Employee(101, "IT", 70000.0);
        Console.WriteLine("Employee Details:");
        employee.DisplayDetails();

        // Modify the salary using public methods
        employee.SetSalary(85000.0);
        Console.WriteLine("\nUpdated Employee Details:");
        employee.DisplayDetails();

        // Create a Manager object using the parameterized constructor
        Manager manager = new Manager(102, "HR", 60000.0, "Recruitment");
        Console.WriteLine("\nManager Details:");
        manager.DisplayManagerDetails();
    }
}
*/