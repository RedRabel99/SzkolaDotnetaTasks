namespace Week2Homework.Lesson7;

public class Task2
{
    public static void SolveTask()
    {
        int number;
        Console.WriteLine("Enter a number");
        bool isNumber = int.TryParse(Console.ReadLine(), out number);

        if (!isNumber)
        {
            Console.WriteLine("Given value is not a valid number ");
            return;
        }

        Console.WriteLine(number % 2 == 0 ? $"{number} is even." : $"{number} is odd.");
    }
}