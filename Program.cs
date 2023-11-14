using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicExceptionHandling();
            MultipleExceptionTypes();
            FinalyBlockUsage();
            CustomExceptionClass();
            ExceptionPropagation();
            UsingThrowAndCatch();
        }

        static void BasicExceptionHandling()
        {
            Console.Write("Enter a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("all is ok");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            // TODO:
            // Convert the input to an integer using int.Parse().
            // Use a try-catch block to handle FormatException if the user enters a non-numeric value.
            // Display an error message in case of an exception.
            // Output the input if correct
        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("all is ok");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Include a catch block for OverflowException to handle cases where the number is too large or small for an int.
            // Display appropriate error messages for different exceptions.
        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("all is ok");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("program completed its work");
            }
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Add a finally block to the program.
            // Use the finally block to display a message whether an exception was caught or not.
        }

        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    // Throw NegativeNumberException if the user enters a negative number.
                    throw new NegativeNumberException("Negative numbers are not allowed.");
                }
                Console.WriteLine("all is ok");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Modify your number input program to throw NegativeNumberException if the user enters a negative number.
            // Handle this exception in a separate catch block and display an appropriate message.
        }

        static void ExceptionPropagation()
        {
            Console.Write("Enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckNumber(number);
                Console.WriteLine("all is ok");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
        }

        static void CheckNumber(int number)
        {
            if (number > 100)
            {

                throw new ArgumentOutOfRangeException("number should be lower than 100.");
            }
        }

        // TODO:
        // Implement BasicExceptionHandling code with following modification
        // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
        // In this function, call CheckNumber inside a try block and handle the exception.


        // NOTE: You can implement the CheckNumber here

        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckNumberWithLogging(number);
                Console.WriteLine("all is ok");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }

            
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // Modify the CheckNumberWithLogging function to log the exception message before throwing it.
            // In this function, catch the exception in the main program and display the logged message.
        }

        // NOTE: You can implement the CheckNumberWithLogging here
        static void CheckNumberWithLogging(int number)
        {
            if (number > 100)
            {
                Console.WriteLine($"number {number} is greater than 100.");
                throw new ArgumentOutOfRangeException("Number should be lower than 100.");
            }
        }
    }
}