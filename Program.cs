using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using type_test.Controllers;
using type_test.Models;

namespace type_test
{
    class Program
    {
        static async Task Main() {
            Console.Clear();
            List<QuoteResponse> quoteList = await QuoteGenerate.QuoteListGenerator();
            DateTime start = new DateTime();
            string apiQuote = QuoteShow.showQuote(quoteList);
            start = DateTime.Now;
            TypeChallenge.RecordTry(apiQuote);
            ResultStats totalTime =  new ResultStats();
            totalTime.GetTotalTime(start);
        }
    }
}
