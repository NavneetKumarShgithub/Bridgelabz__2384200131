/*
//1. Basic JSON Handling
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create a JSON object for a Student with fields: name, age, and subjects (array).
        var student = new
        {
            name = "John Doe",
            age = 22,
            subjects = new[] { "Math", "Science", "History" }
        };
        string studentJson = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine("1. Student JSON:\n" + studentJson);

        // 2. Convert a C# object (Car class) into JSON format.
        var car = new Car { Make = "Toyota", Model = "Corolla", Year = 2020 };
        string carJson = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine("\n2. Car JSON:\n" + carJson);

        // 3. Read a JSON file and extract only specific fields (e.g., name, email).
        string jsonFilePath = "data.json"; // Replace with your JSON file path
        string jsonContent = File.ReadAllText(jsonFilePath);
        JObject jsonObject = JObject.Parse(jsonContent);
        var name = (string)jsonObject["name"];
        var email = (string)jsonObject["email"];
        Console.WriteLine("\n3. Extracted Fields:\nName: " + name + "\nEmail: " + email);

        // 4. Merge two JSON objects into one.
        var json1 = "{ \"name\": \"John\", \"age\": 30 }";
        var json2 = "{ \"email\": \"john@example.com\", \"city\": \"New York\" }";
        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);
        obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });
        Console.WriteLine("\n4. Merged JSON:\n" + obj1.ToString());

        // 5. Validate JSON structure using Newtonsoft.Json.Schema.
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'name': {'type':'string'},
                'age': {'type':'integer'}
            }
        }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject person = JObject.Parse("{ \"name\": \"Mohit\", \"age\": 30 }");
        bool valid = person.IsValid(schema);
        Console.WriteLine("\n5. JSON Validation Result: " + valid);

        // 6. Convert a list of C# objects into a JSON array.
        var cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Corolla", Year = 2020 },
            new Car { Make = "Honda", Model = "Civic", Year = 2019 }
        };
        string carsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);
        Console.WriteLine("\n6. List of Cars as JSON Array:\n" + carsJson);

        // 7. Parse JSON and filter only those records where age > 25.
        string peopleJson = "[{ \"name\": \"John\", \"age\": 30 }, { \"name\": \"Jane\", \"age\": 22 }]";
        JArray peopleArray = JArray.Parse(peopleJson);
        var filteredPeople = peopleArray.Where(p => (int)p["age"] > 25);
        Console.WriteLine("\n7. Filtered JSON (age > 25):\n" + new JArray(filteredPeople).ToString());
    }
}

// Car class for demonstration
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}


//2. Hands-on Practice Problems
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main(string[] args)
    {
        // 1. Read a JSON file and print all keys and values.
        string jsonFilePath = @"C:\\Users\\Lenovo\\OneDrive\\Desktop\\c# notes\\sample1.json"; // Replace with your JSON file path
        string jsonContent = File.ReadAllText(jsonFilePath);
        JObject jsonObject = JObject.Parse(jsonContent);
        Console.WriteLine("1. All Keys and Values:");
        foreach (var kvp in jsonObject)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // 2. Convert a list of C# objects into a JSON array.
        var students = new List<Student>
        {
            new Student { Name = "John", Age = 22 },
            new Student { Name = "Jane", Age = 25 }
        };
        string studentsJson = JsonConvert.SerializeObject(students, Formatting.Indented);
        Console.WriteLine("\n2. List of Students as JSON Array:\n" + studentsJson);

        // 3. Filter JSON data: Print only users older than 25 years.
        string usersJson = "[{ \"name\": \"John\", \"age\": 30 }, { \"name\": \"Jane\", \"age\": 22 }]";
        JArray usersArray = JArray.Parse(usersJson);
        var filteredUsers = usersArray.Where(u => (int)u["age"] > 25);
        Console.WriteLine("\n3. Filtered Users (age > 25):");
        foreach (var user in filteredUsers)
        {
            Console.WriteLine($"{user["name"]} - {user["age"]}");
        }

        // 4. Validate an email field using JSON Schema.
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'email': {'type': 'string', 'format': 'email'}
            }
        }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject person = JObject.Parse("{ \"email\": \"john@example.com\" }");
        bool valid = person.IsValid(schema);
        Console.WriteLine("\n4. Email Validation Result: " + valid);

        // 5. Merge two JSON files into a single JSON object.
        string json1 = File.ReadAllText(@"C:\\Users\\Lenovo\\OneDrive\\Desktop\\c# notes\\sample1.json"); // Replace with your file path
        string json2 = File.ReadAllText(@"C:\\Users\\Lenovo\\OneDrive\\Desktop\\c# notes\\sample2.json"); // Replace with your file path
        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);
        obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });
        Console.WriteLine("\n5. Merged JSON:\n" + obj1.ToString());

        // 6. Convert JSON to XML format.
        JObject jsonForXml = JObject.Parse("{ \"name\": \"John\", \"age\": 30 }");
        string xml = JsonConvert.DeserializeXmlNode(jsonForXml.ToString(), "root").OuterXml;
        Console.WriteLine("\n6. JSON to XML:\n" + xml);

        // 7. Convert CSV data into JSON.
        string csvFilePath = @"C:\\Users\\Lenovo\\OneDrive\\Desktop\\c# notes\\students_data.csv"; // Replace with your CSV file path
        var csv = new List<string[]>();
        var lines = File.ReadAllLines(csvFilePath);
        foreach (var line in lines)
        {
            csv.Add(line.Split(','));
        }
        var headers = csv[0];
        var csvJson = new List<Dictionary<string, string>>();
        for (int i = 1; i < csv.Count; i++)
        {
            var row = new Dictionary<string, string>();
            for (int j = 0; j < headers.Length; j++)
            {
                row[headers[j]] = csv[i][j];
            }
            csvJson.Add(row);
        }
        string csvJsonString = JsonConvert.SerializeObject(csvJson, Formatting.Indented);
        Console.WriteLine("\n7. CSV to JSON:\n" + csvJsonString);

        // 8. Generate a JSON report from database records.
        string connectionString = "YourConnectionStringHere"; // Replace with your DB connection string
        var dbRecords = new List<Dictionary<string, object>>();
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Employees", connection); // Replace with your table name
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var record = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    record[reader.GetName(i)] = reader.GetValue(i);
                }
                dbRecords.Add(record);
            }
        }
        string dbJson = JsonConvert.SerializeObject(dbRecords, Formatting.Indented);
        Console.WriteLine("\n8. Database Records as JSON:\n" + dbJson);
    }
}

// Student class for demonstration
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}


//3. Problem Statement: IPL and Censorship Analyzer
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Input file paths
        string jsonInputPath = @"C:\\Users\\Lenovo\\OneDrive\\Desktop\\files diff\\ipl_data.json"; // Replace with your JSON file path
        string csvInputPath = @"C:\Users\Lenovo\OneDrive\Desktop\files diff\ipl_data.csv";   // Replace with your CSV file path

        // Output file paths
        string jsonOutputPath = @"C:\Users\Lenovo\OneDrive\Desktop\files diff\censored_ipl_data.json";
        string csvOutputPath = @"C:\Users\Lenovo\OneDrive\Desktop\files diff\censored_ipl_data.csv";

        // 1. Process JSON Input
        if (File.Exists(jsonInputPath))
        {
            string jsonContent = File.ReadAllText(jsonInputPath);
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(jsonContent);
            ApplyCensorship(matches);
            string censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);
            File.WriteAllText(jsonOutputPath, censoredJson);
            Console.WriteLine("Censored JSON file created: " + jsonOutputPath);
        }
        else
        {
            Console.WriteLine("JSON input file not found: " + jsonInputPath);
        }

        // 2. Process CSV Input
        if (File.Exists(csvInputPath))
        {
            var csvLines = File.ReadAllLines(csvInputPath).ToList();
            var headers = csvLines[0].Split(',').ToList();
            var censoredCsv = new List<string> { string.Join(",", headers) };

            for (int i = 1; i < csvLines.Count; i++)
            {
                var fields = csvLines[i].Split(',').ToList();
                var match = new Match
                {
                    MatchId = int.Parse(fields[0]),
                    Team1 = fields[1],
                    Team2 = fields[2],
                    Score = new Dictionary<string, int>
                    {
                        { fields[1], int.Parse(fields[3]) },
                        { fields[2], int.Parse(fields[4]) }
                    },
                    Winner = fields[5],
                    PlayerOfMatch = fields[6]
                };
                ApplyCensorship(new List<Match> { match });

                censoredCsv.Add($"{match.MatchId},{match.Team1},{match.Team2},{match.Score[match.Team1]},{match.Score[match.Team2]},{match.Winner},{match.PlayerOfMatch}");
            }

            File.WriteAllLines(csvOutputPath, censoredCsv);
            Console.WriteLine("Censored CSV file created: " + csvOutputPath);
        }
        else
        {
            Console.WriteLine("CSV input file not found: " + csvInputPath);
        }
    }

    // Apply censorship rules
    static void ApplyCensorship(List<Match> matches)
    {
        foreach (var match in matches)
        {
            match.Team1 = MaskTeamName(match.Team1);
            match.Team2 = MaskTeamName(match.Team2);
            match.Winner = MaskTeamName(match.Winner);
            match.PlayerOfMatch = "REDACTED";

            // Update score dictionary keys
            var newScore = new Dictionary<string, int>();
            foreach (var kvp in match.Score)
            {
                newScore[MaskTeamName(kvp.Key)] = kvp.Value;
            }
            match.Score = newScore;
        }
    }

    // Mask team names
    static string MaskTeamName(string teamName)
    {
        if (string.IsNullOrEmpty(teamName)) return teamName;
        string[] parts = teamName.Split(' ');
        if (parts.Length > 1)
        {
            return parts[0] + " ***";
        }
        return teamName;
    }
}

// Match class to represent IPL match data
class Match
{
    public int MatchId { get; set; }
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public Dictionary<string, int> Score { get; set; }
    public string Winner { get; set; }
    public string PlayerOfMatch { get; set; }
}

*/