using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_randomly_generated_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing challange!");
            Console.WriteLine("Note: It's between 0 and 100");
            Random rndm = new Random();
            int random_number = rndm.Next(0,100);
            int guess   = 101;
            int counter = 1;
            while(guess != random_number)
            {
                Console.WriteLine("Please enter the your guess:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess>random_number)
                {
                    Console.WriteLine("Lower your guess. Keep Guessing!");
                    counter++;
                }
                else if(guess<random_number)
                {
                    Console.WriteLine("Upper your guess. Keep Guessing!");
                    counter++;
                }
                else if(guess==random_number && counter>1)
                {
                    Console.WriteLine("Congratulations. You got it in {0} tries.", counter);       
                }
            }

            if (counter == 1)
            {
                Console.WriteLine("OMG! You got it in {0} try.", counter);
            }
            
            Console.ReadKey();
        }
    }
}
