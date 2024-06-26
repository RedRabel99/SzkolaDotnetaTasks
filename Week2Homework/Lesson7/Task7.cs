namespace Week2Homework.Lesson7;

public class Task7
{
    static Double GetMax(double firstNumber, double secondNumber)
    {
        return firstNumber > secondNumber ? firstNumber : secondNumber;
    }
    
    public static void SolveTask()
    {
        Console.WriteLine("Enter three numbers");
        double[] numbers = new double[3];
        for (int i = 0; i < 3; i++)
        {
            if (!Double.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Given value is not valid number");
                return;
            }
        }

        var biggestNumber = GetMax(GetMax(numbers[0], numbers[1]), numbers[2]);
        Console.WriteLine($"{biggestNumber} is the biggest number");
    }
}