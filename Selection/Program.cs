namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static string FizzBuzz(int val)
        {
            string divisibility = "";
            if (val % 3 == 0)
            {
                divisibility += "Fizz";
            }
            if (val % 5 == 0)
            {
                divisibility += "Buzz";
            }

            return divisibility;
        }

        static 
    }
}