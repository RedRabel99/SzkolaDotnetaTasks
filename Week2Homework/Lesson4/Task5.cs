namespace Week2Homework.Lesson4;

public class Task5
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter an email address:");
        string emailAddress = Console.ReadLine();

        Console.WriteLine("Enter a phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Enter age:");
        byte age;
        Byte.TryParse(Console.ReadLine(), out age);

        Console.WriteLine("Enter height(in centimeters):");
        byte height;
        Byte.TryParse(Console.ReadLine(), out height);

        Console.WriteLine("Enter weight(in kilograms):");
        double weight;
        Double.TryParse(Console.ReadLine(), out weight);

        Console.WriteLine("Enter PESEL number");
        string pesel = Console.ReadLine();

        Console.WriteLine("Enter sex:\n1. Male\n2.Female\n3.Other");
        Task1.Gender sex;
        Enum.TryParse(Console.ReadLine(), out sex);
    }
}