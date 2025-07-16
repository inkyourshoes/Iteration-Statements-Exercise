namespace IterationStatements
{
     public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void UpbyThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static void TwoNumbersSame(int numOne, int numTwo)
        {
            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} and {numTwo} are equal.");
            }
            else
            {
                Console.WriteLine($"{numOne} and {numTwo} are not equal.");
            }
        }
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static void IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine("Enter your age: ");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            // Add braces around the while loop for clarity
            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age.");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"You can vote because you're {userAge}.");
            }
            else
            {
                Console.WriteLine($"You can't vote because you're {userAge}.");
            }
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        public static void TenRange()
        {
            Console.WriteLine("Enter a number: ");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            while (!canParse)
            {
                Console.WriteLine("Please enter a valid number.");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine("The number is within the range.");
            }
            else
            {
                Console.WriteLine("The number is not within the range.");
            }
        }
        //    - Returns true if the number is within the range, false otherwise.
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.

        public static void MultiplyThroughTwelve(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            // UpbyThrees();
            //TwoNumbersSame(numOne:1,numTwo:2);
            // EvenOrOdd(number:3);
            //IsPositive(number:2);
            //CanVote();
           // TenRange();
           MultiplyThroughTwelve(number:3);
        }
        

    } // <-- Missing closing brace for the Program class was added here
}

//public class numTwo

