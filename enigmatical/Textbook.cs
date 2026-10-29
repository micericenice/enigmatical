namespace enigmatical;

public class Textbook
{
    public static void Run()
    {
        string name = "Enrico";
        char letter = 'a';
        
        Console.WriteLine(name);
        Console.WriteLine(letter);
        Console.WriteLine("Textbook.cs is running!");

        string name2 = "Bob";
        Console.WriteLine(name2);
        Console.WriteLine("Hi, my name is " + name2);
        
        Console.Write("Your name is ");
        Console.Write(name);
        Console.WriteLine();
        Console.WriteLine(letter);
        
        Console.ReadLine();
    }
}