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
            string[] map = { "P", "-", "-", "-", "-", "-", "-", "-", "-", "-"};
            int Position = 0;

            while (Forward == true)
            {
                if (Next == true)
                {
                    map[Position] = "-";
                    Position = Position + 1;
                    map[Position] = "P";

                    Console.WriteLine(string.Join(" ", map));
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
