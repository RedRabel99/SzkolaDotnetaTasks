namespace Week2Homework.Lesson7;

public class Task9
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter the temperature(in Celcius)");

        if (!Double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Given value is not valid temperature");
            return;
        }

        switch (temperature)
        {
            case < 0.0:
                Console.WriteLine("It's damn freezing!");
                break;
            case < 10.0:
                Console.WriteLine("It's cold");
                break;
            case < 20.0:
                Console.WriteLine("It's cool");
                break;
            case < 30.0:
                Console.WriteLine("It's fine");
                break;
            case < 40.0:
                Console.WriteLine("It's getting bad, because it's hot");
                break;
            default:
                Console.WriteLine("Come on, I'm moving to Alaska...");
                break;
        }
    }
}