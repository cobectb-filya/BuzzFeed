using System;
using System.Text;

namespace BuzzFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetBuzzFeed());
            Console.ReadLine();
        }

        private static string GetBuzzFeed()
        {
            var result = new StringBuilder(400);
            for (int i = 1; i <= 100; i++)
            {
                if(i%3==0)
                {
                    result.Append("Fizz ");
                }
                else if(i%5==0)
                {
                    result.Append("Buzz ");
                }
                else if(i%15==0)
                {
                    result.Append("FizzBuzz ");
                }
                else
                {
                    result.Append($"{i} ");
                }
            }

            return result.ToString();
        }
    }
}
