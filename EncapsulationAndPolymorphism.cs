/*
//1. Employee Management System
using System;
using System.Collections.Generic;

// Abstract class Employee
public abstract class Employee
{
    // Encapsulated fields
    private int employeeId;
    private string name;
    private double baseSalary;

    // Constructor to initialize Employee attributes
    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // Properties to access private fields
    public int EmployeeId
    {
        get { return employeeId; }
    }

    public string Name
    {
        get { return name; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    // Abstract method to calculate salary
    public abstract double CalculateSalary();

    // Concrete method to display employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId + ", Name: " + name + ", Base Salary: " + baseSalary);
    }
}

// Interface IDepartment
public interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// Subclass FullTimeEmployee
public class FullTimeEmployee : Employee, IDepartment
{
    // Additional attributes
    private string department;

    // Constructor to initialize FullTimeEmployee attributes
    public FullTimeEmployee(int employeeId, string name, double baseSalary)
        : base(employeeId, name, baseSalary) { }

    // Implementing CalculateSalary method
    public override double CalculateSalary()
    {
        // Fixed salary calculation
        return BaseSalary;
    }

    // Implementing AssignDepartment method
    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    // Implementing GetDepartmentDetails method
    public string GetDepartmentDetails()
    {
        return "Department: " + department;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetDepartmentDetails());
    }
}

// Subclass PartTimeEmployee
public class PartTimeEmployee : Employee, IDepartment
{
    // Additional attributes
    private string department;
    private int workHours;

    // Constructor to initialize PartTimeEmployee attributes
    public PartTimeEmployee(int employeeId, string name, double baseSalary, int workHours)
        : base(employeeId, name, baseSalary)
    {
        this.workHours = workHours;
    }

    // Implementing CalculateSalary method
    public override double CalculateSalary()
    {
        // Salary based on work hours
        return BaseSalary * workHours;
    }

    // Implementing AssignDepartment method
    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    // Implementing GetDepartmentDetails method
    public string GetDepartmentDetails()
    {
        return "Department: " + department;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Work Hours: " + workHours);
        Console.WriteLine(GetDepartmentDetails());
    }
}

// Main program to demonstrate polymorphism
class Program
{
    static void Main(string[] args)
    {
        // Creating a list of Employee references
        List<Employee> employees = new List<Employee>();

        // Adding FullTimeEmployee and PartTimeEmployee to the list
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(101, "Annu", 50000);
        fullTimeEmployee.AssignDepartment("HR");
        employees.Add(fullTimeEmployee);

        PartTimeEmployee partTimeEmployee = new PartTimeEmployee(102, "Bobby", 200, 20);
        partTimeEmployee.AssignDepartment("IT");
        employees.Add(partTimeEmployee);

        // Processing and displaying details of each employee
        foreach (Employee employee in employees)
        {
            employee.DisplayDetails();
            Console.WriteLine("Calculated Salary: " + employee.CalculateSalary());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


//2. E-Commerce Platform
using System;
using System.Collections.Generic;

// Abstract class Product
public abstract class Product
{
    // Encapsulated fields
    private int productId;
    private string name;
    private double price;

    // Constructor to initialize Product attributes
    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    // Properties to access private fields
    public int ProductId
    {
        get { return productId; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Abstract method to calculate discount
    public abstract double CalculateDiscount();

    // Concrete method to display product details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + productId + ", Name: " + name + ", Price: " + price);
    }
}

// Interface ITaxable
public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Subclass Electronics
public class Electronics : Product, ITaxable
{
    // Additional attribute for Electronics
    public double WarrantyPeriod { get; set; }

    // Constructor to initialize Electronics attributes
    public Electronics(int productId, string name, double price, double warrantyPeriod)
        : base(productId, name, price)
    {
        this.WarrantyPeriod = warrantyPeriod;
    }

    // Implementing CalculateDiscount method
    public override double CalculateDiscount()
    {
        return Price * 0.10; // 10% discount
    }

    // Implementing CalculateTax method
    public double CalculateTax()
    {
        return Price * 0.18; // 18% tax
    }

    // Implementing GetTaxDetails method
    public string GetTaxDetails()
    {
        return "Tax Rate: 18%";
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Warranty Period: " + WarrantyPeriod + " years");
    }
}

// Subclass Clothing
public class Clothing : Product, ITaxable
{
    // Additional attribute for Clothing
    public string Size { get; set; }

    // Constructor to initialize Clothing attributes
    public Clothing(int productId, string name, double price, string size)
        : base(productId, name, price)
    {
        this.Size = size;
    }

    // Implementing CalculateDiscount method
    public override double CalculateDiscount()
    {
        return Price * 0.20; // 20% discount
    }

    // Implementing CalculateTax method
    public double CalculateTax()
    {
        return Price * 0.12; // 12% tax
    }

    // Implementing GetTaxDetails method
    public string GetTaxDetails()
    {
        return "Tax Rate: 12%";
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Size: " + Size);
    }
}

// Subclass Groceries
public class Groceries : Product, ITaxable
{
    // Additional attribute for Groceries
    public DateTime ExpiryDate { get; set; }

    // Constructor to initialize Groceries attributes
    public Groceries(int productId, string name, double price, DateTime expiryDate)
        : base(productId, name, price)
    {
        this.ExpiryDate = expiryDate;
    }

    // Implementing CalculateDiscount method
    public override double CalculateDiscount()
    {
        return Price * 0.05; // 5% discount
    }

    // Implementing CalculateTax method
    public double CalculateTax()
    {
        return Price * 0.05; // 5% tax
    }

    // Implementing GetTaxDetails method
    public string GetTaxDetails()
    {
        return "Tax Rate: 5%";
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Expiry Date: " + ExpiryDate.ToShortDateString());
    }
}

// Main program to demonstrate polymorphism
class Program
{
    static void Main(string[] args)
    {
        // Creating a list of Product references
        List<Product> products = new List<Product>();

        // Adding Electronics, Clothing, and Groceries to the list
        products.Add(new Electronics(1, "Laptop", 1000, 2));
        products.Add(new Clothing(2, "T-Shirt", 20, "M"));
        products.Add(new Groceries(3, "Apples", 5, DateTime.Now.AddMonths(1)));

        // Processing and displaying details of each product
        foreach (Product product in products)
        {
            product.DisplayDetails();
            if (product is ITaxable taxableProduct)
            {
                double finalPrice = (product.Price + taxableProduct.CalculateTax() - product.CalculateDiscount());
                Console.WriteLine("Final Price (Price + Tax - Discount): " + finalPrice);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

//3. Vehicle Rental System
using System;
using System.Collections.Generic;

// Abstract class Vehicle
public abstract class Vehicle
{
    // Encapsulated fields
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    // Constructor to initialize Vehicle attributes
    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    // Properties to access private fields
    public string VehicleNumber
    {
        get { return vehicleNumber; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }

    // Abstract method to calculate rental cost
    public abstract double CalculateRentalCost(int days);

    // Concrete method to display vehicle details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber + ", Type: " + type + ", Rental Rate: " + rentalRate);
    }
}

// Interface IInsurable
public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Subclass Car that inherits from Vehicle and implements IInsurable
public class Car : Vehicle, IInsurable
{
    // Additional attribute for Car
    private string insurancePolicyNumber;

    // Constructor to initialize Car attributes
    public Car(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
        : base(vehicleNumber, type, rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    // Implementing CalculateRentalCost method
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    // Implementing CalculateInsurance method
    public double CalculateInsurance()
    {
        return RentalRate * 0.05; // 5% of the rental rate as insurance
    }

    // Implementing GetInsuranceDetails method
    public string GetInsuranceDetails()
    {
        return "Insurance Policy Number: " + insurancePolicyNumber;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

// Subclass Bike that inherits from Vehicle and implements IInsurable
public class Bike : Vehicle, IInsurable
{
    // Additional attribute for Bike
    private string insurancePolicyNumber;

    // Constructor to initialize Bike attributes
    public Bike(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
        : base(vehicleNumber, type, rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    // Implementing CalculateRentalCost method
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    // Implementing CalculateInsurance method
    public double CalculateInsurance()
    {
        return RentalRate * 0.03; // 3% of the rental rate as insurance
    }

    // Implementing GetInsuranceDetails method
    public string GetInsuranceDetails()
    {
        return "Insurance Policy Number: " + insurancePolicyNumber;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

// Subclass Truck that inherits from Vehicle and implements IInsurable
public class Truck : Vehicle, IInsurable
{
    // Additional attribute for Truck
    private string insurancePolicyNumber;

    // Constructor to initialize Truck attributes
    public Truck(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
        : base(vehicleNumber, type, rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    // Implementing CalculateRentalCost method
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    // Implementing CalculateInsurance method
    public double CalculateInsurance()
    {
        return RentalRate * 0.07; // 7% of the rental rate as insurance
    }

    // Implementing GetInsuranceDetails method
    public string GetInsuranceDetails()
    {
        return "Insurance Policy Number: " + insurancePolicyNumber;
    }

    // Overriding DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

// Main program to demonstrate polymorphism
class Program
{
    static void Main(string[] args)
    {
        // Creating a list of Vehicle references
        List<Vehicle> vehicles = new List<Vehicle>();

        // Adding Car, Bike, and Truck to the list
        vehicles.Add(new Car("C123", "Car", 50, "CAR2023INS"));
        vehicles.Add(new Bike("B456", "Bike", 20, "BIKE2023INS"));
        vehicles.Add(new Truck("T789", "Truck", 100, "TRUCK2023INS"));

        // Processing and displaying details of each vehicle
        foreach (Vehicle vehicle in vehicles)
        {
            IInsurable insurableVehicle = vehicle as IInsurable;
            if (insurableVehicle != null)
            {
                double rentalCost = vehicle.CalculateRentalCost(5);
                double insuranceCost = insurableVehicle.CalculateInsurance();
                double finalCost = rentalCost + insuranceCost;
                Console.WriteLine("Total Cost (Rental + Insurance): " + finalCost);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


//4. Banking System
using System;
using System.Collections.Generic;

// Abstract class defining a generic bank account
abstract class BankAccount
{
    // Encapsulated fields
    private string accountNumber;
    private string holderName;
    private double balance;

    // Constructor to initialize account details
    public BankAccount(string accNumber, string name, double initialBalance)
    {
        accountNumber = accNumber;
        holderName = name;
        balance = initialBalance;
    }

    // Properties to access account details securely
    public string AccountNumber { get { return accountNumber; } }
    public string HolderName { get { return holderName; } }
    public double Balance { get { return balance; } protected set { balance = value; } }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    // Abstract method to be implemented in derived classes
    public abstract double CalculateInterest();
}

// SavingsAccount inherits from BankAccount and implements interest calculation
class SavingsAccount : BankAccount
{
    private double interestRate;

    public SavingsAccount(string accNumber, string name, double initialBalance, double rate)
        : base(accNumber, name, initialBalance)
    {
        interestRate = rate;
    }

    public override double CalculateInterest()
    {
        return Balance * (interestRate / 100);
    }
}

// CurrentAccount inherits from BankAccount and implements interest calculation
class CurrentAccount : BankAccount, ILoanable
{
    private double overdraftLimit;

    public CurrentAccount(string accNumber, string name, double initialBalance, double overdraft)
        : base(accNumber, name, initialBalance)
    {
        overdraftLimit = overdraft;
    }

    public override void Withdraw(double amount)
    {
        if (amount > 0 && amount <= (Balance + overdraftLimit))
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded.");
        }
    }

    public override double CalculateInterest()
    {
        return 0; // Current accounts typically don't earn interest
    }

    // Loan-related methods from ILoanable interface
    public void ApplyForLoan()
    {
        Console.WriteLine($"{HolderName} applied for a loan.");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 5; // Loan eligibility is 5 times the balance
    }
}

// Interface defining loan-related methods
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

// Main class to test the banking system
class Program
{
    static void Main()
    {
        // Create instances of different account types
        BankAccount savings = new SavingsAccount("S123", "Abhishek", 5000, 4.5);
        BankAccount current = new CurrentAccount("C456", "Mohit", 3000, 1000);

        // Demonstrating polymorphism
        List<BankAccount> accounts = new List<BankAccount> { savings, current };

        foreach (var acc in accounts)
        {
            Console.WriteLine($"\nAccount Holder: {acc.HolderName}");
            Console.WriteLine($"Interest Earned: {acc.CalculateInterest():C}");

            acc.Deposit(1000);
            acc.Withdraw(2000);
        }

        // Loan features for CurrentAccount
        ILoanable loanAccount = new CurrentAccount("C789", "Rahul", 7000, 2000);
        loanAccount.ApplyForLoan();
        Console.WriteLine($"Loan Eligibility: {loanAccount.CalculateLoanEligibility():C}");
        Console.ReadKey();
    }
}


//5. Library Management System
using System;
using System.Collections.Generic;

// Abstract Class LibraryItem
public abstract class LibraryItem
{
    // Fields
    private string itemId;
    private string title;
    private string author;

    // Constructor
    public LibraryItem(string itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    // Properties for encapsulation
    public string ItemId
    {
        get { return itemId; }
    }

    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    // Abstract method
    public abstract int GetLoanDuration();

    // Concrete method
    public string GetItemDetails()
    {
        return "ID: " + itemId + ", Title: " + title + ", Author: " + author;
    }
}

// Subclass Book
public class Book : LibraryItem
{
    public Book(string itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // Loan duration for books: 14 days
    }
}

// Subclass Magazine
public class Magazine : LibraryItem
{
    public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // Loan duration for magazines: 7 days
    }
}

// Subclass DVD
public class DVD : LibraryItem
{
    public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // Loan duration for DVDs: 3 days
    }
}

// Interface IReservable
public interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book("B001", "The Home and the World", "Rabindranath Tagore"),
            new Magazine("M001", "Malgudi Days", "R.K. Narayan"),
            new DVD("D001", "The God of Small Things ", "Arundathi Roy")
        };

        foreach (var item in items)
        {
            Console.WriteLine(item.GetItemDetails());
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

//6.  Online Food Delivery System
using System;
using System.Collections.Generic;

// Abstract class defining a generic food item
abstract class FoodItem
{
    // Encapsulated fields
    private string itemName;
    private double price;
    private int quantity;

    // Constructor to initialize item details
    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    // Properties to access item details securely
    public string ItemName { get { return itemName; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }

    // Abstract method to be implemented in derived classes
    public abstract double CalculateTotalPrice();

    // Concrete method to get item details
    public string GetItemDetails()
    {
        return $"Item: {itemName}, Price: {price:C}, Quantity: {quantity}";
    }
}

// VegItem inherits from FoodItem and implements total price calculation
class VegItem : FoodItem
{
    private double vegCharge;

    public VegItem(string itemName, double price, int quantity, double vegCharge)
        : base(itemName, price, quantity)
    {
        this.vegCharge = vegCharge;
    }

    public override double CalculateTotalPrice()
    {
        return (Price + vegCharge) * Quantity;
    }
}

// NonVegItem inherits from FoodItem and implements total price calculation
class NonVegItem : FoodItem, IDiscountable
{
    private double nonVegCharge;

    public NonVegItem(string itemName, double price, int quantity, double nonVegCharge)
        : base(itemName, price, quantity)
    {
        this.nonVegCharge = nonVegCharge;
    }

    public override double CalculateTotalPrice()
    {
        return (Price + nonVegCharge) * Quantity;
    }

    // Methods for IDiscountable interface
    public void ApplyDiscount(double discountPercentage)
    {
        nonVegCharge -= nonVegCharge * (discountPercentage / 100);
    }

    public string GetDiscountDetails()
    {
        return $"Discount applied. New Non-Veg charge: {nonVegCharge:C}";
    }
}

// Interface defining discount-related methods
interface IDiscountable
{
    void ApplyDiscount(double discountPercentage);
    string GetDiscountDetails();
}

// Main class to test the food delivery system
class Program
{
    static void Main()
    {
        // Create instances of different food items
        FoodItem vegItem = new VegItem("Veg Burger", 40, 2, 5);
        FoodItem nonVegItem = new NonVegItem("Chicken Burger", 80, 3, 10);

        // Demonstrating polymorphism
        List<FoodItem> items = new List<FoodItem> { vegItem, nonVegItem };

        foreach (var item in items)
        {
            Console.WriteLine(item.GetItemDetails());
            Console.WriteLine($"Total Price: {item.CalculateTotalPrice()}");
            Console.WriteLine();
        }

        // Applying discount to NonVegItem
        IDiscountable discountableItem = nonVegItem as IDiscountable;
        discountableItem.ApplyDiscount(10);
        Console.WriteLine(discountableItem.GetDiscountDetails());
        Console.WriteLine($"Total Price after discount: {nonVegItem.CalculateTotalPrice()}");
        Console.ReadKey();  
    }
}


//7.  Hospital Patient Management
using System;
using System.Collections.Generic;
// Abstract class defining a generic patient
abstract class Patient
{
    // Encapsulated fields
    private string patientId;
    private string name;
    private int age;
    private List<string> medicalRecords;

    // Constructor to initialize patient details
    public Patient(string patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        this.medicalRecords = new List<string>();
    }

    // Properties to access patient details securely
    public string PatientId { get { return patientId; } }
    public string Name { get { return name; } }
    public int Age { get { return age; } }

    // Encapsulation: Protect sensitive patient data
    public void AddMedicalRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public string GetMedicalRecords()
    {
        return string.Join(", ", medicalRecords);
    }

    // Abstract method to be implemented in derived classes
    public abstract double CalculateBill();

    // Concrete method to get patient details
    public string GetPatientDetails()
    {
        return $"Patient ID: {patientId}, Name: {name}, Age: {age}";
    }
}

// InPatient inherits from Patient and implements bill calculation
class InPatient : Patient, IMedicalRecord
{
    private double dailyRate;
    private int numberOfDays;

    public InPatient(string patientId, string name, int age, double dailyRate, int numberOfDays)
        : base(patientId, name, age)
    {
        this.dailyRate = dailyRate;
        this.numberOfDays = numberOfDays;
    }

    public override double CalculateBill()
    {
        return dailyRate * numberOfDays;
    }

    public void AddRecord(string record)
    {
        AddMedicalRecord(record);
    }

    public string ViewRecords()
    {
        return GetMedicalRecords();
    }
}

// OutPatient inherits from Patient and implements bill calculation
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(string patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        AddMedicalRecord(record);
    }

    public string ViewRecords()
    {
        return GetMedicalRecords();
    }
}

// Interface defining medical record methods
interface IMedicalRecord
{
    void AddRecord(string record);
    string ViewRecords();
}

// Main class to test the patient management system
class Program
{
    static void Main()
    {
        // Create instances of different patient types
        Patient inPatient = new InPatient("P001", "Robin", 35, 1000, 5);
        Patient outPatient = new OutPatient("P002", "Rajesh", 60, 500);

        // Adding medical records
        inPatient.AddMedicalRecord("Diagnosed with hypertension.");
        outPatient.AddMedicalRecord("Regular check-up.");

        // Demonstrating polymorphism
        List<Patient> patients = new List<Patient> { inPatient, outPatient };

        foreach (var patient in patients)
        {
            Console.WriteLine(patient.GetPatientDetails());
            Console.WriteLine($"Medical Records: {((IMedicalRecord)patient).ViewRecords()}");
            Console.WriteLine($"Total Bill: {patient.CalculateBill()}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
*/


//8. Ride-Hailing Application
using System;
using System.Collections.Generic;

// Abstract class defining a generic vehicle
abstract class Vehicle
{
    // Encapsulated fields
    private string vehicleId;
    private string driverName;
    private double ratePerKm;

    // Constructor to initialize vehicle details
    public Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    // Properties to access vehicle details securely
    public string VehicleId { get { return vehicleId; } }
    public string DriverName { get { return driverName; } }
    public double RatePerKm { get { return ratePerKm; } }

    // Abstract method to be implemented in derived classes
    public abstract double CalculateFare(double distance);

    // Concrete method to get vehicle details
    public string GetVehicleDetails()
    {
        return $"Vehicle ID: {vehicleId}, Driver: {driverName}, Rate per Km: {ratePerKm}";
    }
}

// Car class inherits from Vehicle and implements fare calculation
class Car : Vehicle, IGPS
{
    public Car(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
    }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    // Implement IGPS methods
    public string GetCurrentLocation()
    {
        return "Current location of Car.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine("Car location updated to: " + newLocation);
    }
}

// Bike class inherits from Vehicle and implements fare calculation
class Bike : Vehicle, IGPS
{
    public Bike(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
    }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    // Implement IGPS methods
    public string GetCurrentLocation()
    {
        return "Current location of Bike.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine("Bike location updated to: " + newLocation);
    }
}

// Auto class inherits from Vehicle and implements fare calculation
class Auto : Vehicle, IGPS
{
    public Auto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
    }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    // Implement IGPS methods
    public string GetCurrentLocation()
    {
        return "Current location of Auto.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine("Auto location updated to: " + newLocation);
    }
}

// Interface defining GPS methods
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Main class to test the ride-hailing application
class Program
{
    static void Main()
    {
        // Create instances of different vehicle types
        Vehicle car = new Car("V001", "Annu", 15);
        Vehicle bike = new Bike("V002", "Tushar", 10);
        Vehicle auto = new Auto("V003", "Chotu", 12);

        // Demonstrating polymorphism
        List<Vehicle> vehicles = new List<Vehicle> { car, bike, auto };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.GetVehicleDetails());
            double fare = vehicle.CalculateFare(10); // Calculate fare for 10 km
            Console.WriteLine($"Fare for 10 km: {fare}");
            Console.WriteLine($"Current Location: {((IGPS)vehicle).GetCurrentLocation()}");
            ((IGPS)vehicle).UpdateLocation("New Location");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

