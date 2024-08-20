namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Excercise1();
            School();
        }

        static void Excercise1()
        {
            int favNumber = 12;
            Console.WriteLine("Whats your favorite number?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed correct!!");
            }
            else if (userInput > favNumber)

            {
                Console.WriteLine("you're getting cold!Number too high!");
            }

            else
            {
                Console.WriteLine("Your guess is still below my number hahaha");
            }



        }

        public static void School()
        {
            Console.WriteLine("What is your favorite subject?");
            string favoriteSubject = Console.ReadLine().ToLower();

            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Math is the best subject in the world!");
                    break;

                case "history":
                    Console.WriteLine("History is awesome!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}

