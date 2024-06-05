using System.Linq.Expressions;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 1000); // Generates a random number between 1 and 999
            GuessingGame(favNumber);
            SchoolSubject();
        }

        private static void GuessingGame (int target)
        {
            Console.WriteLine("Guess my favorite number between 1 and 1000:");
            var guess = int.Parse(Console.ReadLine());
            if (guess == target)
            {
                Console.WriteLine("You guessed it!!!");
            } else if (guess > target)
            {
                Console.WriteLine("Too high");
            } else {
                Console.WriteLine("Too low");
            }
        }

        private static void SchoolSubject()
        {
            Console.WriteLine("Between math, physics, english, history, and art - which is your favorite?");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "math":
                    Console.WriteLine("Math is my favorite subject too!");
                    break;
                case "physics":
                    Console.WriteLine("How I too strive to have a mind like Einstein");
                    break;
                case "english":
                    Console.WriteLine("Articulation may be society's most powerful tool.");
                    break;
                case "history":
                    Console.WriteLine("Oof. Not my forte personally. But thank you for being the potential hero that keeps history from repeating itself.");
                    break;
                case "art":
                    Console.WriteLine("Let's see you draw me like one of your \"french girls\" HAHA titanic was something");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    string response = Console.ReadLine().ToLower();
                    Console.WriteLine($"Well I am happy you told me that {response} is your favorite class.");
                    break;
            }
        }
    }
}
