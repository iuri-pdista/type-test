using type_test.Models;
using System;
using System.Threading.Tasks;

namespace type_test.Controllers {
    public static class QuoteShow {
        public static async Task<string> showQuote() {
            var quoteList = await QuoteGenerate.QuoteListGenerator();
            QuoteResponse quote = QuoteGenerate.QuotePickRand(quoteList);
            Console.WriteLine(quote.Text);
            return quote.Text;
        } 
    }
}