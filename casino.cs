using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, welcome to my online casino!");

            Pengiums();

        }


        static void Pengiums()
        {
            Random rnd = new Random();
            bool Next = true;
            bool Forward = true;
            string[] map = { "P", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
            int Position = 0;

            Console.Write("Do you want to play?"); char Playing = Convert.ToChar(Console.ReadLine().ToUpper());

           while(Playing == 'Y')
            {
                PengiumsProbability(Position, Forward);
                Forward = PengiumsProbability(Position + 1, Forward);

                if (Forward == true)
                {
                    if (Next == true)
                    {
                        map[Position] = "-";
                        Position = Position + 1;
                        map[Position] = "P";
                        Console.WriteLine(string.Join(" ", map));

                        Console.Write("Do you want to play again?"); Playing = Convert.ToChar(Console.ReadLine().ToUpper());
                    }
                    else
                    {
                        Console.WriteLine("You have failed!");
                    }
                }
            }
        }





        static bool PengiumsProbability(int position, bool forwardAllowed)
        {
            Random rnd = new Random();
            int probability = rnd.Next(1, 101);
            switch ((probability, position))
            {
                case ( < 100, 1): // Position 1: 90% chance
                case ( < 100, 2): // Position 2: 85% chance
                case ( < 80, 3): // Position 3: 80% chance
                case ( < 74, 4): // Position 4: 74% chance
                case ( < 64, 5): // Position 5: 64% chance
                case ( < 53, 6): // Position 6: 53% chance
                case ( < 43, 7): // Position 7: 43% chance
                case ( < 34, 8): // Position 8: 34% chance
                case ( < 14, 9): // Position 9: 14% chance
                    forwardAllowed = true;
                    break;
                default:
                    forwardAllowed = false;
                    break;
            }
            return (forwardAllowed);
        }
    }
}
