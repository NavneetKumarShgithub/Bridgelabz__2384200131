/*
//1. Bank Account System
using System;
public class BankAccount
{
    // Static variable shared across all accounts
    private static string bankName = "Global Bank";
    private static int totalAccounts = 0;

    // Readonly variable to ensure it cannot be changed once assigned
    public readonly string AccountNumber;
    public string AccountHolderName;
    public decimal Balance;

    // Constructor using 'this' to resolve ambiguity
    public BankAccount(string accountHolderName, string accountNumber, decimal initialBalance)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        this.Balance = initialBalance;
        totalAccounts++;
    }

    // Static method to get the total number of accounts
    public static int GetTotalAccounts()
    {
        return totalAccounts;
    }

    // Method to display account details with 'is' operator check
    public void DisplayAccountDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("Bank Name: "+bankName);
            Console.WriteLine("Account Holder Name: "+AccountHolderName);
            Console.WriteLine("Account Number: "+AccountNumber);
            Console.WriteLine("Balance: "+Balance);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount("Rahul", "A123", 1000.00m);
        BankAccount account2 = new BankAccount("Abhishek", "B456", 1500.00m);

        account1.DisplayAccountDetails();
        Console.WriteLine();
        account2.DisplayAccountDetails();
        Console.WriteLine("Total Accounts: "+BankAccount.GetTotalAccounts());
    }
}


//1. Bank Account System
using System;
using System.Collections;
namespace BankManagementSystem
{
    class BankAccount
    {
        private static ArrayList allAccounts = new ArrayList();
        private static string bankName;
        private static int totalAccounts = 0;
        private readonly long accountNumber;
        protected string accountHolderName;
        private double balance;
        private static int accountCounter = 1000;
        
        static BankAccount()
        {
            bankName = "INDIAN BANK";
        }

        public static int GenerateAccountNumber()
        {
            Random random = new Random();
            accountCounter++;
            return  accountCounter* 1000 + random.Next(0, 1000); 
        }


        public BankAccount(string accountHolderName, double balance)
        {
            this.accountNumber = GenerateAccountNumber();
            this.accountHolderName = accountHolderName;
            this.balance = balance;
            totalAccounts++;
        }

        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine(amount+" deposited successfully");
            }
            else
            {
                Console.WriteLine("Enter valid deposit amount");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && this.balance - amount >= 1000)
            {
                this.balance -= amount;
                Console.WriteLine(amount+" withdrawn successfully");
            }
            else
            {
                Console.WriteLine("Insufficient balance! Minimum balance of 1000 should be maintained");
            }
        }

        public void Display()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Bank Name: "+bankName);
            Console.WriteLine("Account Number: "+this.accountNumber);
            Console.WriteLine("Account Holder: "+this.accountHolderName);
            Console.WriteLine("Balance: "+this.balance);
            Console.WriteLine("==================================");
        }

        public static void AddCustomer(BankAccount other)
        {
            allAccounts.Add(other);
        }
        
        public static BankAccount GetAccountByNumber(int accountNumber)
        {
            foreach (BankAccount acc in allAccounts)
            {
                if (acc.accountNumber == accountNumber)
                {
                    return acc; 
                }
            }
            return null;
        }

        public void BankManagement()
        {
            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1 - Check Balance");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Display Account Details");
                Console.WriteLine("5 - Exit");

                int input = Convert.ToInt32(Console.ReadLine());
                                
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Current Balance: "+GetBalance());
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
						double depositAmount = Convert.ToDouble(Console.ReadLine());
						
                        if (depositAmount>0)
                        {
                            Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount entered.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter withdrawal amount: ");
						double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        if (withdrawAmount > 0 && this.balance - withdrawAmount > 1000)
                        {
                            Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Trasaction! Minimum Rs 1000 should be maintained");
                        }
                        break;
                    case 4:
                        Display();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for banking with us!");
                        return;
                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        break;
                }
            }
        }

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("1 - Create New Account");
                Console.WriteLine("2 - Show All Accounts");
                Console.WriteLine("3 - Search Account by Number");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose an option: ");

                int input = Convert.ToInt32(Console.ReadLine());
                
                switch (input)
                {
                    case 1:                        
                        Console.Write("Account Holder Name: ");
                        string accountHolderName = Console.ReadLine();

						double balance;
                        do
						{
							Console.Write("Initial Balance (minimum 1000): ");
							balance = Convert.ToDouble(Console.ReadLine());
						}
                        while (balance <1000);

                        BankAccount newAccount = new BankAccount(accountHolderName, balance);
                        AddCustomer(newAccount);
                        newAccount.BankManagement();
                        break;

                    case 2:
                        Console.WriteLine("All Accounts:");
                        foreach (BankAccount acc in allAccounts)
                        {
                            acc.Display();
                        }
                        break;
                    
                    case 3:
                        Console.Write("Enter Account Number: ");
                        int searchAccountNumber = Convert.ToInt32(Console.ReadLine());
                        BankAccount account = GetAccountByNumber(searchAccountNumber);
                        
                        if (account != null)
                        {
                            account.Display();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting program. Thank you!");
                        return;                 
                }
            }
        }
    }
}

//2. Library Management System
using System;

public class Book
{
    // Static variable shared across all books
    private static string LibraryName = "Mathura Library";

    // Readonly variable to ensure it cannot be changed once assigned
    public readonly string ISBN;
    public string Title;
    public string Author;

    // Constructor using 'this' to resolve ambiguity
    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    // Static method to display the library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: "+LibraryName);
    }

    // Method to display book details with 'is' operator check
    public void DisplayBookDetails()
    {
        if (this is Book)
        {
            Console.WriteLine("Title : "+Title);
            Console.WriteLine("Author: "+Author);
            Console.WriteLine("ISBN  : "+ISBN);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book.DisplayLibraryName();
        
        Book book1 = new Book("The Moon", "Rohan", "1234567890");
        Book book2 = new Book("Kill", "Harsh", "2345678901");

        book1.DisplayBookDetails();
        Console.WriteLine();
        book2.DisplayBookDetails();
    }
}



//3. Employee Management System
using System;
class Employee
{
    // Static variable 
    private static string companyName = "Capgemini";
    
    // Static variable 
    private static int employeCount = 0;

    // Readonly variable 
    private readonly int id;
    
    // Instance variables 
    private string name;
    private string designation;

    // Constructor 
    public Employee(int id, string name, string designation)
    {
        this.id = id;
        this.name = name;
        this.designation = designation;
        employeCount++; 
    }   

    // Method to display company name
    public void DisplayCompanyname()
    {
        Console.WriteLine("Company Name :" + companyName);
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Designation: " + this.designation);
        }
        else
        {
            Console.WriteLine("Invalid employee");
        }
    }
	
	public static void Main()
	{
		// Creating employee instances
        Employee emp = new Employee(01, "Mohit", "Software Engineer");
        
        // Display company name
        emp.DisplayCompanyname();
        
        // Display employee details
        emp.DisplayEmployeeDetails();
	}
}


//4. Shopping Cart System
using System;
public class Product
{
    // Static variable shared by all products
    private static double Discount = 0.0;

    // Readonly variable to ensure it cannot be changed once assigned
    public readonly string ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor using 'this' to resolve ambiguity
    public Product(string productName, double price, int quantity, string productID)
    {
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = productID;
    }

    // Static method to update the discount percentage
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    // Method to display product details with 'is' operator check
    public void DisplayProductDetails()
    {
        if (this is Product)
        {
            Console.WriteLine("Product Name: "+ProductName);
            Console.WriteLine("Price: "+(Price - (Price * Discount / 100))+" (after discount)");
            Console.WriteLine("Quantity: "+Quantity);
            Console.WriteLine("Product ID: "+ProductID);
            Console.WriteLine("Discount: "+Discount+"%");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Update the discount percentage for all products
        Product.UpdateDiscount(10.0);

        // Create some product instances
        Product product1 = new Product("Laptop", 1000.00, 5, "P001");
        Product product2 = new Product("Smartphone", 500.00, 10, "P002");

        // Display product details
        product1.DisplayProductDetails();
        Console.WriteLine();
        product2.DisplayProductDetails();
    }
}


//5. University Student Management
using System;
public class Student
{
    // Static variable shared across all students
    private static string UniversityName = "GLA University";
    private static int totalStudents = 0;

    // Readonly variable to ensure it cannot be changed once assigned
    public readonly string RollNumber;
    public string Name;
    public string Grade;

    // Constructor using 'this' to resolve ambiguity
    public Student(string name, string rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }

    // Static method to display the total number of students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: "+totalStudents);
    }

    // Method to display student details with 'is' operator check
    public void DisplayStudentDetails()
    {
        if (this is Student)
        {
            Console.WriteLine("University Name: "+UniversityName);
            Console.WriteLine("Name  : "+Name);
            Console.WriteLine("Roll Number: "+RollNumber);
            Console.WriteLine("Grade : "+Grade);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student.DisplayTotalStudents();

        Student student1 = new Student("Rahul", "1001", "A");
        Student student2 = new Student("Tushar", "1002", "B");

        student1.DisplayStudentDetails();
        Console.WriteLine();
        student2.DisplayStudentDetails();
        Student.DisplayTotalStudents();
    }
}


//6. Vehicle Registration System
using System;
public class Vehicle
{
    // Static variable common for all vehicles
    private static double RegistrationFee = 500.00;

    // Readonly variable to ensure it cannot be changed once assigned
    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    // Constructor using 'this' to resolve ambiguity
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }

    // Static method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    // Method to display vehicle registration details with 'is' operator check
    public void DisplayVehicleDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine("Owner Name: "+OwnerName);
            Console.WriteLine("Vehicle Type: "+VehicleType);
            Console.WriteLine("Registration Number: "+RegistrationNumber);
            Console.WriteLine("Registration Fee: "+RegistrationFee );
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Update the registration fee for all vehicles
        Vehicle.UpdateRegistrationFee(950.00);

        // Create some vehicle instances
        Vehicle vehicle1 = new Vehicle("Mohan", "Car", "ABC123");
        Vehicle vehicle2 = new Vehicle("Yesh", "Motorcycle", "XYZ789");

        // Display vehicle details
        vehicle1.DisplayVehicleDetails();
        Console.WriteLine();
        vehicle2.DisplayVehicleDetails();
    }
}


//7. Hospital Management System
using System;
public class Patient
{
    // Static variable shared among all patients
    private static string HospitalName = "Jeevan Hospital";
    private static int totalPatients = 0;

    // Readonly variable to ensure it cannot be changed once assigned
    public readonly string PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    // Constructor using 'this' to resolve ambiguity
    public Patient(string name, int age, string ailment, string patientID)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientID;
        totalPatients++;
    }

    // Static method to count the total patients admitted
    public static int GetTotalPatients()
    {
        return totalPatients;
    }

    // Method to display patient details with 'is' operator check
    public void DisplayPatientDetails()
    {
        if (this is Patient)
        {
            Console.WriteLine("Hospital Name: "+HospitalName);
            Console.WriteLine("Name   : "+Name);
            Console.WriteLine("Age    : "+Age);
            Console.WriteLine("Ailment: "+Ailment);
            Console.WriteLine("Patient ID: "+PatientID);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Patient.GetTotalPatients();

        Patient patient1 = new Patient("Uday", 14, "Flu", "P101");
        Patient patient2 = new Patient("Anant", 25, "Fracture", "P122");

        patient1.DisplayPatientDetails();
        Console.WriteLine();
        patient2.DisplayPatientDetails();
        Console.WriteLine("Total Patients: "+Patient.GetTotalPatients());
    }
}
*/