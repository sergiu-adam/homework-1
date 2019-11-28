using System;

namespace GuesTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int r = rng.Next(0, 100);
            Console.WriteLine();
            NumberToGuess(r);
        }

        private static void NumberToGuess(int randomNumber)
        {
            int tries = 0;
            try 
            {
                Console.WriteLine("Enter your number:");
                int guess = Convert.ToInt32(Console.ReadLine());
                tries++;
                while (guess != randomNumber)
                {
                    tries++;
                    if (guess > randomNumber) 
                    {
                        Console.WriteLine("you number is to high");
                        guess = Convert.ToInt32(Console.ReadLine());

                    }
                    else if(randomNumber > guess)
                    {
                        Console.WriteLine("your number is to small");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine("Congrats it took you {0}  trials ", tries);
            }






        }









    }
}
