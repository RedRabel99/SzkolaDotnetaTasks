namespace Week2Homework.Lesson4;

public class Task3
{
    public static void SolveTask()
    {
        double a;
        double b;
        string input;
        
        Console.WriteLine("Enter height of a rectangle:");
        input = Console.ReadLine();
        bool aIsValid = Double.TryParse(input, out a);
        
        Console.WriteLine("Enter width of a rectangle:");
        input = Console.ReadLine();
        bool bIsValid = Double.TryParse(input, out b);
        
        if (aIsValid && bIsValid)
        {
            double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Diagonal of given rectangle is: {result}");
        }
        else
        {
            Console.WriteLine("You entered invalid input.");
        }
    }
}