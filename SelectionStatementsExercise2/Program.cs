namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject");
            var userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "science":
                    Console.WriteLine("Science is very interesting to learn");
                    break;

                case "math":
                    Console.WriteLine("Math is expanding throughout the world");
                    break;
                case "reading":
                    Console.WriteLine("Reading is very fundamental");
                    break;
                case "economics":
                    Console.WriteLine("Economics is the highest paid major");
                    break;
                case "english":
                    Console.WriteLine("English is very a enjoyable subject to learn");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break; 
            }
        }

    }
}
