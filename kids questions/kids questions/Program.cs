using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kids_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.Write("How old are you?: ");
            int old = int.Parse(Console.ReadLine());
            Console.Write("Would you like a PS5?: ");
            string ps5 = Console.ReadLine();

            Console.Write("Are you happy?: ");
            string happy = Console.ReadLine();
            Console.Write("Are you wearing a grey tshirt?: ");
            string tshirt = Console.ReadLine();

            Console.Write("Are you wearing blue pants with yellow stripes on side?: ");
            string pants = Console.ReadLine();
            Console.WriteLine("Do you have blue eyes?: ");
            string blue = Console.ReadLine();
            Console.Write("Do you know i love you?: ");
            string love = Console.ReadLine();


            Console.WriteLine("Name: {0}\nAGE: {1}\nPS5: {2}\nHappy: {3}\ntshirt: {4}\npants {5}\nlove: {6}\nBlue: {7}", name, old, ps5, happy, tshirt, pants, love, blue);
            Console.ReadLine();



        }
    }
}
