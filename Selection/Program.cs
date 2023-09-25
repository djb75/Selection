using System.Reflection.Metadata.Ecma335;

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
            Reflex,
            Incorrect
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

            if (angle > 90 && angle < 180)
            {
                return AngleTypes.Obtuse;
            }

            if (angle == 180)
            {
                return AngleTypes.Straight;
            }

            if (angle > 180)
            {
                return AngleTypes.Reflex;
            }

            else
            {
                return AngleTypes.Incorrect;
            }
        }

        static void rockPaperScissors()
        {
            Console.WriteLine("Enter rock, paper or scissors");
            string? userPlay = Console.ReadLine();
            while (userPlay == null)
            {
                Console.WriteLine("No input entered");
                Console.WriteLine("Enter rock, paper or scissors");
                userPlay = Console.ReadLine();
            }
            Random rnd = new Random();
            int computerPlayInt = rnd.Next(0, 2);
            string computerPlay = "";
            switch(computerPlayInt)
            {
                case 0:
                    computerPlay = "Rock";
                    break;
                case 1:
                    computerPlay = "Paper";
                    break;
                case 2:
                    computerPlay = "Scissors";
                    break;
            }
            Console.WriteLine($"User plays: {userPlay}");
            Console.WriteLine($"Computer plays: {computerPlay}");
            bool playerWin = false;

            if (userPlay == "rock" && computerPlay == "scissors")
            {
                playerWin = true;
            }

            if (userPlay == "scissors" && computerPlay == "paper")
            {
                playerWin = true;
            }

            if (userPlay == "paper" && computerPlay == "rock")
            {
                playerWin = true;
            }

            switch(playerWin)
            {
                case true:
                    Console.WriteLine("Player wins");
                    break;

                case false:
                    Console.WriteLine("Computer wins");
                    break;
            }
        }

        static string triangleType (double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }

            if (side1 != side2 && side2 != side3)
            {
                return "Scalene";
            }

            else
            {
                return "Isosceles";
            }
        }
}