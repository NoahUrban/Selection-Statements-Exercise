namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNum = 31;

            Console.WriteLine("Guess what my favorite number is!\n" +
                "Hint: it is between 0 and 100");

            Console.WriteLine();

            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (userInput > favNum)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput < favNum)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Correct!");
            }

        }
    }
}
