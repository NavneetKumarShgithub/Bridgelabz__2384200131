/*//1.
using System;
class EmployeeBonusCalculator
{
    static void Main(string[] args)
    {
        // arrays to save salary, years of service, new salary, and bonus amount
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] newSalaries = new double[10];
        double[] bonuses = new double[10];

        // Variables to save the total bonus, total old salary, and total new salary
        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;

        // Loop to take input from the user
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter the salary of employee "+(i + 1)+" :");
            salaries[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the years of service of employee "+(i + 1)+" :");
            yearsOfService[i] = int.Parse(Console.ReadLine());

            // Validate input
            if (salaries[i] <= 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter valid salary and years of service.");
                i--; // Decrement the index to re-enter the values
                continue;
            }
        }

        // Loop to calculate the bonus and new salary for each employee
        for (int i = 0; i < 10; i++)
        {
            if (yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05;
            }
            else
            {
                bonuses[i] = salaries[i] * 0.02;
            }

            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        //  total bonus , total old salary, and total new salary
        Console.WriteLine("Total bonus payout: "+totalBonus);
        Console.WriteLine("Total old salary: "+totalOldSalary);
        Console.WriteLine("Total new salary: "+totalNewSalary);
    }
}

//2. A program to find the youngest friends
using System;

class FriendsComparison
{
    static void Main(string[] args)
    {
        // Arrays to store ages and heights of the friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // user input for age and height for the 3 friends
        Console.Write("Enter the age of Amar:");
        ages[0] = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of Amar (in cm):");
        heights[0] = double.Parse(Console.ReadLine());

        Console.Write("Enter the age of Akbar:");
        ages[1] = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of Akbar (in cm):");
        heights[1] = double.Parse(Console.ReadLine());

        Console.Write("Enter the age of Anthony:");
        ages[2] = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of Anthony (in cm):");
        heights[2] = double.Parse(Console.ReadLine());

        // Find the youngest friend
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }

        // Find the tallest friend
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        // Display the youngest and tallest friends
        string[] names = { "Amar", "Akbar", "Anthony" };
        Console.WriteLine("The youngest friend is "+names[youngestIndex]);
        Console.WriteLine("The tallest friend is "+names[tallestIndex]);
    }
}

//3. The digits of the number in an array and find the largest and second largest element of the array.
using System;

class LargestDigitsFinder
{
    static void Main(string[] args)
    {
        // a number variable and take user input
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // array to store the digits
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        //  loop to iterate until the number is not equal to 0
        while (number != 0)
        {
            // Remove the last digit from the number and add it to the array
            digits[index] = number % 10;
            number /= 10;
            index++;

            // If the index count equals maxDigit, break out of the loop
            if (index == maxDigit)
            {
                break;
            }
        }

        // variables to store the largest and second largest digits
        int largest = 0;
        int secondLargest = 0;

        // the array to find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display the largest and second largest digits
        Console.WriteLine("The largest digit is "+largest);
        Console.WriteLine("The second largest digit is "+secondLargest);
    }
}


//4. The largest and second-largest number
using System;
class LargestDigitsFinder
{
    static void Main(string[] args)
    {
        // a number variable and take user input
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // an array to store the digits
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // loop to iterate until the number is not equal to 0
        while (number != 0)
        {
            // Remove the last digit from the number and add it to the array
            digits[index] = number % 10;
            number /= 10;
            index++;

            // index count equals maxDigit, increase the size of the array
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }
        }

        // variables to store the largest and second largest digits
        int largest = 0;
        int secondLargest = 0;

        // array to find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        //largest and second largest digits
        Console.WriteLine("The largest digit is "+largest);
        Console.WriteLine("The second largest digit is "+secondLargest);
    }
}

//5. A number as input and reverse the number
using System;
class ReverseNumber
{
    static void Main(string[] args)
    {
        // Take user input for a number
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Find the count of digits in the number
        int count = number.ToString().Length;

        // Find the digits in the number and save them in an array
        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        // Create an array to store the elements of the digits array in reverse order
        int[] reversedDigits = new int[count];
        for (int i = 0; i < count; i++)
        {
            reversedDigits[i] = digits[count - 1 - i];
        }

        // the elements of the array in reverse order
        Console.WriteLine("The digits in reverse order are:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(reversedDigits[i]);
        }
    }
}

//6. find the Body Mass Index (BMI) of all the persons in the team.
using System;
class BMIProgram
{
    static void Main()
    {
        // Step a: Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Step b: Create arrays to store weight, height, BMI, and status
        float[] weights = new float[numberOfPersons];
        float[] heights = new float[numberOfPersons];
        float[] bmis = new float[numberOfPersons];
        string[] statuses = new string[numberOfPersons];

        // Step c: Take input for the weight and height of the persons
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.Write("Enter weight (kg) of person "+(i + 1)+": ");
            weights[i] = float.Parse(Console.ReadLine());

            Console.Write("Enter height (m) of person "+(i + 1)+": ");
            heights[i] = float.Parse(Console.ReadLine());
        }

        // Step d: Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            // Calculate BMI: BMI = weight (kg) / (height (m) * height (m))
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            // Determine status based on BMI
            if (bmis[i] <= 18.4)
                statuses[i] = "Underweight";
            else if (bmis[i] <= 24.9)
                statuses[i] = "Normal";
            else if (bmis[i] <= 39.9)
                statuses[i] = "Overweight";
            else
                statuses[i] = "Obese";
        }

        // Step e: Display the height, weight, BMI, and weight status of each person
        Console.WriteLine("\nPerson Details:");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        Console.WriteLine("----------------------------------------------------");

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine((i + 1)+"      "+heights[i]+"      "+weights[i]+"       "+bmis[i]+"        "+statuses[i]);
        }
    }
}




//7. Multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        // input for the number of persons
        Console.WriteLine("Enter the number of persons:");
        int number = int.Parse(Console.ReadLine());

        // multi-dimensional array to store weight, height, and BMI
        double[,] personData = new double[number, 3];
        string[] weightStatus = new string[number];

        // Take input for weight and height of the persons
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter the weight of person "+(i + 1)+" (in kg):");
            personData[i, 0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of person "+(i + 1)+" (in meters):");
            personData[i, 1] = double.Parse(Console.ReadLine());

            // Validate input for negative values
            if (personData[i, 0] <= 0 || personData[i, 1] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--; // Decrement the index to re-enter the values
                continue;
            }

            // Calculate BMI
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

            // Determine weight status
            if (personData[i, 2] < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i, 2] >= 18.5 && personData[i, 2] < 24.9)
            {
                weightStatus[i] = "Normal weight";
            }
            else if (personData[i, 2] >= 25 && personData[i, 2] < 29.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        // Display the height, weight, BMI, and status of each person
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Person "+(i + 1));
            Console.WriteLine("Weight: "+personData[i, 0]+" kg");
            Console.WriteLine("Height: "+personData[i, 1]+" meters");
            Console.WriteLine("BMI: "+personData[i, 2]);
            Console.WriteLine("Weight Status: "+weightStatus[i]);
            Console.WriteLine();
        }
    }
}

//8.the percentage and then calculate the grade as per the following guidelines
using System;

class QuickHireMe
{
    static void Main()
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Arrays to store marks, percentages, and grades of the students
        int[] physicsMarks = new int[numberOfStudents];
        int[] chemistryMarks = new int[numberOfStudents];
        int[] mathsMarks = new int[numberOfStudents];
        double[] percentages = new double[numberOfStudents];
        char[] grades = new char[numberOfStudents];

        // Take input for marks of students in physics, chemistry, and maths
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("\nEnter marks for student "+(i + 1));

            physicsMarks[i] = GetValidMarks("Physics");
            chemistryMarks[i] = GetValidMarks("Chemistry");
            mathsMarks[i] = GetValidMarks("Maths");

            // Calculate the percentage
            percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 3.0;

            // Calculate the grade based on the percentage
            grades[i] = GetGrade(percentages[i]);
        }

        // Display the marks, percentages, and grades of each student
        Console.WriteLine("\nMarks, Percentages, and Grades of Students:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("Student "+(i + 1)+": Physics: "+physicsMarks[i]+", Chemistry: "+chemistryMarks[i]+", Maths: "+mathsMarks[i]+", Percentage: "+percentages[i]+", Grade: "+grades[i]);
        }
    }

    // Function to get valid marks input
    static int GetValidMarks(string subject)
    {
        int marks;
        while (true)
        {
            Console.Write("Enter marks for "+subject+" (0-100): ");
            marks = int.Parse(Console.ReadLine());

            // Ensure marks are between 0 and 100
            if (marks >= 0 && marks <= 100)
                break;
            else
                Console.WriteLine("Please enter valid marks between 0 and 100.");
        }
        return marks;
    }

    // Function to determine the grade based on percentage
    static char GetGrade(double percentage)
    {
        if (percentage >= 80) return 'A';
        else if (percentage >= 70) return 'B';
        else if (percentage >= 60) return 'C';
        else if (percentage >= 50) return 'D';
        else if (percentage >= 40) return 'E';
        else return 'R';
    }
}

//9. The marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and grade
using System;
class StudentGrades
{
    static void Main(string[] args)
    {
        // Take input for the number of students
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks of students in physics, chemistry, and maths
        double[,] marks = new double[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        // Take input for marks of students in physics, chemistry, and maths
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("Enter the marks of student "+(i + 1)+" in Physics:");
            marks[i, 0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of student "+(i + 1)+" in Chemistry:");
            marks[i, 1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of student "+(i + 1)+" in Maths:");
            marks[i, 2] = double.Parse(Console.ReadLine());

            // Validate input for negative values
            if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
            {
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--; // Decrement the index to re-enter the values
                continue;
            }

            // Calculate the percentage
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

            // Determine the grade
            if (percentages[i] >= 90)
            {
                grades[i] = "A";
            }
            else if (percentages[i] >= 80)
            {
                grades[i] = "B";
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = "C";
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = "D";
            }
            else
            {
                grades[i] = "F";
            }
        }

        // Display the marks, percentages, and grades of each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("Student "+(i + 1));
            Console.WriteLine("Physics: "+marks[i, 0]);
            Console.WriteLine("Chemistry: "+marks[i, 1]);
            Console.WriteLine("Maths: "+marks[i, 2]);
            Console.WriteLine("Percentage: "+percentages[i]);
            Console.WriteLine("Grade: "+grades[i]);
            Console.WriteLine();
        }
    }
}

//10.  A number as input find the frequency of each digit in the number
using System;
class DigitFrequency
{
    static void Main(string[] args)
    {
        // Take the input for a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Find the count of digits in the number
        int count = number.ToString().Length;

        // Find the digits in the number and save them in an array
        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        // Define a frequency array of size 10
        int[] frequency = new int[10];

        // Loop through the digits array and increase the frequency of each digit
        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++;
        }

        // Display the frequency of each digit
        Console.WriteLine("Frequency of each digit:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit "+i+": "+frequency[i]+" times");
            }
        }
    }
}
*/