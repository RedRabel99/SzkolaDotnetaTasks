namespace Week2Homework.Lesson8;

public class Task9
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter a positive decimal");
        if (!Int32.TryParse(Console.ReadLine(), out int number) || number < 0)
        {
            Console.WriteLine("Given value is invalid positive decimal");
            return;
        }

        var result = "";
        while (number > 0)
        {
            result = result.Insert(0, number % 2 == 0 ? "0" : "1");
            number /= 2;
        }
        Console.WriteLine(result);
    }
}
