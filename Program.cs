using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using type_test.Controllers;
using type_test.Models;

namespace type_test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Clear();
            List<QuoteResponse> quoteList = await QuoteGenerate.QuoteListGenerator();
            string apiQuote = QuoteShow.showQuote(quoteList);
            TypeChallenge.RecordTry(apiQuote);
        }
    }
}
