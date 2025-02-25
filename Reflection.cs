/*

//1. Get Class Information:
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the fully qualified class name (e.g., 'Namespace.ClassName'):");
        string className = Console.ReadLine();

        // Load the type from the class name
        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found. Please ensure the class name is correct and fully qualified.");
            return;
        }

        Console.WriteLine($"Class: {type.FullName}");

        // Display methods
        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }

        // Display fields
        Console.WriteLine("\nFields:");
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (var field in fields)
        {
            Console.WriteLine(field.Name);
        }

        // Display constructors
        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (var constructor in constructors)
        {
            Console.WriteLine(constructor.ToString());
        }
    }
}


//2. Access Private Field
using System;
using System.Reflection;

// Define the Person class with a private field 'age'
public class Person
{
    private int age;

    // Constructor to initialize the age field
    public Person(int initialAge)
    {
        age = initialAge;
    }

    // Method to display the age
    public void DisplayAge()
    {
        Console.WriteLine($"Age: {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Person class
        Person person = new Person(25);

        // Display the initial age
        Console.WriteLine("Initial age:");
        person.DisplayAge();

        // Get the 'age' field using reflection
        FieldInfo ageField = typeof(Person).GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        if (ageField != null)
        {
            // Modify the private field 'age' using reflection
            ageField.SetValue(person, 30);

            // Retrieve the modified value of the private field 'age'
            int modifiedAge = (int)ageField.GetValue(person);

            Console.WriteLine($"Modified age using reflection: {modifiedAge}");
        }
        else
        {
            Console.WriteLine("Field 'age' not found.");
        }

        // Display the modified age
        Console.WriteLine("Modified age:");
        person.DisplayAge();
    }
}


//3. Invoke Private Method
using System;
using System.Reflection;

// Define the Calculator class with a private method 'Multiply'
public class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Calculator class
        Calculator calculator = new Calculator();

        // Get the 'Multiply' method using reflection
        MethodInfo multiplyMethod = typeof(Calculator).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (multiplyMethod != null)
        {
            // Invoke the private method 'Multiply' using reflection
            int result = (int)multiplyMethod.Invoke(calculator, new object[] { 5, 3 });

            // Display the result
            Console.WriteLine($"Result of Multiply(5, 3) using reflection: {result}");
        }
        else
        {
            Console.WriteLine("Method 'Multiply' not found.");
        }
    }
}


//4. Dynamically Create Objects: 
using System;
using System.Reflection;

// Define the Student class
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Dynamically create an instance of the Student class using reflection
        Type studentType = typeof(Student);

        // Get the constructor of the Student class that takes two parameters (string, int)
        ConstructorInfo constructor = studentType.GetConstructor(new Type[] { typeof(string), typeof(int) });

        if (constructor != null)
        {
            // Create an instance of the Student class using the constructor
            object studentInstance = constructor.Invoke(new object[] { "John Doe", 20 });

            // Display the information of the created student instance
            MethodInfo displayInfoMethod = studentType.GetMethod("DisplayInfo");
            displayInfoMethod.Invoke(studentInstance, null);
        }
        else
        {
            Console.WriteLine("Constructor not found.");
        }
    }
}


//5. Dynamic Method Invocation:
using System;
using System.Reflection;

// Define the MathOperations class with multiple public methods
public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class
        MathOperations mathOperations = new MathOperations();

        // Prompt user input for method name and parameters
        Console.WriteLine("Enter method name (Add, Subtract, Multiply):");
        string methodName = Console.ReadLine();

        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        // Get the method using reflection
        MethodInfo method = typeof(MathOperations).GetMethod(methodName);

        if (method != null)
        {
            // Invoke the method using reflection
            object result = method.Invoke(mathOperations, new object[] { num1, num2 });

            // Display the result
            Console.WriteLine($"Result of {methodName}({num1}, {num2}): {result}");
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}


//6. Retrieve Attributes at Runtime:
using System;
using System.Reflection;

// Define the Author attribute
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Apply the Author attribute to a class
[Author("Yesh kumar")]
public class SampleClass
{
    // Class implementation
}

class Program
{
    static void Main(string[] args)
    {
        // Get the type of the SampleClass
        Type type = typeof(SampleClass);

        // Get the Author attribute using reflection
        AuthorAttribute authorAttribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (authorAttribute != null)
        {
            // Display the attribute value
            Console.WriteLine($"Author of {type.Name}: {authorAttribute.Name}");
        }
        else
        {
            Console.WriteLine("Author attribute not found.");
        }
    }
}


//7. Access and Modify Static Fields: Create a Configuration class with a private static field API_KEY. Use Reflection to modify its value and print it.
using System;
using System.Reflection;

// Define the Configuration class with a private static field 'API_KEY'
public class Configuration
{
    private static string API_KEY = "initial_key";

    // Method to display the current API_KEY value
    public static void DisplayApiKey()
    {
        Console.WriteLine($"API_KEY: {API_KEY}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Display the initial API_KEY value
        Configuration.DisplayApiKey();

        // Get the 'API_KEY' field using reflection
        FieldInfo apiKeyField = typeof(Configuration).GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (apiKeyField != null)
        {
            // Modify the private static field 'API_KEY' using reflection
            apiKeyField.SetValue(null, "new_key");

            // Retrieve the modified value of the private static field 'API_KEY'
            string modifiedApiKey = (string)apiKeyField.GetValue(null);

            Console.WriteLine($"Modified API_KEY using reflection: {modifiedApiKey}");
        }
        else
        {
            Console.WriteLine("Field 'API_KEY' not found.");
        }

        // Display the modified API_KEY value
        Configuration.DisplayApiKey();
    }
}


//Advance level
//1. Create a Custom Object Mapper
using System;
using System.Collections.Generic;
using System.Reflection;

public static class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
    {
        // Create an instance of the specified class
        T obj = (T)Activator.CreateInstance(clazz);

        // Set the field values using reflection
        foreach (var property in properties)
        {
            FieldInfo field = clazz.GetField(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(obj, property.Value);
            }
            else
            {
                PropertyInfo prop = clazz.GetProperty(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (prop != null)
                {
                    prop.SetValue(obj, property.Value);
                }
                else
                {
                    Console.WriteLine($"Field or property '{property.Key}' not found in class '{clazz.Name}'");
                }
            }
        }

        return obj;
    }
}

// Define a sample class
public class Student
{
    public string Name { get; set; }
    private int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary with field values
        var properties = new Dictionary<string, object>
        {
            { "Name", "Ankit" },
            { "Age", 23 }
        };

        // Use the ToObject method to create and populate an instance of the Student class
        Student student = ObjectMapper.ToObject<Student>(typeof(Student), properties);

        // Display the information of the created student instance
        student.DisplayInfo();
    }
}


//2. Generate a JSON Representation
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

// Define a sample class
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    private string Email { get; set; }

    public Student(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
}

public static class JsonConverter
{
    public static string ConvertToJson(object obj)
    {
        Type type = obj.GetType();
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("{");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var field in fields)
        {
            jsonBuilder.AppendFormat("\"{0}\": \"{1}\", ", field.Name, field.GetValue(obj));
        }

        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var prop in properties)
        {
            jsonBuilder.AppendFormat("\"{0}\": \"{1}\", ", prop.Name, prop.GetValue(obj));
        }

        if (jsonBuilder.Length > 1)
        {
            jsonBuilder.Remove(jsonBuilder.Length - 2, 2); // Remove the trailing comma and space
        }

        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Student class
        Student student = new Student("John Doe", 20, "john.doe@example.com");

        // Convert the student object to a JSON-like string
        string jsonString = JsonConverter.ConvertToJson(student);
        Console.WriteLine(jsonString);
    }
}

//3. Custom Logging Proxy Using Reflection
using System;
using System.Reflection;
using System.Reflection.Emit;

// Define the IGreeting interface
public interface IGreeting
{
    void SayHello();
    void SayGoodbye();
}

// Implement the Greeting class
public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    public void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }
}

// Implement the dynamic proxy class
public class LoggingProxy : DispatchProxy
{
    private IGreeting _decorated;

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"Calling method: {targetMethod.Name}");

        var result = targetMethod.Invoke(_decorated, args);

        return result;
    }

    public static T Create<T>(T decorated) where T : class
    {
        object proxy = Create<T, LoggingProxy>();
        ((LoggingProxy)proxy)._decorated = decorated;
        return (T)proxy;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Greeting class
        IGreeting greeting = new Greeting();

        // Create a dynamic proxy for the Greeting instance
        IGreeting proxy = LoggingProxy.Create(greeting);

        // Call methods on the proxy instance
        proxy.SayHello();
        proxy.SayGoodbye();
    }
}


//4. Dependency Injection using Reflection:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class InjectAttribute : Attribute { }
    public class DIContainer
    {
        private readonly Dictionary<Type, Type> types = new();

        public void Register<TInterface, TImplementation>()
            where TImplementation : TInterface
        {
            types[typeof(TInterface)] = typeof(TImplementation);
        }
        public T Resolve<T>() => (T)Resolve(typeof(T));

        private object Resolve(Type type)
        {
            if (!types.ContainsKey(type) && !type.IsInterface)
                return Activator.CreateInstance(type);

            Type implementation = types[type];
            ConstructorInfo constructor = implementation.GetConstructors()
                .FirstOrDefault(c => c.GetCustomAttribute<InjectAttribute>() != null)
                ?? implementation.GetConstructors().First();

            object[] parameters = constructor.GetParameters()
                .Select(p => Resolve(p.ParameterType))
                .ToArray();

            return Activator.CreateInstance(implementation, parameters);
        }
    }

    public interface IService { void Execute(); }

    public class ServiceA : IService
    {
        public void Execute() => Console.WriteLine("ServiceA executed");
    }
    public class Consumer
    {
        private readonly IService _service;

        [Inject]
        public Consumer(IService service) => _service = service;

        public void Run() => _service.Execute();
    }


    //act like main class
    class InjectionDependency
    {
        public void DependencyInject()
        {
            DIContainer container = new();
            container.Register<IService, ServiceA>();

            Consumer consumer = container.Resolve<Consumer>();
            consumer.Run();
        }
    }

}

//5. Method Execution Timing
using System;
using System.Diagnostics;
using System.Reflection;

// Define the TimeExecution attribute
[AttributeUsage(AttributeTargets.Method)]
public class TimeExecutionAttribute : Attribute
{
}

// Utility class to measure execution time of methods
public static class MethodTimer
{
    public static void ExecuteAndTime(object obj)
    {
        Type type = obj.GetType();
        MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        foreach (var method in methods)
        {
            if (method.GetCustomAttributes(typeof(TimeExecutionAttribute), false).Length > 0)
            {
                // Measure execution time
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(obj, null);
                stopwatch.Stop();
                Console.WriteLine($"{method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}

// Sample class with methods to demonstrate the timing
public class MyClass
{
    [TimeExecution]
    public void FastMethod()
    {
        // Simulate some work
        System.Threading.Thread.Sleep(100);
    }

    [TimeExecution]
    public void SlowMethod()
    {
        // Simulate some work
        System.Threading.Thread.Sleep(500);
    }

    public void NonTimedMethod()
    {
        // Simulate some work
        System.Threading.Thread.Sleep(200);
    }
}

// Main method to run the example
class Program
{
    static void Main()
    {
        MyClass myClass = new MyClass();
        MethodTimer.ExecuteAndTime(myClass);
    }
}
*/