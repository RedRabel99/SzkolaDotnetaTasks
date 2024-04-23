namespace Week2Homework.Lesson7;

public class Task4
{
    public static void SolveTask()
    {
        int year;
        Console.WriteLine("Enter a year");
        // TODO: Adjust previous input parsing instances to fit the style below 
        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Given value is not a valid year.");
            return;
        }

        if (year < 0)
        {
            Console.WriteLine("Year cant be negative.");
            return;
        }
        bool isLeapYear = (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);

        if (isLeapYear)
        {
            Console.WriteLine("Given year is a leap year.");
        }
        else
        {
            Console.WriteLine("Given year is not a leap year.");
        }
    }
}