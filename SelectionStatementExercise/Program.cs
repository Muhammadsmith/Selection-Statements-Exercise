namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Excercise1();
            school();
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
                Console.WriteLine("Guess still below my number hahaha");
            }



        }

        public static void school()
        {
            Console.WriteLine("Whats your favorite subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("Math is the best subject in the world!");
                    break;

                case "History":
                    Console.WriteLine("History is awesome!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}

