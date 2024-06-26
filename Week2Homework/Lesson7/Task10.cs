namespace Week2Homework.Lesson7;

public class Task10
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter three numbers");
        var numbers = new int[3];

        for (int i = 0; i < 3; i++)
        {
            if (!Int32.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Given value is not valid number");
                return;
            }
        }

        if (numbers[0] + numbers[1] > numbers[2] &&
            numbers[1] + numbers[2] > numbers[0] &&
            numbers[0] + numbers[2] > numbers[1])
        {
            Console.WriteLine("Given lengths can form a triangle");
        }
        else
        {
            Console.WriteLine("Given lengths can not form a triangle");
        }
    }
}