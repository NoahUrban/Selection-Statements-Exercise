namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int returnValue = rnd.Next(1, 11);
            bool Guess = false;

            Console.WriteLine("Guess what my favorite number is!\n" +
                "Hint: it is between 0 and 10");

            Console.WriteLine();

            int userInput = 0;

            Console.WriteLine();

            while (!Guess)
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput > returnValue)
                {
                    Console.WriteLine("Too High");
                    Console.WriteLine();
                }
                else if (userInput < returnValue)
                {
                    Console.WriteLine("Too Low");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Correct!");
                    Guess = true;
                }
            }
        }
    }
}
