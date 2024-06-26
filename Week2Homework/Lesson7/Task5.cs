namespace Week2Homework.Lesson7;

public class Task5
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter your age");
        if (!Int32.TryParse(Console.ReadLine(), out int age) || age <=0)
        {
            Console.WriteLine("Given value is not a valid age");
            return;
        }

        if (age < 21)
        {
            Console.WriteLine("You are too young.");
            return;
        }

        string result = "You can become Member of Parliament, Prime Minister";
        if (age >= 30) result += ", Senator";
        if (age >= 35) result += ", President";
        
        Console.WriteLine(result);
    }
}