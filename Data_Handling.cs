/*

//1. Read a CSV File and Print Data
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the file path of the CSV file
        Console.WriteLine("Enter the path to the CSV file:");
        string filePath = Console.ReadLine();

        try
        {
            // Read the CSV file
            List<Student> students = ReadCsvFile(filePath);

            // Print the student details in a structured format
            PrintStudentDetails(students);
        }
        catch (Exception ex)
        {
            // Handle any errors that may occur during file reading
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method to read the CSV file and return a list of Student objects
    static List<Student> ReadCsvFile(string filePath)
    {
        var students = new List<Student>();
        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine(); // Read the header line

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var student = new Student
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Marks = int.Parse(values[3])
                };
                students.Add(student);
            }
        }
        return students;
    }

    // Method to print the student details in a structured format
    static void PrintStudentDetails(List<Student> students)
    {
        Console.WriteLine("ID\tName\tAge\tMarks");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.ID}\t{student.Name}\t{student.Age}\t{student.Marks}");
        }
    }
}

// Class to represent a student
class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}


//2. Write Data to a CSV File
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        // Define the file path for the CSV file
        string filePath = "employees.csv";

        // Create a list of employee records
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "John Doe", Department = "HR", Salary = 50000 },
            new Employee { ID = 2, Name = "Jane Smith", Department = "IT", Salary = 60000 },
            new Employee { ID = 3, Name = "Alice Johnson", Department = "Finance", Salary = 55000 },
            new Employee { ID = 4, Name = "Bob Brown", Department = "Marketing", Salary = 52000 },
            new Employee { ID = 5, Name = "Charlie Davis", Department = "Sales", Salary = 53000 }
        };

        // Write the employee records to the CSV file
        WriteCsvFile(filePath, employees);

        Console.WriteLine($"Employee records have been written to {filePath}");
    }

    // Method to write a list of Employee objects to a CSV file
    static void WriteCsvFile(string filePath, List<Employee> employees)
    {
        using (var writer = new StreamWriter(filePath))
        {
            // Write the header line
            writer.WriteLine("ID,Name,Department,Salary");

            // Write each employee record
            foreach (var employee in employees)
            {
                writer.WriteLine($"{employee.ID},{employee.Name},{employee.Department},{employee.Salary}");
            }
        }
    }
}

// Class to represent an employee
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}


//3. Read and Count Rows in a CSV File
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define the file path for the CSV file
        string filePath = @"C:\\Users\\Lenovo\\OneDrive\\Desktop\\c# notes\\students_data.csv"; // Update this path accordingly

        try
        {
            // Count the number of records in the CSV file (excluding the header row)
            int recordCount = CountCsvRecords(filePath);

            // Print the count of records
            Console.WriteLine($"The number of records (excluding the header row) is: {recordCount}");
        }
        catch (Exception ex)
        {
            // Handle any errors that may occur during file reading
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method to count the number of records in the CSV file
    static int CountCsvRecords(string filePath)
    {
        int count = 0;
        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Read the header line and ignore it

            while (reader.ReadLine() != null)
            {
                count++;
            }
        }
        return count;
    }
}


//4. ⃣Filter Records from CSV
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Define the file path for the CSV file
        string filePath = "path/to/your/csvfile.csv"; // Update this path accordingly

        try
        {
            // Read the CSV file and filter students with more than 80 marks
            List<Student> filteredStudents = FilterStudentsByMarks(filePath, 80);

            // Print the qualifying student records
            PrintStudentDetails(filteredStudents);
        }
        catch (Exception ex)
        {
            // Handle any errors that may occur during file reading
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method to read the CSV file and filter students by marks
    static List<Student> FilterStudentsByMarks(string filePath, int minMarks)
    {
        var students = new List<Student>();
        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine(); // Read the header line

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var student = new Student
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Marks = int.Parse(values[3])
                };
                if (student.Marks > minMarks)
                {
                    students.Add(student);
                }
            }
        }
        return students;
    }

    // Method to print the student details in a structured format
    static void PrintStudentDetails(List<Student> students)
    {
        Console.WriteLine("ID\tName\tAge\tMarks");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.ID}\t{student.Name}\t{student.Age}\t{student.Marks}");
        }
    }
}

// Class to represent a student
class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}


//5. ️Search for a Record in CSV
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Define the file path for the CSV file
        string filePath = "employees.csv"; // Update this path accordingly

        // Define the employee name to search for
        string searchName = "Jane Smith"; // Update this name accordingly

        try
        {
            // Read the CSV file and search for the employee by name
            Employee employee = SearchEmployeeByName(filePath, searchName);

            // Print the employee's department and salary
            if (employee != null)
            {
                Console.WriteLine($"Department: {employee.Department}");
                Console.WriteLine($"Salary: {employee.Salary}");
            }
            else
            {
                Console.WriteLine($"Employee named {searchName} not found.");
            }
        }
        catch (Exception ex)
        {
            // Handle any errors that may occur during file reading
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method to search for an employee by name in the CSV file
    static Employee SearchEmployeeByName(string filePath, string name)
    {
        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine(); // Read the header line

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var employee = new Employee
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Department = values[2],
                    Salary = int.Parse(values[3])
                };
                if (employee.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return employee;
                }
            }
        }
        return null; // Return null if the employee is not found
    }
}

// Class to represent an employee
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}

//6. Modify a CSV File (Update a Value)
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Define the file path for the input CSV file
        string inputFilePath = "employees.csv"; // Update this path accordingly
        // Define the file path for the output CSV file
        string outputFilePath = "updated_employees.csv"; // Update this path accordingly

        try
        {
            // Read the CSV file and update the salaries of IT department employees
            List<Employee> updatedEmployees = UpdateSalaries(inputFilePath);

            // Write the updated employee records to a new CSV file
            WriteCsvFile(outputFilePath, updatedEmployees);

            Console.WriteLine($"Updated employee records have been saved to {outputFilePath}");
        }
        catch (Exception ex)
        {
            // Handle any errors that may occur during file reading or writing
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method to read the CSV file and update the salaries of IT department employees
    static List<Employee> UpdateSalaries(string filePath)
    {
        var employees = new List<Employee>();
        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine(); // Read the header line

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var employee = new Employee
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Department = values[2],
                    Salary = int.Parse(values[3])
                };

                // Increase the salary by 10% if the employee is in the IT department
                if (employee.Department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    employee.Salary = (int)(employee.Salary * 1.10);
                }

                employees.Add(employee);
            }
        }
        return employees;
    }

    // Method to write a list of Employee objects to a CSV file
    static void WriteCsvFile(string filePath, List<Employee> employees)
    {
        using (var writer = new StreamWriter(filePath))
        {
            // Write the header line
            writer.WriteLine("ID,Name,Department,Salary");

            // Write each employee record
            foreach (var employee in employees)
            {
                writer.WriteLine($"{employee.ID},{employee.Name},{employee.Department},{employee.Salary}");
            }
        }
    }
}

// Class to represent an employee
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}


//7. Sort CSV Records by a Column
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Define the file path for the CSV file
        string filePath = "employees.csv"; // Update this path accordingly

        try
        {
            // Read the CSV file and sort the records by Salary in descending order
            List<Employee> sortedEmployees = ReadAndSortEmployees(filePath);

            // Print the top 5 highest-paid employees
            PrintTopEmployees(sortedEmployees, 5);
        }
        catch (Exception ex)
        {
            // Handle any errors that may occur during file reading
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method to read the CSV file and sort the employees by Salary in descending order
    static List<Employee> ReadAndSortEmployees(string filePath)
    {
        var employees = new List<Employee>();
        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine(); // Read the header line

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var employee = new Employee
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Department = values[2],
                    Salary = int.Parse(values[3])
                };
                employees.Add(employee);
            }
        }

        // Sort the employees by Salary in descending order
        return employees.OrderByDescending(e => e.Salary).ToList();
    }

    // Method to print the top N highest-paid employees
    static void PrintTopEmployees(List<Employee> employees, int topN)
    {
        Console.WriteLine("ID\tName\tDepartment\tSalary");
        for (int i = 0; i < topN && i < employees.Count; i++)
        {
            var employee = employees[i];
            Console.WriteLine($"{employee.ID}\t{employee.Name}\t{employee.Department}\t{employee.Salary}");
        }
    }
}

// Class to represent an employee
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}


//8. Validate CSV Data Before Processing
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Define the file path for the CSV file
        string filePath = "contacts.csv"; // Update this path accordingly

        try
        {
            // Validate the CSV file data
            List<string> invalidRows = ValidateCsvData(filePath);

            // Print any invalid rows with an error message
            if (invalidRows.Count > 0)
            {
                Console.WriteLine("Invalid rows found:");
                foreach (var row in invalidRows)
                {
                    Console.WriteLine(row);
                }
            }
            else
            {
                Console.WriteLine("All rows are valid.");
            }
        }
        catch (Exception ex)
        {
            // Handle any errors that may occur during file reading
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method to validate the CSV file data
    static List<string> ValidateCsvData(string filePath)
    {
        var invalidRows = new List<string>();
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        var phoneRegex = new Regex(@"^\d{10}$");

        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine(); // Read the header line

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');

                // Validate the email format
                if (!emailRegex.IsMatch(values[2]))
                {
                    invalidRows.Add($"Invalid Email: {line}");
                }

                // Validate the phone number format
                if (!phoneRegex.IsMatch(values[3]))
                {
                    invalidRows.Add($"Invalid Phone Number: {line}");
                }
            }
        }
        return invalidRows;
    }
}


//9. Convert CSV Data into Java Objects
using System;
using System.Collections.Generic;
using System.IO;

// Class to represent a student
class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    // Override ToString() method for easy printing
    public override string ToString()
    {
        return $"Student{{ID={ID}, Name='{Name}', Age={Age}, Marks={Marks}}}";
    }
}

class Program
{
    static void Main()
    {
        // Define the file path for the CSV file
        string filePath = "students.csv"; // Update this path accordingly

        // Read the CSV file and convert each row into a Student object
        List<Student> students = ReadCsvFile(filePath);

        // Print the Student objects
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    // Method to read the CSV file and convert each row into a Student object
    static List<Student> ReadCsvFile(string filePath)
    {
        var students = new List<Student>();
        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine(); // Read the header line

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var student = new Student
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Marks = int.Parse(values[3])
                };
                students.Add(student);
            }
        }
        return students;
    }
}


//10. Merge Two CSV Files
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Read the first CSV file (students1.csv) and store the data in a dictionary
        Dictionary<int, (string Name, int Age)> students1 = new Dictionary<int, (string, int)>();
        using (var reader = new StreamReader("students1.csv"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                int id = int.Parse(values[0]);
                string name = values[1];
                int age = int.Parse(values[2]);
                students1[id] = (name, age);
            }
        }

        // Read the second CSV file (students2.csv) and store the data in a dictionary
        Dictionary<int, (int Marks, string Grade)> students2 = new Dictionary<int, (int, string)>();
        using (var reader = new StreamReader("students2.csv"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                int id = int.Parse(values[0]);
                int marks = int.Parse(values[1]);
                string grade = values[2];
                students2[id] = (marks, grade);
            }
        }

        // Merge the data based on ID and create a new file (merged_students.csv) with all details
        using (var writer = new StreamWriter("merged_students.csv"))
        {
            // Write header
            writer.WriteLine("ID,Name,Age,Marks,Grade");

            foreach (var student1 in students1)
            {
                int id = student1.Key;
                var (name, age) = student1.Value;

                if (students2.TryGetValue(id, out var student2))
                {
                    var (marks, grade) = student2;
                    writer.WriteLine($"{id},{name},{age},{marks},{grade}");
                }
            }
        }

        Console.WriteLine("Merging completed! The merged file is saved as merged_students.csv.");
    }
}

//11. Read Large CSV File Efficiently
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "large_file.csv";
        int chunkSize = 100; // Number of lines to read at a time

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                int lineCount = 0;
                int recordCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    // Process the current line (you can add your logic here)
                    // For example, you could parse the line and perform some operation on it
                    Console.WriteLine(line); // Just printing the line for demonstration

                    lineCount++;
                    recordCount++;

                    if (lineCount == chunkSize)
                    {
                        Console.WriteLine($"Processed {recordCount} records so far.");
                        lineCount = 0; // Reset line counter after processing a chunk
                    }
                }

                // Display the final count of records processed
                Console.WriteLine($"Total records processed: {recordCount}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        }
    }
}

//12. Detect Duplicates in a CSV File
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "students.csv";

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                var seenIds = new HashSet<int>();
                var duplicateRecords = new List<string>();
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        // Skip the header line
                        isHeader = false;
                        continue;
                    }

                    var values = line.Split(',');
                    int id = int.Parse(values[0]);

                    if (seenIds.Contains(id))
                    {
                        // If the ID is already seen, it's a duplicate
                        duplicateRecords.Add(line);
                    }
                    else
                    {
                        // Add the ID to the set
                        seenIds.Add(id);
                    }
                }

                if (duplicateRecords.Count > 0)
                {
                    Console.WriteLine("Duplicate Records Found:");
                    foreach (var record in duplicateRecords)
                    {
                        Console.WriteLine(record);
                    }
                }
                else
                {
                    Console.WriteLine("No duplicate records found.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        }
    }
}

//13. ️ Generate a CSV Report from Database
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

class Program
{
    static void Main()
    {
        // Define the connection string (replace with your own database details)
        string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        // Create a new DataTable to hold the employee records
        DataTable employeeTable = new DataTable();

        // Define the query to fetch employee records
        string query = "SELECT EmployeeID, Name, Department, Salary FROM employees";

        // Establish a connection to the database
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create a SqlDataAdapter to execute the query and fill the DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            // Open the database connection
            connection.Open();

            // Fill the DataTable with the results from the query
            adapter.Fill(employeeTable);

            // Close the database connection
            connection.Close();
        }

        // Define the path for the CSV file
        string csvFilePath = "employee_report.csv";

        // Create a StreamWriter to write to the CSV file
        using (StreamWriter writer = new StreamWriter(csvFilePath))
        {
            // Write the headers to the CSV file
            writer.WriteLine("Employee ID,Name,Department,Salary");

            // Iterate through each row in the DataTable
            foreach (DataRow row in employeeTable.Rows)
            {
                // Write the employee records to the CSV file
                writer.WriteLine($"{row["EmployeeID"]},{row["Name"]},{row["Department"]},{row["Salary"]}");
            }
        }

        Console.WriteLine("CSV report generated successfully!");
    }
}

//14. Convert JSON to CSV and Vice Versa
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Path to the JSON file
        string jsonFilePath = "students.json";

        // Read the JSON file
        string jsonData = File.ReadAllText(jsonFilePath);

        // Deserialize JSON data to a list of Student objects
        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

        // Path to the CSV file
        string csvFilePath = "students.csv";

        // Convert JSON to CSV and save it
        using (StreamWriter writer = new StreamWriter(csvFilePath))
        {
            // Write headers
            writer.WriteLine("Student ID,Name,Age,Grade");

            // Write student records
            foreach (Student student in students)
            {
                writer.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Grade}");
            }
        }

        Console.WriteLine("JSON to CSV conversion successful!");
    }
}

// Define the Student class to match the JSON structure
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
}

// OR 
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Path to the CSV file
        string csvFilePath = "students.csv";

        // List to hold student records
        List<Student> students = new List<Student>();

        // Read the CSV file
        using (StreamReader reader = new StreamReader(csvFilePath))
        {
            // Skip the header line
            reader.ReadLine();

            // Read student records
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(',');

                Student student = new Student
                {
                    Id = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Grade = values[3]
                };

                students.Add(student);
            }
        }

        // Path to the JSON file
        string jsonFilePath = "students.json";

        // Convert CSV to JSON and save it
        string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
        File.WriteAllText(jsonFilePath, jsonData);

        Console.WriteLine("CSV to JSON conversion successful!");
    }
}

// Define the Student class to match the CSV structure
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
}


//15. Encrypt and Decrypt CSV Data
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

class Program
{
    // Encryption key
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("YourEncryptionKeyYourEncryptionKey");
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("YourInitVector");

    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "John Doe", Department = "IT", Salary = "50000", Email = "john.doe@example.com" },
            new Employee { ID = 2, Name = "Jane Smith", Department = "HR", Salary = "60000", Email = "jane.smith@example.com" }
        };

        // Write encrypted data to CSV
        WriteEncryptedCsv(employees, "employees_encrypted.csv");

        // Read and decrypt data from CSV
        var decryptedEmployees = ReadDecryptedCsv("employees_encrypted.csv");

        // Display decrypted data
        foreach (var emp in decryptedEmployees)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}, Email: {emp.Email}");
        }
    }

    // Encrypt a string
    private static string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
    }

    // Decrypt a string
    private static string Decrypt(string cipherText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
            {
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }
    }

    // Write encrypted CSV file
    private static void WriteEncryptedCsv(List<Employee> employees, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
        {
            foreach (var emp in employees)
            {
                emp.Salary = Encrypt(emp.Salary);
                emp.Email = Encrypt(emp.Email);
                csv.WriteRecord(emp);
                writer.WriteLine();
            }
        }
    }

    // Read and decrypt CSV file
    private static List<Employee> ReadDecryptedCsv(string filePath)
    {
        var employees = new List<Employee>();
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
        {
            while (csv.Read())
            {
                var emp = csv.GetRecord<Employee>();
                emp.Salary = Decrypt(emp.Salary);
                emp.Email = Decrypt(emp.Email);
                employees.Add(emp);
            }
        }
        return employees;
    }

    // Employee class with attributes for CSV mapping
    public class Employee
    {
        [Name("ID")]
        public int ID { get; set; }
        [Name("Name")]
        public string Name { get; set; }
        [Name("Department")]
        public string Department { get; set; }
        [Name("Salary")]
        public string Salary { get; set; }
        [Name("Email")]
        public string Email { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace Week_5_Assignment_1
{
    internal class ReadCSVFile
    {
        public void ReadFile()
        {
            string filePath = @"C:\Users\Lenovo\OneDrive\Desktop\c# notes\students_data.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] column = line.Split(',');
                        Console.WriteLine("Student Id: " + column[0] + " name: " + column[1] + " age: " + column[2] + " mark: " + column[3]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

*/
