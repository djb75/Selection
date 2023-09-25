namespace Selection
{
    internal class Program
    {
        enum AngleTypes
        {
            Acute,
            Right,
            Obtuse,
            Straight,
            Reflex
        }
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

        static bool vowelOrConsonant(char letter)
        {
            letter = char.ToLower(letter);
            switch(letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;    //Break; not needed because of return statement
                default:
                    return false;
            }
        }

        static string threeDice()
        {
            Random rnd = new Random();
            int die1 = rnd.Next(1, 6);
            int die2 = rnd.Next(1, 6);
            int die3 = rnd.Next(1, 6);
            if (die1 == die2 && die2 == die3)
            {
                return "Three of a kind";
            }
            if (die1 == die2 || die2 == die3 || die1 == die3)
            {
                return "You have a pair!";
            }
            else
            {
                return "Sorry, you lose";
            }
        }

        static AngleTypes angleSize(int angle)
        {
            if (angle < 90)
            {
                return AngleTypes.Acute;
            }

            if (angle == 90)
            {
                return AngleTypes.Right;
            }

            if (angle > 90)
                {

                }
        }
    }
}