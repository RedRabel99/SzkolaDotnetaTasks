namespace Week2Homework.Lesson7;

public class Task11
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter your grade in numerical form");
        if (!Int32.TryParse(Console.ReadLine(), out int grade) ||
            (grade < 1 || grade > 6))
        {
            Console.WriteLine("Given value is not a valid grade");
            return;
        }
        switch (grade)
        {
            case 6:
                Console.WriteLine("Celujący");
                break;
            case 5:
                Console.WriteLine("Bardzo dobry");
                break;
            case 4:
                Console.WriteLine("Dobry");
                break;
            case 3:
                Console.WriteLine("Dostateczny");
                break;
            case 2:
                Console.WriteLine("Dopuszczający");
                break;
            default:
                Console.WriteLine("Niedostateczny");
                break;
        }
    }
}