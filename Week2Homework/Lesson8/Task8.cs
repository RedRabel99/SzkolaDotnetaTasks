namespace Week2Homework.Lesson8;

public class Task8
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter a string");
        var input = Console.ReadLine();
        if (input == null) return;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
    }
}