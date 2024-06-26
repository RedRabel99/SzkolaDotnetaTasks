namespace Week2Homework.Lesson7;

public class Task8
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter scores");
        Console.Write("Math ");
        if (!Int32.TryParse(Console.ReadLine(), out int mathScore))
        {
            Console.WriteLine("Given value is invalid score");
        }
        
        Console.Write("Physics ");
        if (!Int32.TryParse(Console.ReadLine(), out int physicsScore))
        {
            Console.WriteLine("Given value is invalid score");
        }
        
        Console.Write("Chemistry ");
        if (!Int32.TryParse(Console.ReadLine(), out int chemistryScore))
        {
            Console.WriteLine("Given value is invalid score");
        }

        var sumScore = mathScore + physicsScore + chemistryScore;
        if ((mathScore > 70 && physicsScore > 55 && chemistryScore > 45 && sumScore > 180)
            || (mathScore + physicsScore > 150 || mathScore + chemistryScore > 150))
        {
            Console.WriteLine("Candidate admitted to recruitment");
        }
        else
        {
            Console.WriteLine("Candidate not admitted to recruitment");
        }
    }
}