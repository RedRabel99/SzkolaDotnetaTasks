namespace Week2Homework.Lesson8;

public class Task4
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter a positive number:");
        if (!Int32.TryParse(Console.ReadLine(), out int number) || number < 1)
        {
            Console.WriteLine("Given value is invalid");
            return;
        }

        var currentRowLength = 0;
        var maxRowLength = 1;
        for (int i = 0; i < number; i++)
        {
            Console.Write(i+1);
            currentRowLength++;
            if (currentRowLength == maxRowLength)
            {
                Console.WriteLine();
                currentRowLength = 0;
                maxRowLength++;
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}