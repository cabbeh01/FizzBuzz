using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör så att programmet körs konstant
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hur många tal vill du gå igenom?");

                //Försöker parsa och om det fungerar returneras resultatet till res-variabeln
                if(int.TryParse(Console.ReadLine(),out int res))
                {

                    //Körkoden för FizzBuzz där ett antal matas in
                    Run(res);
                }
            }
        }

        /// <summary>
        /// Koden som beräknar Fizz Buzz beroende på hur stort tal som matas in i AMOUNT
        /// </summary>
        /// <param name="amount">Antal som fizzbuzz ska köras på</param>
        static void Run(int amount)
        {
            Console.WriteLine("____________________________________________ \n");
            for(int i = 1; i<amount+1; i++)
            {
                //Är det delbart med både 5 och 3
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                //Endast delbart med 5
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                //Endast delbart med 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.Read();
        }
    }
}
