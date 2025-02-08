/*
//1. Animal Hierarchy
using System;
// Base class Animal
class Animal
{
    public string Name { get; set; } // Animal's name
    public int Age { get; set; } // Animal's age

    // Constructor to initialize Name and Age
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method to be overridden by subclasses
    public virtual string MakeSound()
    {
        return "Animal makes a sound";
    }
}

// Derived class Dog
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override string MakeSound()
    {
        return "Dog barks";
    }
}

// Derived class Cat
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override string MakeSound()
    {
        return "Cat meows";
    }
}

// Derived class Bird
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    // Overriding MakeSound method
    public override string MakeSound()
    {
        return "Bird chirps";
    }
}

// Main program to demonstrate polymorphism
class Program
{
    static void Main()
    {
        // Creating instances of Dog, Cat, and Bird
        Animal dog = new Dog("Tom", 3);
        Animal cat = new Cat("Sony", 2);
        Animal bird = new Bird("Methu", 1);

        // Storing instances in an array
        Animal[] animals = { dog, cat, bird };
        
        // Iterating through the array and calling MakeSound method
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name+" ("+animal.Age+" years old): "+animal.MakeSound());
        }
    }
}



//2. Employee Management System
using System;
// Base class Employee
public class Employee
{
    // Attributes of Employee
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // Constructor to initialize Employee attributes
    public Employee(string name, int id, double salary)
    {
        this.Name = name;
        this.Id = id;
        this.Salary = salary;
    }

    // Method to display Employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: "+Name+", Id: "+Id+", Salary: "+Salary);
    }
}

// Subclass Manager
public class Manager : Employee
{
    // Additional attribute for Manager
    public int TeamSize { get; set; }

    // Constructor to initialize Manager attributes
    public Manager(string name, int id, double salary, int teamSize) 
        : base(name, id, salary)
    {
        this.TeamSize = teamSize;
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: "+TeamSize);
    }
}

// Subclass Developer
public class Developer : Employee
{
    // Additional attribute for Developer
    public string ProgrammingLanguage { get; set; }

    // Constructor to initialize Developer attributes
    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        this.ProgrammingLanguage = programmingLanguage;
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: "+ProgrammingLanguage);
    }
}

// Subclass Intern
public class Intern : Employee
{
    // Additional attribute for Intern
    public string InternshipDuration { get; set; }

    // Constructor to initialize Intern attributes
    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        this.InternshipDuration = internshipDuration;
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: "+InternshipDuration);
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different employee types
        Employee manager = new Manager("Abhishek", 101, 95000, 10);
        Employee developer = new Developer("Bobby", 102, 80000, "C#");
        Employee intern = new Intern("Tushar", 103, 40000, "6 months");

        // Displaying details of each employee
        manager.DisplayDetails();
        Console.WriteLine();

        developer.DisplayDetails();
        Console.WriteLine();

        intern.DisplayDetails();
    }
}


//3. Vehicle and Transport System
using System;
// Base class Vehicle
public class Vehicle
{
    // Attributes of Vehicle
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    // Constructor to initialize Vehicle attributes
    public Vehicle(int maxSpeed, string fuelType)
    {
        this.MaxSpeed = maxSpeed;
        this.FuelType = fuelType;
    }

    // Method to display Vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine(""+MaxSpeed+", Fuel Type: "+FuelType);
    }
}

// Subclass Car
public class Car : Vehicle
{
    // Additional attribute for Car
    public int SeatCapacity { get; set; }

    // Constructor to initialize Car attributes
    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        this.SeatCapacity = seatCapacity;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: "+SeatCapacity);
    }
}

// Subclass Truck
public class Truck : Vehicle
{
    // Additional attribute for Truck
    public int PayloadCapacity { get; set; }

    // Constructor to initialize Truck attributes
    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        this.PayloadCapacity = payloadCapacity;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: "+PayloadCapacity);
    }
}

// Subclass Motorcycle
public class Motorcycle : Vehicle
{
    // Additional attribute for Motorcycle
    public bool HasSidecar { get; set; }

    // Constructor to initialize Motorcycle attributes
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        this.HasSidecar = hasSidecar;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: "+HasSidecar);
    }
}

// Main program to demonstrate polymorphism
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different vehicle types
        Vehicle car = new Car(180, "Petrol", 6);
        Vehicle truck = new Truck(120, "Diesel", 2500);
        Vehicle motorcycle = new Motorcycle(150, "Petrol", true);

        // Storing the objects in an array of Vehicle type
        Vehicle[] vehicles = { car, truck, motorcycle };

        // Calling the DisplayInfo method on each object in the array
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}



//Single Inheritance

//1. Library Management with Books and Authors
using System;
// Superclass Book
public class Book
{
    // Attributes of Book
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    // Constructor to initialize Book attributes
    public Book(string title, int publicationYear)
    {
        this.Title = title;
        this.PublicationYear = publicationYear;
    }

    // Method to display book information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Title: "+Title+", Publication Year: "+PublicationYear);
    }
}

// Subclass Author that inherits from Book
public class Author : Book
{
    // Additional attributes for Author
    public string Name { get; set; }
    public string Bio { get; set; }

    // Constructor to initialize Author attributes along with Book attributes
    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        this.Name = name;
        this.Bio = bio;
    }

    // Overriding the DisplayInfo method to include author details
    public override void DisplayInfo()
    {
        base.DisplayInfo();  // Call the base class method to display book information
        Console.WriteLine("Author: "+Name+", Bio: "+Bio);
    }
}

// Main program to demonstrate single inheritance
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Author
        Author author = new Author("The Great Wall", 1950, "Tushar", "Indian novelist and short story writer");

        // Displaying book and author information
        author.DisplayInfo();
    }
}


//2. Smart Home Devices
using System;
// Superclass Device
public class Device
{
    // Attributes of Device
    public string DeviceId { get; set; }
    public string Status { get; set; }

    // Constructor to initialize Device attributes
    public Device(string deviceId, string status)
    {
        this.DeviceId = deviceId;
        this.Status = status;
    }

    // Method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: "+DeviceId+", Status: "+Status);
    }
}

// Subclass Thermostat that inherits from Device
public class Thermostat : Device
{
    // Additional attribute for Thermostat
    public double TemperatureSetting { get; set; }

    // Constructor to initialize Thermostat attributes along with Device attributes
    public Thermostat(string deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        this.TemperatureSetting = temperatureSetting;
    }

    // Overriding the DisplayStatus method to include temperature setting
    public override void DisplayStatus()
    {
        base.DisplayStatus();  // Call the base class method to display device status
        Console.WriteLine("Temperature Setting: "+TemperatureSetting);
    }
}

// Main program to demonstrate single inheritance
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Thermostat
        Thermostat thermostat = new Thermostat("N12345", "Active", 25.5);

        // Displaying thermostat status
        thermostat.DisplayStatus();
    }
}


// Multilevel Inheritance

//1.  Online Retail Order Management
using System;
public class Order
{
    public string OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    // Constructor to initialize Order attributes
    public Order(string orderId, DateTime orderDate)
    {
        this.OrderId = orderId;
        this.OrderDate = orderDate;
    }

    // Virtual method to get order status
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

    // Method to display order details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Order ID: "+OrderId+", Order Date: "+OrderDate);
    }
}

public class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    // Constructor to initialize ShippedOrder attributes along with Order attributes
    public ShippedOrder(string orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        this.TrackingNumber = trackingNumber;
    }

    // Overriding the GetOrderStatus method
    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }

    // Overriding the DisplayDetails method to include tracking number
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Tracking Number: "+TrackingNumber);
    }
}

public class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    // Constructor to initialize DeliveredOrder attributes along with ShippedOrder attributes
    public DeliveredOrder(string orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        this.DeliveryDate = deliveryDate;
    }

    // Overriding the GetOrderStatus method
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }

    // Overriding the DisplayDetails method to include delivery date
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Delivery Date: "+DeliveryDate);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of DeliveredOrder
        DeliveredOrder deliveredOrder = new DeliveredOrder("N12345", DateTime.Now.AddDays(-5), "R987654", DateTime.Now);

        // Displaying order details
        deliveredOrder.DisplayDetails();

        // Getting the order status
        Console.WriteLine("Order Status: "+deliveredOrder.GetOrderStatus());
    }
}


//2. Educational Course Hierarchy
using System;
public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; } // Duration in hours

    // Constructor to initialize Course attributes
    public Course(string courseName, int duration)
    {
        this.CourseName = courseName;
        this.Duration = duration;
    }

    // Method to display course information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Course Name: "+CourseName+", Duration: "+Duration+" hours");
    }
}

public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    // Constructor to initialize OnlineCourse attributes along with Course attributes
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        this.Platform = platform;
        this.IsRecorded = isRecorded;
    }

    // Overriding the DisplayInfo method to include platform and recording status
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Platform: "+Platform+", Is Recorded: "+IsRecorded);
    }
}

public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; } // Discount percentage

    // Constructor to initialize PaidOnlineCourse attributes along with OnlineCourse attributes
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        this.Fee = fee;
        this.Discount = discount;
    }

    // Overriding the DisplayInfo method to include fee and discount
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Fee: "+Fee+", Discount: "+Discount+"%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of PaidOnlineCourse
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Basic C#", 50, "BridgeLabz", true, 499.99, 10);

        // Displaying course details
        paidCourse.DisplayInfo();
    }
}



// Hierarchical Inheritance

//1. Bank Account Types
using System;
// Base class BankAccount
public class BankAccount
{
    // Attributes of BankAccount
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    // Constructor to initialize BankAccount attributes
    public BankAccount(string accountNumber, double balance)
    {
        this.AccountNumber = accountNumber;
        this.Balance = balance;
    }

    // Virtual method to display account type
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Bank Account");
    }

    // Method to display account details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Account Number: "+AccountNumber+", Balance: "+Balance);
    }
}

// Subclass SavingsAccount
public class SavingsAccount : BankAccount
{
    // Additional attribute for SavingsAccount
    public double InterestRate { get; set; }

    // Constructor to initialize SavingsAccount attributes along with BankAccount attributes
    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        this.InterestRate = interestRate;
    }

    // Overriding the DisplayAccountType method
    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }

    // Overriding the DisplayDetails method to include interest rate
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Interest Rate: "+InterestRate+"%");
    }
}

// Subclass CheckingAccount
public class CheckingAccount : BankAccount
{
    // Additional attribute for CheckingAccount
    public double WithdrawalLimit { get; set; }

    // Constructor to initialize CheckingAccount attributes along with BankAccount attributes
    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        this.WithdrawalLimit = withdrawalLimit;
    }

    // Overriding the DisplayAccountType method
    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }

    // Overriding the DisplayDetails method to include withdrawal limit
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Withdrawal Limit: "+WithdrawalLimit);
    }
}

// Subclass FixedDepositAccount
public class FixedDepositAccount : BankAccount
{
    // Additional attribute for FixedDepositAccount
    public int TermLength { get; set; }

    // Constructor to initialize FixedDepositAccount attributes along with BankAccount attributes
    public FixedDepositAccount(string accountNumber, double balance, int termLength)
        : base(accountNumber, balance)
    {
        this.TermLength = termLength;
    }

    // Overriding the DisplayAccountType method
    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }

    // Overriding the DisplayDetails method to include term length
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Term Length: "+TermLength+" months");
    }
}

// Main program to demonstrate hierarchical inheritance
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different account types
        BankAccount savingsAccount = new SavingsAccount("SA12345", 50000.00, 3.5);
        BankAccount checkingAccount = new CheckingAccount("CA12345", 30000.00, 1000.00);
        BankAccount fixedDepositAccount = new FixedDepositAccount("FD12345", 100000.00, 10);

        // Storing the objects in an array of BankAccount type
        BankAccount[] accounts = { savingsAccount, checkingAccount, fixedDepositAccount };

        // Displaying account type and details
        foreach (BankAccount account in accounts)
        {
            account.DisplayAccountType();
            account.DisplayDetails();
            Console.WriteLine();
        }
    }
}


//2. : School System with Different Roles
using System;
// Superclass Person
public class Person
{
    // Attributes of Person
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor to initialize Person attributes
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Virtual method to display the role
    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }

    // Method to display person details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: "+Name+", Age: "+Age);
    }
}

// Subclass Teacher
public class Teacher : Person
{
    // Additional attribute for Teacher
    public string Subject { get; set; }

    // Constructor to initialize Teacher attributes along with Person attributes
    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        this.Subject = subject;
    }

    // Overriding the DisplayRole method
    public override void DisplayRole()
    {
        Console.WriteLine("Teacher");
    }

    // Overriding the DisplayDetails method to include subject
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Subject: "+Subject);
    }
}

// Subclass Student
public class Student : Person
{
    // Additional attribute for Student
    public string Grade { get; set; }

    // Constructor to initialize Student attributes along with Person attributes
    public Student(string name, int age, string grade)
        : base(name, age)
    {
        this.Grade = grade;
    }

    // Overriding the DisplayRole method
    public override void DisplayRole()
    {
        Console.WriteLine("Student");
    }

    // Overriding the DisplayDetails method to include grade
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Grade: "+Grade);
    }
}

// Subclass Staff
public class Staff : Person
{
    // Additional attribute for Staff
    public string Position { get; set; }

    // Constructor to initialize Staff attributes along with Person attributes
    public Staff(string name, int age, string position)
        : base(name, age)
    {
        this.Position = position;
    }

    // Overriding the DisplayRole method
    public override void DisplayRole()
    {
        Console.WriteLine("Staff");
    }

    // Overriding the DisplayDetails method to include position
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Position: "+Position);
    }
}

// Main program to demonstrate hierarchical inheritance
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different roles
        Person teacher = new Teacher("Annu", 35, "Mathematics");
        Person student = new Student("Bobby", 15, "10th Grade");
        Person staff = new Staff("Tulshi", 40, "Administrator");

        // Storing the objects in an array of Person type
        Person[] people = { teacher, student, staff };

        // Displaying role and details
        foreach (Person person in people)
        {
            person.DisplayRole();
            person.DisplayDetails();
            Console.WriteLine();
        }
    }
}



// Hybrid Inheritance (Simulating Multiple Inheritance)

//1. Restaurant Management System with Hybrid Inheritance
using System;
// Superclass Person
public class Person
{
    // Attributes of Person
    public string Name { get; set; }
    public int Id { get; set; }

    // Constructor to initialize Person attributes
    public Person(string name, int id)
    {
        this.Name = name;
        this.Id = id;
    }

    // Method to display person details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: "+Name+", ID: "+Id);
    }
}

// Interface Worker
public interface Worker
{
    void PerformDuties(); // Method to perform duties
}

// Subclass Chef that inherits from Person and implements Worker
public class Chef : Person, Worker
{
    // Constructor to initialize Chef attributes
    public Chef(string name, int id) : base(name, id) { }

    // Implementing PerformDuties method for Chef
    public void PerformDuties()
    {
        Console.WriteLine("Chef is preparing meals.");
    }

    // Overriding DisplayDetails method to include role
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Role: Chef");
    }
}

// Subclass Waiter that inherits from Person and implements Worker
public class Waiter : Person, Worker
{
    // Constructor to initialize Waiter attributes
    public Waiter(string name, int id) : base(name, id) { }

    // Implementing PerformDuties method for Waiter
    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving customers.");
    }

    // Overriding DisplayDetails method to include role
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Role: Waiter");
    }
}

// Main program to demonstrate hybrid inheritance
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Chef and Waiter
        Chef chef = new Chef("Mohit", 101);
        Waiter waiter = new Waiter("Bobby", 102);

        // Displaying details and performing duties
        chef.DisplayDetails();
        chef.PerformDuties();
        Console.WriteLine();

        waiter.DisplayDetails();
        waiter.PerformDuties();
    }
}


//2. Vehicle Management System with Hybrid Inheritance
using System;
// Superclass Vehicle
public class Vehicle
{
    // Attributes of Vehicle
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    // Constructor to initialize Vehicle attributes
    public Vehicle(int maxSpeed, string model)
    {
        this.MaxSpeed = maxSpeed;
        this.Model = model;
    }

    // Method to display vehicle details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Model: "+Model+", Max Speed: "+MaxSpeed+" km/h");
    }
}

// Interface Refuelable
public interface Refuelable
{
    void Refuel(); // Method to refuel
}

// Subclass ElectricVehicle that inherits from Vehicle
public class ElectricVehicle : Vehicle
{
    // Additional method for ElectricVehicle
    public ElectricVehicle(int maxSpeed, string model)
        : base(maxSpeed, model) { }

    // Method to charge the electric vehicle
    public void Charge()
    {
        Console.WriteLine("Charging electric vehicle...");
    }

    // Overriding the DisplayDetails method to include electric vehicle details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Vehicle Type: Electric");
    }
}

// Subclass PetrolVehicle that inherits from Vehicle and implements Refuelable
public class PetrolVehicle : Vehicle, Refuelable
{
    // Constructor to initialize PetrolVehicle attributes
    public PetrolVehicle(int maxSpeed, string model)
        : base(maxSpeed, model) { }

    // Implementing the Refuel method for PetrolVehicle
    public void Refuel()
    {
        Console.WriteLine("Refueling petrol vehicle...");
    }

    // Overriding the DisplayDetails method to include petrol vehicle details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Vehicle Type: Petrol");
    }
}

// Main program to demonstrate hybrid inheritance
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of ElectricVehicle and PetrolVehicle
        ElectricVehicle electricVehicle = new ElectricVehicle(140, "Tesla Model S");
        PetrolVehicle petrolVehicle = new PetrolVehicle(160, "Toyota Corolla");

        // Displaying details and performing specific actions
        electricVehicle.DisplayDetails();
        electricVehicle.Charge();
        Console.WriteLine();

        petrolVehicle.DisplayDetails();
        petrolVehicle.Refuel();
    }
}
*/
