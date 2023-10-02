namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            string userInput = Console.ReadLine();

            //math TU() = MATH

            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("You really like numbers, nice!");
                    break;
                case "science":
                    Console.WriteLine("Hope you didn't have Mr. White's class...");
                    break;
                case "art":
                    Console.WriteLine("Do you like any art by Vincent Van Gogh?");
                    break;
                case "history":
                    Console.WriteLine("Did you make the mustashes in the books? Yeah it was you.");
                    break;
                case "gym":
                    Console.WriteLine("So you know the fitness gram pacer test video by heart then huh?");
                    break;
                default:
                    Console.WriteLine("Haven't had that subject before.");
                    break;
            }
        }
    }
}