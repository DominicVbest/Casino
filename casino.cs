using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, welcome to my online casino!");
            Console.Clear();
            Pengiums();
 
        }
 
 
        static void Pengiums()
        {
            Random rnd = new Random();
 

            bool Forward = true;
            string[] map = { "P", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
            int Position = 0;
 
            Console.Write("Do you want to play? "); char Playing = Convert.ToChar(Console.ReadLine().ToUpper());
 
            while (Playing == 'Y')
            {
                Position = Position + 1;
                PengiumsProbability(Position, Forward);
 
 
                Forward = PengiumsProbability(Position, Forward);
 
                if (Forward == true)
                {
                    map[Position - 1] = "-";
                    map[Position] = "P";
 
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(string.Join(" ", map));
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------------");

 
                    Console.Write("Do you want to go forward? "); Playing = Convert.ToChar(Console.ReadLine().ToUpper());
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have failed!");
                    Console.WriteLine($"You made it to positon {Position = Position - 1}");
                    Playing = 'N';
                }
            }
        }
 
 
 
        static bool PengiumsProbability(int position, bool forwardAllowed)
        {
            Random rnd = new Random();
            int probability = rnd.Next(1, 101);
 
            if (probability < 95 && position == 1) { forwardAllowed = true; return (forwardAllowed); }
            if (probability < 87 && position == 2) { forwardAllowed = true; return (forwardAllowed); }
            if (probability < 78 && position == 3) { forwardAllowed = true; return (forwardAllowed); } 
            if (probability < 69 && position == 4) { forwardAllowed = true; return (forwardAllowed); } 
            if (probability < 58 && position == 5) { forwardAllowed = true; return (forwardAllowed); }
            if (probability < 48 && position == 6) { forwardAllowed = true; return (forwardAllowed); }
            if (probability < 32 && position == 7) { forwardAllowed = true; return (forwardAllowed); } 
            if (probability < 28 && position == 8) { forwardAllowed = true; return (forwardAllowed); }
            if (probability < 13 && position == 9) { forwardAllowed = true; return (forwardAllowed); }
            forwardAllowed = false; return (forwardAllowed);
        }
 
 
        static int Points(int points)
        {
 
        }
    }
}
