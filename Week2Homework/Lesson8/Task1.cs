namespace Week2Homework.Lesson8;

public class Task1
{
    static bool IsPrimal(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    public static void SolveTask()
    {
        for (int i = 2; i <= 100; i++)
        {
            if (IsPrimal(i)) Console.Write($"{i} ");
        }
    }
}