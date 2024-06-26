namespace Week2Homework.Lesson7;

public class Task13
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter the first number");
        if (!Double.TryParse(Console.ReadLine(), out double firstNumber))
        {
            Console.WriteLine("Given value is not a valid number");
            return;
        }
        Console.WriteLine("Enter the second number");
        if (!Double.TryParse(Console.ReadLine(), out double secondNumber))
        {
            Console.WriteLine("Given value is not a valid number");
            return;
        }
        Console.WriteLine("Enter the number of the operation to perform:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        if (!Int32.TryParse(Console.ReadLine(), out int operation))
        {
            Console.WriteLine("Given value is not a valid number");
        }

        double result;
        switch (operation)
        {
            case 1:
                result = firstNumber + secondNumber;
                break;
            case 2:
                result = firstNumber - secondNumber;
                break;
            case 3:
                result = firstNumber * secondNumber;
                break;
            case 4:
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("This number is not on the list");
                return;
        }
        Console.WriteLine($"The result is {result}");
    }
}