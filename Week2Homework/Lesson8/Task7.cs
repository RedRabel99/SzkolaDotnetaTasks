namespace Week2Homework.Lesson8;

public class Task7
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter a number");
        if (!Int32.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Given value is invalid number");
            return;
        }
        
        var middle = n % 2 == 0 ? n / 2 : n / 2 + 1; // in case the value is even, its getting shortened by 1 to ensure the diamon matches the template
        for (int i = 1; i <= middle; i++)
        {
            for (int j = 0; j < middle - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i * 2 - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = middle - 1; i >= 1; i--)
        {
            for (int j = 0; j < middle - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i * 2 - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}