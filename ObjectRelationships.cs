/*
//1. Library and Books (Aggregation)
using System;
using System.Collections.Generic;

// Define the Book class
public class Book
{
    // Properties for Title and Author
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize the Book object
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Override ToString to provide a readable representation of the Book
    public override string ToString()
    {
        return Title+" by "+Author;
    }
}

// Define the Library class
public class Library
{
    // List to store Book objects
    public List<Book> Books { get; set; }

    // Constructor to initialize the Library object
    public Library()
    {
        Books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    // Method to display all books in the library
    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }
}

// Main program to demonstrate the aggregation relationship
class Program
{
    static void Main(string[] args)
    {
        // Create some Book objects
        Book book1 = new Book("God of Small Things", "Arundhati Roy");
        Book book2 = new Book("The Glass Palace", "Amitav Ghosh");
        Book book3 = new Book("The Private Life of an Indian Prince", "Mulk Raj Anand");

        // Create a Library object
        Library library1 = new Library();

        // Add books to the library
        library1.AddBook(book1);
        library1.AddBook(book2);

        // Display books in the library
        library1.DisplayBooks();

        // Create another Library object
        Library library2 = new Library();

        // Add a different set of books to the second library
        library2.AddBook(book2);
        library2.AddBook(book3);

        // Display books in the second library
        library2.DisplayBooks();

        // Demonstrate that books can exist independently
        Console.WriteLine("\nBooks existing independently:");
        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);
    }
}

//2.  Bank and Account Holders (Association)
using System;
using System.Collections.Generic;

// Define the Customer class
public class Customer
{
    // Properties for Customer
    public string Name { get; set; }
    public Dictionary<string, decimal> Accounts { get; set; } // Key: Account ID, Value: Balance

    // Constructor to initialize the Customer object
    public Customer(string name)
    {
        Name = name;
        Accounts = new Dictionary<string, decimal>();
    }

    // Method to view the balance of a specific account
    public void ViewBalance(string accountId)
    {
        if (Accounts.ContainsKey(accountId))
        {
            Console.WriteLine(Name+"'s balance for account "+accountId+": "+Accounts[accountId]);
        }
        else
        {
            Console.WriteLine("Account "+accountId+" not found for "+Name);
        }
    }
}

// Define the Bank class
public class Bank
{
    // Properties for Bank
    public string Name { get; set; }
    public List<Customer> Customers { get; set; }

    // Constructor to initialize the Bank object
    public Bank(string name)
    {
        Name = name;
        Customers = new List<Customer>();
    }

    // Method to open an account for a customer
    public void OpenAccount(Customer customer, string accountId, decimal initialBalance)
    {
        if (!customer.Accounts.ContainsKey(accountId))
        {
            customer.Accounts.Add(accountId, initialBalance);
            Customers.Add(customer); // Associate the customer with the bank
            Console.WriteLine("Account "+accountId+" opened for "+customer.Name+" with initial balance "+initialBalance);
        }
        else
        {
            Console.WriteLine("Account "+accountId+" already exists for "+customer.Name);
        }
    }
}

// Main program to demonstrate the association relationship
class Program
{
    static void Main(string[] args)
    {
        // Create a Bank object
        Bank bank = new Bank("National Bank");

        // Create Customer objects
        Customer customer1 = new Customer("Robin");
        Customer customer2 = new Customer("Bobby");

        // Open accounts for customers in the bank
        bank.OpenAccount(customer1, "A1001", 500);
        bank.OpenAccount(customer1, "A1002", 1000); // Alice has multiple accounts
        bank.OpenAccount(customer2, "B2001", 1500);

        // View balances for customers
        customer1.ViewBalance("A1001");
        customer1.ViewBalance("A1002");
        customer2.ViewBalance("B2001");

        // Attempt to view a non-existent account
        customer1.ViewBalance("A9999");
    }
}

//3. Company and Departments (Composition)
using System;
using System.Collections.Generic;

// Define the Employee class
public class Employee
{
    // Properties for Employee
    public string Name { get; set; }
    public string Role { get; set; }

    // Constructor to initialize the Employee object
    public Employee(string name, string role)
    {
        Name = name;
        Role = role;
    }

    // Override ToString to provide a readable representation of the Employee
    public override string ToString()
    {
        return Name+" ("+Role+")";
    }
}

// Define the Department class
public class Department
{
    // Properties for Department
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    // Constructor to initialize the Department object
    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }

    // Method to add an employee to the department
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    // Override ToString to provide a readable representation of the Department
    public override string ToString()
    {
        return Name+" Department";
    }
}

// Define the Company class
public class Company
{
    // Properties for Company
    public string Name { get; set; }
    public List<Department> Departments { get; set; }

    // Constructor to initialize the Company object
    public Company(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    // Method to add a department to the company
    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    // Method to display all departments and employees in the company
    public void DisplayCompanyStructure()
    {
        Console.WriteLine("Company: "+Name);
        foreach (var department in Departments)
        {
            Console.WriteLine("  "+department);
            foreach (var employee in department.Employees)
            {
                Console.WriteLine("    - "+employee);
            }
        }
    }
}

// Main program to demonstrate the composition relationship
class Program
{
    static void Main(string[] args)
    {
        // Create a Company object
        Company company = new Company("Tech Corp");

        // Create Department objects
        Department hrDepartment = new Department("HR");
        Department itDepartment = new Department("IT");

        // Create Employee objects
        Employee emp1 = new Employee("Tushar", "HR Manager");
        Employee emp2 = new Employee("Mohit", "HR Assistant");
        Employee emp3 = new Employee("Tulshi", "Software Engineer");
        Employee emp4 = new Employee("Dav", "System Administrator");

        // Add employees to departments
        hrDepartment.AddEmployee(emp1);
        hrDepartment.AddEmployee(emp2);
        itDepartment.AddEmployee(emp3);
        itDepartment.AddEmployee(emp4);

        // Add departments to the company
        company.AddDepartment(hrDepartment);
        company.AddDepartment(itDepartment);

        // Display the company structure
        company.DisplayCompanyStructure();

        // Simulate deleting the company (composition ensures departments and employees are also deleted)
        Console.WriteLine("\nDeleting the company...");
        company = null; // Company object is deleted

        // Attempting to access departments or employees will result in a NullReferenceException
        // This demonstrates that departments and employees cannot exist without the company
        Console.WriteLine("Company, departments, and employees have been deleted.");
    }
}
//3.1.
using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public void Display()
    {
        Console.WriteLine("  Employee: "+Name+", Position: "+Position);
    }
}

class Department
{
    public string Name { get; set; }
    private List<Employee> employees;

    public Department(string name)
    {
        Name = name;
        employees = new List<Employee>();
    }

    public void AddEmployee(string name, string position)
    {
        employees.Add(new Employee(name, position));
    }

    public void Display()
    {
        Console.WriteLine("Department: "+Name);
        foreach (var emp in employees)
        {
            emp.Display();
        }
    }
}

class Company
{
    public string Name { get; set; }
    private List<Department> departments;

    public Company(string name)
    {
        Name = name;
        departments = new List<Department>();
    }

    public void AddDepartment(string departmentName)
    {
        departments.Add(new Department(departmentName));
    }

    public Department GetDepartment(string departmentName)
    {
        return departments.Find(d => d.Name == departmentName);
    }

    public void Display()
    {
        Console.WriteLine("Company: "+Name);
        foreach (var dept in departments)
        {
            dept.Display();
        }
    }

    public void Dispose() // Simulating deletion
    {
        departments.Clear(); // Removing all departments
        Console.WriteLine("Company "+Name+" deleted. All departments and employees removed.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a company
        Company company = new Company("Tech Corp");

        // Adding departments
        company.AddDepartment("IT");
        company.AddDepartment("HR");

        // Adding employees to departments
        company.GetDepartment("IT").AddEmployee("Tushar", "Software Engineer");
        company.GetDepartment("IT").AddEmployee("Mohit", "System Admin");

        company.GetDepartment("HR").AddEmployee("Tulshi", "HR Manager");

        // Display company details
        company.Display();

        // Deleting the company (simulating composition)
        company.Dispose();
    }
}



// Self Problems
 
//1. School and Students with Courses (Association and Aggregation)
using System;
using System.Collections.Generic;

// Define the Course class
public class Course
{
    // Properties for Course
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    // Constructor to initialize the Course object
    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    // Method to enroll a student in the course
    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
        student.EnrollInCourse(this); // Associate the student with the course
    }

    // Method to display enrolled students in the course
    public void DisplayEnrolledStudents()
    {
        Console.WriteLine("Students enrolled in "+CourseName);
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine("- "+student.Name);
        }
    }
}

// Define the Student class
public class Student
{
    // Properties for Student
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    // Constructor to initialize the Student object
    public Student(string name)
    {
        Name = name;
        EnrolledCourses = new List<Course>();
    }

    // Method to enroll the student in a course
    public void EnrollInCourse(Course course)
    {
        EnrolledCourses.Add(course);
    }

    // Method to display the courses the student is enrolled in
    public void DisplayEnrolledCourses()
    {
        Console.WriteLine(Name+"'s enrolled courses:");
        foreach (var course in EnrolledCourses)
        {
            Console.WriteLine("- "+course.CourseName);
        }
    }
}

// Define the School class
public class School
{
    // Properties for School
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    // Constructor to initialize the School object
    public School(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    // Method to add a student to the school
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    // Method to display all students in the school
    public void DisplayStudents()
    {
        Console.WriteLine("Students in "+Name+":");
        foreach (var student in Students)
        {
            Console.WriteLine("- "+student.Name);
        }
    }
}

// Main program to demonstrate association and aggregation
class Program
{
    static void Main(string[] args)
    {
        // Create a School object
        School school = new School("Greenwood High");

        // Create Student objects
        Student student1 = new Student("Annu");
        Student student2 = new Student("Harsh");

        // Add students to the school (aggregation)
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Create Course objects
        Course mathCourse = new Course("Mathematics");
        Course scienceCourse = new Course("Science");

        // Enroll students in courses (association)
        mathCourse.EnrollStudent(student1);
        scienceCourse.EnrollStudent(student1);
        scienceCourse.EnrollStudent(student2);

        // Display school students
        school.DisplayStudents();

        // Display enrolled courses for each student
        student1.DisplayEnrolledCourses();
        student2.DisplayEnrolledCourses();

        // Display enrolled students for each course
        mathCourse.DisplayEnrolledStudents();
        scienceCourse.DisplayEnrolledStudents();
    }
}


//2. University with Faculties and Departments (Composition and Aggregation)
using System;
using System.Collections.Generic;

// Define the Faculty class
public class Faculty
{
    // Properties for Faculty
    public string Name { get; set; }
    public string Specialization { get; set; }

    // Constructor to initialize the Faculty object
    public Faculty(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }

    // Override ToString to provide a readable representation of the Faculty
    public override string ToString()
    {
        return Name+" ("+Specialization+")";
    }
}

// Define the Department class
public class Department
{
    // Properties for Department
    public string Name { get; set; }
    public List<Faculty> FacultyMembers { get; set; }

    // Constructor to initialize the Department object
    public Department(string name)
    {
        Name = name;
        FacultyMembers = new List<Faculty>();
    }

    // Method to add a faculty member to the department
    public void AddFaculty(Faculty faculty)
    {
        FacultyMembers.Add(faculty);
    }

    // Method to display faculty members in the department
    public void DisplayFaculty()
    {
        Console.WriteLine("Faculty members in "+Name+" Department:");
        foreach (var faculty in FacultyMembers)
        {
            Console.WriteLine("- "+faculty);
        }
    }
}

// Define the University class
public class University
{
    // Properties for University
    public string Name { get; set; }
    public List<Department> Departments { get; set; }

    // Constructor to initialize the University object
    public University(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    // Method to add a department to the university
    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    // Method to display all departments and faculty in the university
    public void DisplayUniversityStructure()
    {
        Console.WriteLine("University: "+Name);
        foreach (var department in Departments)
        {
            Console.WriteLine("  "+department.Name+" Department");
            department.DisplayFaculty();
        }
    }
}

// Main program to demonstrate composition and aggregation
class Program
{
    static void Main(string[] args)
    {
        // Create a University object
        University university = new University("Tech University");

        // Create Department objects
        Department csDepartment = new Department("Computer Science");
        Department mathDepartment = new Department("Mathematics");

        // Create Faculty objects
        Faculty faculty1 = new Faculty("Dr. Sonu", "Artificial Intelligence");
        Faculty faculty2 = new Faculty("Dr. Abhinav", "Data Structures");
        Faculty faculty3 = new Faculty("Dr. Dinesh", "Calculus");

        // Add faculty members to departments
        csDepartment.AddFaculty(faculty1);
        csDepartment.AddFaculty(faculty2);
        mathDepartment.AddFaculty(faculty3);

        // Add departments to the university
        university.AddDepartment(csDepartment);
        university.AddDepartment(mathDepartment);

        // Display the university structure
        university.DisplayUniversityStructure();

        // Simulate deleting the university (composition ensures departments are also deleted)
        Console.WriteLine("\nDeleting the university...");
        university = null; // University object is deleted

        // Attempting to access departments will result in a NullReferenceException
        // This demonstrates that departments cannot exist without the university
        Console.WriteLine("University and its departments have been deleted.");

        // Faculty members can still exist independently (aggregation)
        Console.WriteLine("\nFaculty members existing independently:");
        Console.WriteLine(faculty1);
        Console.WriteLine(faculty2);
        Console.WriteLine(faculty3);
    }
}


//3. Hospital, Doctors, and Patients (Association and Communication)
using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Patient(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine("Patient: "+Name+", Age: "+Age);
    }
}

class Doctor
{
    public string Name { get; set; }
    public string Specialization { get; set; }
    private List<Patient> patients;  // Association with patients

    public Doctor(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
        patients = new List<Patient>();
    }

    public void Consult(Patient patient)
    {
        if (!patients.Contains(patient))
            patients.Add(patient);
        
        Console.WriteLine("Doctor "+Name+" ("+Specialization+") is consulting patient "+patient.Name+".");
    }

    public void DisplayPatients()
    {
        Console.WriteLine("Doctor "+Name+" Patients:");
        foreach (var patient in patients)
        {
            patient.Display();
        }
        Console.WriteLine();
    }
}

class Hospital
{
    public string Name { get; set; }
    private List<Doctor> doctors;
    private List<Patient> patients;

    public Hospital(string name)
    {
        Name = name;
        doctors = new List<Doctor>();
        patients = new List<Patient>();
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }

    public void DisplayDoctors()
    {
        Console.WriteLine("Hospital: "+Name);
        foreach (var doctor in doctors)
        {
            Console.WriteLine("Doctor: "+doctor.Name+", Specialization: "+doctor.Specialization);
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creating a hospital
        Hospital hospital = new Hospital("City Hospital");

        // Creating doctors
        Doctor doctor1 = new Doctor("Dr. Annu", "Cardiology");
        Doctor doctor2 = new Doctor("Dr. Harsh", "Neurology");

        // Creating patients
        Patient patient1 = new Patient("Dinesh", 30);
        Patient patient2 = new Patient("Surjeet", 45);

        // Adding doctors and patients to the hospital
        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);

        // Display doctors in the hospital
        hospital.DisplayDoctors();

        // Doctor consultations (Association & Communication)
        doctor1.Consult(patient1);
        doctor1.Consult(patient2);
        doctor2.Consult(patient1);  // Same patient consulting another doctor

        // Display doctor-patient associations
        doctor1.DisplayPatients();
        doctor2.DisplayPatients();
    }
}


//4. E-commerce Platform with Orders, Customers, and Products
using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine("  Product: "+Name+", Price: "+Price);
    }
}

class Order
{
    public int OrderID { get; set; }
    private List<Product> products; // Aggregation (Order contains multiple Products)

    public Order(int orderId)
    {
        OrderID = orderId;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Order ID: "+OrderID);
        foreach (var product in products)
        {
            product.Display();
        }
        Console.WriteLine();
    }
}

class Customer
{
    public string Name { get; set; }
    private List<Order> orders; // Association (Customer places Orders)

    public Customer(string name)
    {
        Name = name;
        orders = new List<Order>();
    }

    public void PlaceOrder(Order order)
    {
        orders.Add(order);
        Console.WriteLine("Customer "+Name+" placed Order ID: "+order.OrderID);
    }

    public void DisplayOrders()
    {
        Console.WriteLine("Customer: "+Name);
        foreach (var order in orders)
        {
            order.DisplayOrder();
        }
    }
}

class ECommercePlatform
{
    static void Main()
    {
        // Creating products
        Product product1 = new Product("Laptop", 1200.50);
        Product product2 = new Product("Smartphone", 699.99);
        Product product3 = new Product("Headphones", 199.99);

        // Creating customers
        Customer customer1 = new Customer("Ravi");
        Customer customer2 = new Customer("Annu");

        // Creating orders
        Order order1 = new Order(101);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(102);
        order2.AddProduct(product3);

        // Customers placing orders
        customer1.PlaceOrder(order1);
        customer2.PlaceOrder(order2);

        // Display customer orders
        customer1.DisplayOrders();
        customer2.DisplayOrders();
    }
}


//5. University Management System
using System;
using System.Collections.Generic;

class Course
{
    public string CourseName { get; set; }
    private Professor AssignedProfessor; // Aggregation (Course contains Professor)
    private List<Student> enrolledStudents; // Association (Many Students enroll)

    public Course(string courseName)
    {
        CourseName = courseName;
        enrolledStudents = new List<Student>();
    }

    public void AssignProfessor(Professor professor)
    {
        AssignedProfessor = professor;
        Console.WriteLine("Professor "+professor.Name+" assigned to "+CourseName);
    }

    public void EnrollStudent(Student student)
    {
        enrolledStudents.Add(student);
        Console.WriteLine("Student "+student.Name+" enrolled in "+CourseName);
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("\nCourse: "+CourseName);
        if (AssignedProfessor != null)
            Console.WriteLine("Taught by: Professor "+AssignedProfessor.Name);

        Console.WriteLine("Enrolled Students:");
        foreach (var student in enrolledStudents)
        {
            Console.WriteLine(" - "+student.Name);
        }
    }
}

class Professor
{
    public string Name { get; set; }

    public Professor(string name)
    {
        Name = name;
    }
}

class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class University
{
    static void Main()
    {
        // Creating professors
        Professor professor1 = new Professor("Dr. Sumit");
        Professor professor2 = new Professor("Dr. Abhi");

        // Creating courses
        Course course1 = new Course("Computer Science");
        Course course2 = new Course("Mathematics");

        // Assigning professors to courses
        course1.AssignProfessor(professor1);
        course2.AssignProfessor(professor2);

        // Creating students
        Student student1 = new Student("Amit");
        Student student2 = new Student("Bharat");
        Student student3 = new Student("Tushar");

        // Enrolling students in courses
        course1.EnrollStudent(student1);
        course1.EnrollStudent(student2);
        course2.EnrollStudent(student3);

        // Display course details
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
*/