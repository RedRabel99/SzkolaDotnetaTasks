namespace Week2Homework.Lesson8;

public class Task10
{
    static int GCD(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        

        return a;
    }

    static int LCM(int a, int b)
    {
        return a * b / GCD(a, b);
    }
    public static void SolveTask()
    {
        Console.WriteLine("Enter two numbers to find LCM");
        if (!Int32.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Given value is invalid");
            return;
        }
        if (!Int32.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Given value is invalid");
            return;
        }
        Console.WriteLine(LCM(a, b));
    }
}