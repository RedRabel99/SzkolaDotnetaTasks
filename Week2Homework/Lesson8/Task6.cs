namespace Week2Homework.Lesson8;

public class Task6
{
    public static void SolveTask()
    {
        double sum = 0.0;
        for (int i = 1; i <= 20; i++)
        {
            sum += 1.0 / i;
        }
        Console.WriteLine(sum);
    }
}