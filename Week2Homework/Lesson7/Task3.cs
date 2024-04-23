namespace Week2Homework.Lesson7;

public class Task3
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

        if (number > 0)
        {
            Console.WriteLine($"{number} is a positive number.");
        }else if (number < 0)
        {
            Console.WriteLine($"{number} is a negative number.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }
}