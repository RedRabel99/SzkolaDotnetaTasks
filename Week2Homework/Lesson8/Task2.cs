namespace Week2Homework.Lesson8;

public class Task2
{
    public static void SolveTask()
    {
        var i = 0;
        do
        {
            if (i % 2 == 0) Console.Write($"{i} ");
            i++;
        } while (i <= 1000);
    }
}