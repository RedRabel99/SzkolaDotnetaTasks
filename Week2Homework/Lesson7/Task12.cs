namespace Week2Homework.Lesson7;

public class Task12
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter a weekday in numerical form");
        if (!Int32.TryParse(Console.ReadLine(), out int weekday) ||
            (weekday < 1 || weekday > 7))
        {
            Console.WriteLine("Given value is not a valid weekday");
            return;
        }
        switch (weekday)
        {
            case 7:
                Console.WriteLine("Sunday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            default:
                Console.WriteLine("Monday");
                break;
        }
    }
}