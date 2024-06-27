namespace Week2Homework.Lesson8;

public class Task3
{
    private static void LoopFibonacci(int n)
    {
        if (n >= 1) Console.Write("0");
        if (n >= 2) Console.Write(" 1");
        
        var fib = new[] { 0, 1 };
        for (int i = 2; i < n; i++)
        {
            var newElement = fib[0] + fib[1];
            Console.Write($" {newElement}");
            fib[0] = fib[1];
            fib[1] = newElement;
        }
    }
    
    public static void SolveTask()
    {
        Console.WriteLine("Enter the length of Fibonacci sequence:");
        if (!Int32.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Given value is invalid length");
        }
        else
        {
            LoopFibonacci(n);
        }
    }
}