namespace Topic__1___Printing_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("My Name Is Owen Austin");
            Console.WriteLine("What is your name?");
            Console.WriteLine("");
            string? a = Console.ReadLine();
            Console.WriteLine("Hello " + a + ", nice to meet you!");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("what is your favorite food " + a + "?");
            Console.WriteLine("");
            string? b = Console.ReadLine();
            Console.WriteLine("You like " + b + "?");
            Console.WriteLine("Sounds Great!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();



        }
    }
}
