using System;
using System.Threading.Tasks;
using type_test.Controllers;

namespace type_test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Clear();
            string apiQuote = await QuoteShow.showQuote();
            int quoteLength = apiQuote.Length;
            var splitQuote = apiQuote.Split(" ");
            string userTry = Console.ReadLine().ToString();
            int userTryLength = userTry.Length;
            var userTrySplit = userTry.Split(" ");
            int count = 0;
            foreach( string quoteWords in splitQuote ) {
                foreach( string userTryWords in userTrySplit ){
                    if( quoteWords == userTryWords ){
                        count += 1;
                    }
                }
            }
            Console.WriteLine($"{count} {quoteLength}");

            if (count == quoteLength) Console.WriteLine("Congrats you nailed"); 
            
            else Console.WriteLine("You failed, need more training"); 
        }
    }
}
