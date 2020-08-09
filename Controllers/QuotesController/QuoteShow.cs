using type_test.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace type_test.Controllers {
    public static class QuoteShow {
        public static string showQuote(List<QuoteResponse> quoteList) {
            QuoteResponse quote = QuoteGenerate.QuotePickRand(quoteList);
            Console.WriteLine(quote.Text);
            return quote.Text;
        }
    }
}