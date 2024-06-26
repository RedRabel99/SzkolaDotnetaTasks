namespace Week2Homework.Lesson7;

public class Task6
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter your height(in cm)");
        if (!Int32.TryParse(Console.ReadLine(), out int height) || height <=0)
        {
            Console.WriteLine("Given value is not a valid height");
            return;
        }

        if (height < 100)
        {
            Console.WriteLine("You are a gnome");
            return;
        }

        if (height < 150)
        {
            Console.WriteLine("You are a dwarf");
            return;
        }

        if (height < 180)
        {
            Console.WriteLine("You are a human");
            return;
        }

        if (height < 200)
        {
            Console.WriteLine("You are a high elf");
            return;
        }
        Console.WriteLine("You are a giant");
    }
}