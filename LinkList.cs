/*
//1. Singly Linked List: Student Record Management
using System;
// Class to represent a student node in the linked list
public class StudentNode
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public StudentNode Next { get; set; } // Reference to the next node

    public StudentNode(int rollNumber, string name, int age, string grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }

    public override string ToString()
    {
        return $"Roll Number: {RollNumber}, Name: {Name}, Age: {Age}, Grade: {Grade}";
    }
}

// Class to represent the singly linked list
public class StudentLinkedList
{
    private StudentNode head; // Reference to the head node

    public StudentLinkedList()
    {
        head = null;
    }

    // Add a new student record at the beginning
    public void AddAtBeginning(int rollNumber, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    // Add a new student record at the end
    public void AddAtEnd(int rollNumber, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    // Add a new student record at a specific position
    public void AddAtPosition(int rollNumber, string name, int age, string grade, int position)
    {
        if (position == 0)
        {
            AddAtBeginning(rollNumber, name, age, grade);
            return;
        }

        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
        StudentNode current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current == null)
            {
                Console.WriteLine("Position out of bounds.");
                return;
            }

            current = current.Next;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    // Delete a student record by Roll Number
    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            return;
        }

        StudentNode current = head;
        while (current.Next != null && current.Next.RollNumber != rollNumber)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Student with given roll number not found.");
            return;
        }

        current.Next = current.Next.Next;
    }

    // Search for a student record by Roll Number
    public StudentNode SearchByRollNumber(int rollNumber)
    {
        StudentNode current = head;
        while (current != null)
        {
            if (current.RollNumber == rollNumber)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // Display all student records
    public void DisplayAllStudents()
    {
        StudentNode current = head;
        while (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        }
    }

    // Update a student's grade based on their Roll Number
    public void UpdateGrade(int rollNumber, string newGrade)
    {
        StudentNode student = SearchByRollNumber(rollNumber);
        if (student != null)
        {
            student.Grade = newGrade;
        }
        else
        {
            Console.WriteLine("Student with given roll number not found.");
        }
    }
}

// Main class to test the student linked list
class Program
{
    static void Main()
    {
        StudentLinkedList studentList = new StudentLinkedList();

        // Add new students
        studentList.AddAtEnd(1, "Anil", 20, "A");
        studentList.AddAtEnd(2, "Boby", 21, "B");
        studentList.AddAtEnd(3, "Chotu", 22, "C");

        // Display all students
        Console.WriteLine("All Students:");
        studentList.DisplayAllStudents();

        // Search for a student
        Console.WriteLine("\nSearch for student with Roll Number 2:");
        StudentNode student = studentList.SearchByRollNumber(2);
        if (student != null)
        {
            Console.WriteLine(student.ToString());
        }
        else
        {
            Console.WriteLine("Student not found.");
        }

        // Update a student's grade
        Console.WriteLine("\nUpdate Grade for student with Roll Number 2:");
        studentList.UpdateGrade(2, "A");
        studentList.DisplayAllStudents();

        // Delete a student
        Console.WriteLine("\nDelete student with Roll Number 2:");
        studentList.DeleteByRollNumber(2);
        studentList.DisplayAllStudents();
        Console.ReadKey();
    }
}


//2. Doubly Linked List: Movie Management System
using System;
// Class to represent a movie node in the doubly linked list
public class MovieNode
{
    public string MovieTitle { get; set; }
    public string Director { get; set; }
    public int YearOfRelease { get; set; }
    public double Rating { get; set; }
    public MovieNode Next { get; set; } // Reference to the next node
    public MovieNode Prev { get; set; } // Reference to the previous node

    public MovieNode(string movieTitle, string director, int yearOfRelease, double rating)
    {
        MovieTitle = movieTitle;
        Director = director;
        YearOfRelease = yearOfRelease;
        Rating = rating;
        Next = null;
        Prev = null;
    }

    public override string ToString()
    {
        return $"Title: {MovieTitle}, Director: {Director}, Year: {YearOfRelease}, Rating: {Rating}";
    }
}

// Class to represent the doubly linked list
public class MovieLinkedList
{
    private MovieNode head; // Reference to the head node
    private MovieNode tail; // Reference to the tail node

    public MovieLinkedList()
    {
        head = null;
        tail = null;
    }

    // Add a movie record at the beginning
    public void AddAtBeginning(string movieTitle, string director, int yearOfRelease, double rating)
    {
        MovieNode newNode = new MovieNode(movieTitle, director, yearOfRelease, rating);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }

    // Add a movie record at the end
    public void AddAtEnd(string movieTitle, string director, int yearOfRelease, double rating)
    {
        MovieNode newNode = new MovieNode(movieTitle, director, yearOfRelease, rating);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    // Add a movie record at a specific position
    public void AddAtPosition(string movieTitle, string director, int yearOfRelease, double rating, int position)
    {
        if (position == 0)
        {
            AddAtBeginning(movieTitle, director, yearOfRelease, rating);
            return;
        }

        MovieNode newNode = new MovieNode(movieTitle, director, yearOfRelease, rating);
        MovieNode current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current == null)
            {
                Console.WriteLine("Position out of bounds.");
                return;
            }

            current = current.Next;
        }

        newNode.Next = current.Next;
        if (current.Next != null)
        {
            current.Next.Prev = newNode;
        }
        newNode.Prev = current;
        current.Next = newNode;
    }

    // Remove a movie record by Movie Title
    public void RemoveByMovieTitle(string movieTitle)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        MovieNode current = head;
        while (current != null && current.MovieTitle != movieTitle)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Movie with given title not found.");
            return;
        }

        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
        else
        {
            head = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }
        else
        {
            tail = current.Prev;
        }
    }

    // Search for a movie record by Director
    public MovieNode SearchByDirector(string director)
    {
        MovieNode current = head;
        while (current != null)
        {
            if (current.Director == director)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // Search for a movie record by Rating
    public MovieNode SearchByRating(double rating)
    {
        MovieNode current = head;
        while (current != null)
        {
            if (current.Rating == rating)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // Display all movie records in forward order
    public void DisplayAllMoviesForward()
    {
        MovieNode current = head;
        while (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        }
    }

    // Display all movie records in reverse order
    public void DisplayAllMoviesReverse()
    {
        MovieNode current = tail;
        while (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Prev;
        }
    }

    // Update a movie's rating based on the Movie Title
    public void UpdateRating(string movieTitle, double newRating)
    {
        MovieNode movie = head;
        while (movie != null)
        {
            if (movie.MovieTitle == movieTitle)
            {
                movie.Rating = newRating;
                return;
            }
            movie = movie.Next;
        }

        Console.WriteLine("Movie with given title not found.");
    }
}

// Main class to test the movie management system
class Program
{
    static void Main()
    {
        MovieLinkedList movieList = new MovieLinkedList();

        // Add new movies
        movieList.AddAtEnd("Munna Bhai M.B.B.S.", "Rajkumar Hirani", 2003, 8.8);
        movieList.AddAtEnd("M.S. Dhoni: The Untold Story", "Neeraj Pandey", 2016, 9.0);
        movieList.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);

        // Display all movies in forward order
        Console.WriteLine("All Movies (Forward Order):");
        movieList.DisplayAllMoviesForward();

        // Display all movies in reverse order
        Console.WriteLine("\nAll Movies (Reverse Order):");
        movieList.DisplayAllMoviesReverse();

        // Search for a movie by Director
        Console.WriteLine("\nSearch for movie by Director 'Christopher Nolan':");
        MovieNode movie = movieList.SearchByDirector("Christopher Nolan");
        if (movie != null)
        {
            Console.WriteLine(movie.ToString());
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }

        // Update a movie's rating
        Console.WriteLine("\nUpdate Rating for movie 'Munna Bhai M.B.B.S.':");
        movieList.UpdateRating("Munna Bhai M.B.B.S.", 9.0);
        movieList.DisplayAllMoviesForward();

        // Remove a movie by title
        Console.WriteLine("\nRemove movie 'M.S. Dhoni: The Untold Story':");
        movieList.RemoveByMovieTitle("M.S. Dhoni: The Untold Story");
        movieList.DisplayAllMoviesForward();
        Console.ReadKey();
    }
}


//3.  Circular Linked List: Task Scheduler
using System;

// Class to represent a task node in the circular linked list
public class TaskNode
{
    public int TaskID { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public TaskNode Next { get; set; } // Reference to the next node

    public TaskNode(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }

    public override string ToString()
    {
        return $"TaskID: {TaskID}, TaskName: {TaskName}, Priority: {Priority}, DueDate: {DueDate:yyyy-MM-dd}";
    }
}

// Class to represent the circular linked list
public class TaskCircularLinkedList
{
    private TaskNode head; // Reference to the head node
    private TaskNode current; // Reference to the current node

    public TaskCircularLinkedList()
    {
        head = null;
        current = null;
    }

    // Add a task at the beginning
    public void AddAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
        }
        else
        {
            TaskNode tail = head;
            while (tail.Next != head)
            {
                tail = tail.Next;
            }

            newNode.Next = head;
            head = newNode;
            tail.Next = head;
        }

        if (current == null)
        {
            current = head;
        }
    }

    // Add a task at the end
    public void AddAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
        }
        else
        {
            TaskNode tail = head;
            while (tail.Next != head)
            {
                tail = tail.Next;
            }

            tail.Next = newNode;
            newNode.Next = head;
        }

        if (current == null)
        {
            current = head;
        }
    }

    // Add a task at a specific position
    public void AddAtPosition(int taskID, string taskName, int priority, DateTime dueDate, int position)
    {
        if (position == 0)
        {
            AddAtBeginning(taskID, taskName, priority, dueDate);
            return;
        }

        TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
        TaskNode current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current.Next == head)
            {
                Console.WriteLine("Position out of bounds.");
                return;
            }

            current = current.Next;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    // Remove a task by Task ID
    public void RemoveByTaskID(int taskID)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        TaskNode current = head;
        TaskNode prev = null;
        do
        {
            if (current.TaskID == taskID)
            {
                if (prev != null)
                {
                    prev.Next = current.Next;
                    if (current == head)
                    {
                        head = current.Next;
                    }
                }
                else
                {
                    TaskNode tail = head;
                    while (tail.Next != head)
                    {
                        tail = tail.Next;
                    }

                    head = head.Next;
                    tail.Next = head;
                }

                return;
            }

            prev = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine("Task with given ID not found.");
    }

    // View the current task and move to the next task
    public void ViewCurrentTask()
    {
        if (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        }
        else
        {
            Console.WriteLine("No tasks available.");
        }
    }

    // Display all tasks starting from the head node
    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        TaskNode current = head;
        do
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        } while (current != head);
    }

    // Search for a task by Priority
    public TaskNode SearchByPriority(int priority)
    {
        if (head == null)
        {
            return null;
        }

        TaskNode current = head;
        do
        {
            if (current.Priority == priority)
            {
                return current;
            }

            current = current.Next;
        } while (current != head);

        return null;
    }
}

// Main class to test the task scheduler
class Program
{
    static void Main()
    {
        TaskCircularLinkedList taskList = new TaskCircularLinkedList();

        // Add new tasks
        taskList.AddAtEnd(1, "Task 1", 1, DateTime.Now.AddDays(1));
        taskList.AddAtEnd(2, "Task 2", 2, DateTime.Now.AddDays(2));
        taskList.AddAtEnd(3, "Task 3", 3, DateTime.Now.AddDays(3));

        // Display all tasks
        Console.WriteLine("All Tasks:");
        taskList.DisplayAllTasks();

        // View the current task and move to the next task
        Console.WriteLine("\nView Current Task:");
        taskList.ViewCurrentTask();
        taskList.ViewCurrentTask();
        taskList.ViewCurrentTask();

        // Search for a task by Priority
        Console.WriteLine("\nSearch for task with Priority 2:");
        TaskNode task = taskList.SearchByPriority(2);
        if (task != null)
        {
            Console.WriteLine(task.ToString());
        }
        else
        {
            Console.WriteLine("Task not found.");
        }

        // Remove a task by Task ID
        Console.WriteLine("\nRemove Task with Task ID 2:");
        taskList.RemoveByTaskID(2);
        taskList.DisplayAllTasks();
        Console.ReadKey();
    }
}


//4. Singly Linked List: Inventory Management System
using System;
// Class to represent an item node in the singly linked list
public class ItemNode
{
    public string ItemName { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public ItemNode Next { get; set; } // Reference to the next node

    public ItemNode(string itemName, int itemID, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }

    public override string ToString()
    {
        return $"Item Name: {ItemName}, Item ID: {ItemID}, Quantity: {Quantity}, Price: {Price:C}";
    }
}

// Class to represent the singly linked list
public class InventoryLinkedList
{
    private ItemNode head; // Reference to the head node

    public InventoryLinkedList()
    {
        head = null;
    }

    // Add an item at the beginning
    public void AddAtBeginning(string itemName, int itemID, int quantity, double price)
    {
        ItemNode newNode = new ItemNode(itemName, itemID, quantity, price);
        newNode.Next = head;
        head = newNode;
    }

    // Add an item at the end
    public void AddAtEnd(string itemName, int itemID, int quantity, double price)
    {
        ItemNode newNode = new ItemNode(itemName, itemID, quantity, price);
        if (head == null)
        {
            head = newNode;
            return;
        }

        ItemNode current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    // Add an item at a specific position
    public void AddAtPosition(string itemName, int itemID, int quantity, double price, int position)
    {
        if (position == 0)
        {
            AddAtBeginning(itemName, itemID, quantity, price);
            return;
        }

        ItemNode newNode = new ItemNode(itemName, itemID, quantity, price);
        ItemNode current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current == null)
            {
                Console.WriteLine("Position out of bounds.");
                return;
            }

            current = current.Next;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    // Remove an item based on Item ID
    public void RemoveByItemID(int itemID)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.ItemID == itemID)
        {
            head = head.Next;
            return;
        }

        ItemNode current = head;
        while (current.Next != null && current.Next.ItemID != itemID)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Item with given ID not found.");
            return;
        }

        current.Next = current.Next.Next;
    }

    // Update the quantity of an item by Item ID
    public void UpdateQuantity(int itemID, int newQuantity)
    {
        ItemNode item = head;
        while (item != null)
        {
            if (item.ItemID == itemID)
            {
                item.Quantity = newQuantity;
                return;
            }
            item = item.Next;
        }

        Console.WriteLine("Item with given ID not found.");
    }

    // Search for an item based on Item ID
    public ItemNode SearchByItemID(int itemID)
    {
        ItemNode current = head;
        while (current != null)
        {
            if (current.ItemID == itemID)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // Search for an item based on Item Name
    public ItemNode SearchByItemName(string itemName)
    {
        ItemNode current = head;
        while (current != null)
        {
            if (current.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // Calculate and display the total value of inventory
    public void DisplayTotalValue()
    {
        double totalValue = 0;
        ItemNode current = head;
        while (current != null)
        {
            totalValue += current.Price * current.Quantity;
            current = current.Next;
        }

        Console.WriteLine($"Total value of inventory: {totalValue:C}");
    }

    // Display all items
    public void DisplayAllItems()
    {
        ItemNode current = head;
        while (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        }
    }

    // Sort the inventory based on Item Name in ascending order
    public void SortByNameAscending()
    {
        if (head == null)
        {
            return;
        }

        for (ItemNode i = head; i.Next != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (string.Compare(i.ItemName, j.ItemName, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    Swap(i, j);
                }
            }
        }
    }

    // Sort the inventory based on Item Name in descending order
    public void SortByNameDescending()
    {
        if (head == null)
        {
            return;
        }

        for (ItemNode i = head; i.Next != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (string.Compare(i.ItemName, j.ItemName, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    Swap(i, j);
                }
            }
        }
    }

    // Sort the inventory based on Price in ascending order
    public void SortByPriceAscending()
    {
        if (head == null)
        {
            return;
        }

        for (ItemNode i = head; i.Next != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (i.Price > j.Price)
                {
                    Swap(i, j);
                }
            }
        }
    }

    // Sort the inventory based on Price in descending order
    public void SortByPriceDescending()
    {
        if (head == null)
        {
            return;
        }

        for (ItemNode i = head; i.Next != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (i.Price < j.Price)
                {
                    Swap(i, j);
                }
            }
        }
    }

    // Helper method to swap data between two nodes
    private void Swap(ItemNode a, ItemNode b)
    {
        string tempName = a.ItemName;
        int tempID = a.ItemID;
        int tempQuantity = a.Quantity;
        double tempPrice = a.Price;

        a.ItemName = b.ItemName;
        a.ItemID = b.ItemID;
        a.Quantity = b.Quantity;
        a.Price = b.Price;

        b.ItemName = tempName;
        b.ItemID = tempID;
        b.Quantity = tempQuantity;
        b.Price = tempPrice;
    }
}

// Main class to test the inventory management system
class Program
{
    static void Main()
    {
        InventoryLinkedList inventory = new InventoryLinkedList();

        // Add new items
        inventory.AddAtEnd("Laptop", 1, 4, 1000);
        inventory.AddAtEnd("Mouse", 2, 08, 50);
        inventory.AddAtEnd("Keyboard", 3, 20, 95);

        // Display all items
        Console.WriteLine("All Items:");
        inventory.DisplayAllItems();

        // Search for an item by Item ID
        Console.WriteLine("\nSearch for item with Item ID 2:");
        ItemNode item = inventory.SearchByItemID(2);
        if (item != null)
        {
            Console.WriteLine(item.ToString());
        }
        else
        {
            Console.WriteLine("Item not found.");
        }

        // Update the quantity of an item
        Console.WriteLine("\nUpdate Quantity for item with Item ID 2:");
        inventory.UpdateQuantity(2, 20);
        inventory.DisplayAllItems();

        // Calculate and display the total value of inventory
        Console.WriteLine("\nTotal Value of Inventory:");
        inventory.DisplayTotalValue();

        // Sort the inventory by Item Name in ascending order
        Console.WriteLine("\nSort Inventory by Item Name (Ascending):");
        inventory.SortByNameAscending();
        inventory.DisplayAllItems();

        // Sort the inventory by Price in descending order
        Console.WriteLine("\nSort Inventory by Price (Descending):");
        inventory.SortByPriceDescending();
        inventory.DisplayAllItems();

        // Remove an item by Item ID
        Console.WriteLine("\nRemove item with Item ID 1:");
        inventory.RemoveByItemID(1);
        inventory.DisplayAllItems();
        Console.ReadKey();
    }
}


//5. Doubly Linked List: Library Management System
using System;

// Class to represent a book node in the doubly linked list
public class BookNode
{
    public string BookTitle { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int BookID { get; set; }
    public bool IsAvailable { get; set; }
    public BookNode Next { get; set; } // Reference to the next node
    public BookNode Prev { get; set; } // Reference to the previous node

    public BookNode(string bookTitle, string author, string genre, int bookID, bool isAvailable)
    {
        BookTitle = bookTitle;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }

    public override string ToString()
    {
        return $"Title: {BookTitle}, Author: {Author}, Genre: {Genre}, Book ID: {BookID}, Available: {IsAvailable}";
    }
}

// Class to represent the doubly linked list
public class LibraryLinkedList
{
    private BookNode head; // Reference to the head node
    private BookNode tail; // Reference to the tail node

    public LibraryLinkedList()
    {
        head = null;
        tail = null;
    }

    // Add a new book at the beginning
    public void AddAtBeginning(string bookTitle, string author, string genre, int bookID, bool isAvailable)
    {
        BookNode newNode = new BookNode(bookTitle, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }

    // Add a new book at the end
    public void AddAtEnd(string bookTitle, string author, string genre, int bookID, bool isAvailable)
    {
        BookNode newNode = new BookNode(bookTitle, author, genre, bookID, isAvailable);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    // Add a new book at a specific position
    public void AddAtPosition(string bookTitle, string author, string genre, int bookID, bool isAvailable, int position)
    {
        if (position == 0)
        {
            AddAtBeginning(bookTitle, author, genre, bookID, isAvailable);
            return;
        }

        BookNode newNode = new BookNode(bookTitle, author, genre, bookID, isAvailable);
        BookNode current = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (current == null)
            {
                Console.WriteLine("Position out of bounds.");
                return;
            }

            current = current.Next;
        }

        newNode.Next = current.Next;
        if (current.Next != null)
        {
            current.Next.Prev = newNode;
        }
        newNode.Prev = current;
        current.Next = newNode;
    }

    // Remove a book by Book ID
    public void RemoveByBookID(int bookID)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        BookNode current = head;
        while (current != null && current.BookID != bookID)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Book with given ID not found.");
            return;
        }

        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
        else
        {
            head = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }
        else
        {
            tail = current.Prev;
        }
    }

    // Search for a book by Book Title
    public BookNode SearchByBookTitle(string bookTitle)
    {
        BookNode current = head;
        while (current != null)
        {
            if (current.BookTitle.Equals(bookTitle, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // Search for a book by Author
    public BookNode SearchByAuthor(string author)
    {
        BookNode current = head;
        while (current != null)
        {
            if (current.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // Update a book's Availability Status
    public void UpdateAvailabilityStatus(int bookID, bool isAvailable)
    {
        BookNode book = head;
        while (book != null)
        {
            if (book.BookID == bookID)
            {
                book.IsAvailable = isAvailable;
                return;
            }
            book = book.Next;
        }

        Console.WriteLine("Book with given ID not found.");
    }

    // Display all books in forward order
    public void DisplayAllBooksForward()
    {
        BookNode current = head;
        while (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        }
    }

    // Display all books in reverse order
    public void DisplayAllBooksReverse()
    {
        BookNode current = tail;
        while (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Prev;
        }
    }

    // Count the total number of books in the library
    public int CountTotalBooks()
    {
        int count = 0;
        BookNode current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}

// Main class to test the library management system
class Program
{
    static void Main()
    {
        LibraryLinkedList library = new LibraryLinkedList();

        // Add new books
        library.AddAtEnd("Ek Samandar, Mere Andar", "Sanjeev Joshi", "Fiction", 1, true);
        library.AddAtEnd("To Kill a Mockingbird", "Harper Lee", "Fiction", 2, false);
        library.AddAtEnd("Maha Kavithai", "Vairamuthu", "Dystopian", 3, true);

        // Display all books in forward order
        Console.WriteLine("All Books (Forward Order):");
        library.DisplayAllBooksForward();

        // Display all books in reverse order
        Console.WriteLine("\nAll Books (Reverse Order):");
        library.DisplayAllBooksReverse();

        // Search for a book by Book Title
        Console.WriteLine("\nSearch for book with Title 'Maha Kavithai':");
        BookNode book = library.SearchByBookTitle("Maha Kavithai");
        if (book != null)
        {
            Console.WriteLine(book.ToString());
        }
        else
        {
            Console.WriteLine("Book not found.");
        }

        // Update a book's Availability Status
        Console.WriteLine("\nUpdate Availability Status for book with Book ID 2:");
        library.UpdateAvailabilityStatus(2, true);
        library.DisplayAllBooksForward();

        // Remove a book by Book ID
        Console.WriteLine("\nRemove book with Book ID 1:");
        library.RemoveByBookID(1);
        library.DisplayAllBooksForward();

        // Count the total number of books in the library
        Console.WriteLine("\nTotal number of books in the library:");
        int totalBooks = library.CountTotalBooks();
        Console.WriteLine(totalBooks);
        Console.ReadLine();
    }
}



//6. Circular Linked List: Round Robin Scheduling Algorithm
using System;

// Define a class for the Process node
class ProcessNode
{
    public int ProcessID { get; set; }
    public int BurstTime { get; set; }
    public int Priority { get; set; }
    public ProcessNode Next { get; set; }

    public ProcessNode(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

// Define a class for the Circular Linked List
class CircularLinkedList
{
    private ProcessNode head;
    private ProcessNode tail;

    public CircularLinkedList()
    {
        head = null;
        tail = null;
    }

    // Add a new process at the end of the circular list
    public void AddProcess(int processID, int burstTime, int priority)
    {
        ProcessNode newNode = new ProcessNode(processID, burstTime, priority);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            tail.Next = head; // Make it circular
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head; // Make it circular
        }
        Console.WriteLine($"Process {processID} added to the queue.");
    }

    // Remove a process by Process ID after its execution
    public void RemoveProcess(int processID)
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        ProcessNode current = head;
        ProcessNode previous = null;

        do
        {
            if (current.ProcessID == processID)
            {
                if (current == head && current == tail) // Only one node
                {
                    head = null;
                    tail = null;
                }
                else if (current == head) // Remove head
                {
                    head = head.Next;
                    tail.Next = head;
                }
                else if (current == tail) // Remove tail
                {
                    tail = previous;
                    tail.Next = head;
                }
                else // Remove middle node
                {
                    previous.Next = current.Next;
                }
                Console.WriteLine($"Process {processID} removed from the queue.");
                return;
            }
            previous = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine($"Process {processID} not found in the queue.");
    }

    // Simulate the scheduling of processes in a round-robin manner
    public void RoundRobinScheduling(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        int totalWaitingTime = 0;
        int totalTurnAroundTime = 0;
        int totalProcesses = 0;

        ProcessNode current = head;
        do
        {
            totalProcesses++;
            current = current.Next;
        } while (current != head);

        while (head != null)
        {
            current = head;
            do
            {
                if (current.BurstTime > 0)
                {
                    Console.WriteLine($"Executing Process {current.ProcessID} with Burst Time {current.BurstTime}");
                    int executionTime = Math.Min(timeQuantum, current.BurstTime);
                    current.BurstTime -= executionTime;

                    // Calculate waiting and turn-around time
                    totalWaitingTime += executionTime * (totalProcesses - 1);
                    totalTurnAroundTime += executionTime * totalProcesses;

                    if (current.BurstTime == 0)
                    {
                        RemoveProcess(current.ProcessID);
                        totalProcesses--;
                    }
                }
                current = current.Next;
            } while (current != head);

            DisplayProcesses();
        }

        // Calculate and display average waiting and turn-around time
        double averageWaitingTime = (double)totalWaitingTime / totalProcesses;
        double averageTurnAroundTime = (double)totalTurnAroundTime / totalProcesses;
        Console.WriteLine($"Average Waiting Time: {averageWaitingTime}");
        Console.WriteLine($"Average Turn-Around Time: {averageTurnAroundTime}");
    }

    // Display the list of processes in the circular queue
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        ProcessNode current = head;
        Console.WriteLine("Processes in the queue:");
        do
        {
            Console.WriteLine($"Process ID: {current.ProcessID}, Burst Time: {current.BurstTime}, Priority: {current.Priority}");
            current = current.Next;
        } while (current != head);
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList scheduler = new CircularLinkedList();

        // Add processes
        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 3);

        // Display processes
        scheduler.DisplayProcesses();

        // Simulate Round Robin Scheduling with time quantum = 3
        scheduler.RoundRobinScheduling(3);
        Console.ReadKey();
    }
}


//7. Singly Linked List: Social Media Friend Connections
using System;
using System.Collections.Generic;

// Define a class for the User node
class UserNode
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> FriendIDs { get; set; }
    public UserNode Next { get; set; }

    public UserNode(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

// Define a class for the Singly Linked List
class SocialMediaSystem
{
    private UserNode head;

    public SocialMediaSystem()
    {
        head = null;
    }

    // Add a new user to the system
    public void AddUser(int userID, string name, int age)
    {
        UserNode newNode = new UserNode(userID, name, age);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            UserNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Console.WriteLine($"User {name} (ID: {userID}) added to the system.");
    }

    // Add a friend connection between two users
    public void AddFriendConnection(int userID1, int userID2)
    {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.FriendIDs.Contains(userID2))
        {
            user1.FriendIDs.Add(userID2);
            user2.FriendIDs.Add(userID1);
            Console.WriteLine($"Friend connection added between User {user1.Name} (ID: {userID1}) and User {user2.Name} (ID: {userID2}).");
        }
        else
        {
            Console.WriteLine("Friend connection already exists.");
        }
    }

    // Remove a friend connection between two users
    public void RemoveFriendConnection(int userID1, int userID2)
    {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (user1.FriendIDs.Contains(userID2))
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
            Console.WriteLine($"Friend connection removed between User {user1.Name} (ID: {userID1}) and User {user2.Name} (ID: {userID2}).");
        }
        else
        {
            Console.WriteLine("Friend connection does not exist.");
        }
    }

    // Find mutual friends between two users
    public void FindMutualFriends(int userID1, int userID2)
    {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        List<int> mutualFriends = new List<int>();
        foreach (int friendID in user1.FriendIDs)
        {
            if (user2.FriendIDs.Contains(friendID))
            {
                mutualFriends.Add(friendID);
            }
        }

        if (mutualFriends.Count > 0)
        {
            Console.WriteLine($"Mutual friends between User {user1.Name} (ID: {userID1}) and User {user2.Name} (ID: {userID2}):");
            foreach (int friendID in mutualFriends)
            {
                UserNode friend = FindUserByID(friendID);
                Console.WriteLine($"- {friend.Name} (ID: {friendID})");
            }
        }
        else
        {
            Console.WriteLine("No mutual friends found.");
        }
    }

    // Display all friends of a specific user
    public void DisplayFriends(int userID)
    {
        UserNode user = FindUserByID(userID);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        if (user.FriendIDs.Count > 0)
        {
            Console.WriteLine($"Friends of User {user.Name} (ID: {userID}):");
            foreach (int friendID in user.FriendIDs)
            {
                UserNode friend = FindUserByID(friendID);
                Console.WriteLine($"- {friend.Name} (ID: {friendID})");
            }
        }
        else
        {
            Console.WriteLine("User has no friends.");
        }
    }

    // Search for a user by Name or User ID
    public void SearchUser(string name = null, int? userID = null)
    {
        if (name == null && userID == null)
        {
            Console.WriteLine("Please provide a name or user ID to search.");
            return;
        }

        UserNode current = head;
        bool found = false;
        while (current != null)
        {
            if ((name != null && current.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ||
                (userID != null && current.UserID == userID))
            {
                Console.WriteLine($"User found: ID: {current.UserID}, Name: {current.Name}, Age: {current.Age}");
                found = true;
            }
            current = current.Next;
        }

        if (!found)
        {
            Console.WriteLine("User not found.");
        }
    }

    // Count the number of friends for each user
    public void CountFriends()
    {
        UserNode current = head;
        while (current != null)
        {
            Console.WriteLine($"User {current.Name} (ID: {current.UserID}) has {current.FriendIDs.Count} friends.");
            current = current.Next;
        }
    }

    // Helper method to find a user by User ID
    private UserNode FindUserByID(int userID)
    {
        UserNode current = head;
        while (current != null)
        {
            if (current.UserID == userID)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        SocialMediaSystem system = new SocialMediaSystem();

        // Add users
        system.AddUser(1, "Anil", 25);
        system.AddUser(2, "Boby", 30);
        system.AddUser(3, "Chotu", 22);
        system.AddUser(4, "Dav", 28);

        // Add friend connections
        system.AddFriendConnection(1, 2);
        system.AddFriendConnection(1, 3);
        system.AddFriendConnection(2, 4);
        system.AddFriendConnection(3, 4);

        // Display friends of a user
        system.DisplayFriends(1);

        // Find mutual friends
        system.FindMutualFriends(1, 4);

        // Remove a friend connection
        system.RemoveFriendConnection(1, 3);

        // Search for a user by name or ID
        system.SearchUser(name: "Boby");
        system.SearchUser(userID: 3);

        // Count the number of friends for each user
        system.CountFriends();
        Console.ReadKey();
    }
}


//8. Doubly Linked List: Undo/Redo Functionality for Text Editor
using System;

// Class to represent a text state node in the doubly linked list
public class TextStateNode
{
    public string Content { get; set; }
    public TextStateNode Next { get; set; } // Reference to the next node
    public TextStateNode Prev { get; set; } // Reference to the previous node

    public TextStateNode(string content)
    {
        Content = content;
        Next = null;
        Prev = null;
    }

    public override string ToString()
    {
        return Content;
    }
}

// Class to represent the doubly linked list
public class TextStateLinkedList
{
    private TextStateNode head; // Reference to the head node
    private TextStateNode tail; // Reference to the tail node
    private TextStateNode current; // Reference to the current node
    private int maxSize; // Maximum size of the undo/redo history
    private int size; // Current size of the list

    public TextStateLinkedList(int maxSize)
    {
        head = null;
        tail = null;
        current = null;
        this.maxSize = maxSize;
        size = 0;
    }

    // Add a new text state at the end of the list
    public void AddTextState(string content)
    {
        TextStateNode newNode = new TextStateNode(content);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
            current = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
            current = newNode;
        }

        size++;
        if (size > maxSize)
        {
            RemoveFirst();
        }
    }

    // Remove the first text state node (oldest state)
    private void RemoveFirst()
    {
        if (head == null)
        {
            return;
        }

        head = head.Next;
        if (head != null)
        {
            head.Prev = null;
        }

        size--;
    }

    // Implement the undo functionality (revert to the previous state)
    public void Undo()
    {
        if (current == null || current.Prev == null)
        {
            Console.WriteLine("No undo available.");
            return;
        }

        current = current.Prev;
    }

    // Implement the redo functionality (revert back to the next state after undo)
    public void Redo()
    {
        if (current == null || current.Next == null)
        {
            Console.WriteLine("No redo available.");
            return;
        }

        current = current.Next;
    }

    // Display the current state of the text
    public void DisplayCurrentState()
    {
        if (current == null)
        {
            Console.WriteLine("No current state available.");
            return;
        }

        Console.WriteLine("Current State: " + current.Content);
    }
}

// Main class to test the undo/redo functionality for the text editor
class Program
{
    static void Main()
    {
        TextStateLinkedList textEditor = new TextStateLinkedList(10);

        // Simulate typing or performing actions
        textEditor.AddTextState("Initial state.");
        textEditor.AddTextState("Typed 'Hello'.");
        textEditor.AddTextState("Typed 'World!'.");
        textEditor.AddTextState("Deleted 'World!'.");
        textEditor.AddTextState("Typed 'C#'.");

        // Display the current state
        textEditor.DisplayCurrentState();

        // Undo actions
        Console.WriteLine("\nUndoing...");
        textEditor.Undo();
        textEditor.DisplayCurrentState();
        textEditor.Undo();
        textEditor.DisplayCurrentState();

        // Redo actions
        Console.WriteLine("\nRedoing...");
        textEditor.Redo();
        textEditor.DisplayCurrentState();
        textEditor.Redo();
        textEditor.DisplayCurrentState();
        Console.ReadKey();
    }
}


//9. Circular Linked List: Online Ticket Reservation System
using System;

// Class to represent a ticket node in the circular linked list
public class TicketNode
{
    public int TicketID { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public string SeatNumber { get; set; }
    public DateTime BookingTime { get; set; }
    public TicketNode Next { get; set; } // Reference to the next node

    public TicketNode(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
        Next = null;
    }

    public override string ToString()
    {
        return $"Ticket ID: {TicketID}, Customer: {CustomerName}, Movie: {MovieName}, Seat: {SeatNumber}, Time: {BookingTime}";
    }
}

// Class to represent the circular linked list
public class TicketCircularLinkedList
{
    private TicketNode head; // Reference to the head node

    public TicketCircularLinkedList()
    {
        head = null;
    }

    // Add a new ticket reservation at the end of the circular list
    public void AddAtEnd(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
    {
        TicketNode newNode = new TicketNode(ticketID, customerName, movieName, seatNumber, bookingTime);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
        }
        else
        {
            TicketNode tail = head;
            while (tail.Next != head)
            {
                tail = tail.Next;
            }

            tail.Next = newNode;
            newNode.Next = head;
        }
    }

    // Remove a ticket by Ticket ID
    public void RemoveByTicketID(int ticketID)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        TicketNode current = head;
        TicketNode prev = null;
        do
        {
            if (current.TicketID == ticketID)
            {
                if (prev != null)
                {
                    prev.Next = current.Next;
                    if (current == head)
                    {
                        head = current.Next;
                    }
                }
                else
                {
                    TicketNode tail = head;
                    while (tail.Next != head)
                    {
                        tail = tail.Next;
                    }

                    head = head.Next;
                    tail.Next = head;
                }

                return;
            }

            prev = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine("Ticket with given ID not found.");
    }

    // Display the current tickets in the list
    public void DisplayAllTickets()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        TicketNode current = head;
        do
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        } while (current != head);
    }

    // Search for a ticket by Customer Name or Movie Name
    public TicketNode SearchByCustomerOrMovie(string searchQuery)
    {
        if (head == null)
        {
            return null;
        }

        TicketNode current = head;
        do
        {
            if (current.CustomerName.Equals(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                current.MovieName.Equals(searchQuery, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }

            current = current.Next;
        } while (current != head);

        return null;
    }

    // Calculate the total number of booked tickets
    public int CountTotalTickets()
    {
        if (head == null)
        {
            return 0;
        }

        int count = 0;
        TicketNode current = head;
        do
        {
            count++;
            current = current.Next;
        } while (current != head);

        return count;
    }
}

// Main class to test the ticket reservation system
class Program
{
    static void Main()
    {
        TicketCircularLinkedList ticketList = new TicketCircularLinkedList();

        // Add new tickets
        ticketList.AddAtEnd(1, "Annu", "Inception", "A1", DateTime.Now);
        ticketList.AddAtEnd(2, "Boby", "The Dark Knight", "B2", DateTime.Now);
        ticketList.AddAtEnd(3, "Tushar", "Interstellar", "C3", DateTime.Now);

        // Display all tickets
        Console.WriteLine("All Tickets:");
        ticketList.DisplayAllTickets();

        // Search for a ticket by Customer Name or Movie Name
        Console.WriteLine("\nSearch for ticket with Customer Name 'Bob':");
        TicketNode ticket = ticketList.SearchByCustomerOrMovie("Boby");
        if (ticket != null)
        {
            Console.WriteLine(ticket.ToString());
        }
        else
        {
            Console.WriteLine("Ticket not found.");
        }

        // Calculate the total number of booked tickets
        Console.WriteLine("\nTotal number of booked tickets:");
        int totalTickets = ticketList.CountTotalTickets();
        Console.WriteLine(totalTickets);

        // Remove a ticket by Ticket ID
        Console.WriteLine("\nRemove ticket with Ticket ID 2:");
        ticketList.RemoveByTicketID(2);
        ticketList.DisplayAllTickets();
        Console.ReadKey();
    }
}
*/