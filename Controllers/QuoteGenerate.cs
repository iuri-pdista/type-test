using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using type_test.Models;

namespace type_test.Controllers {
    public static class QuoteGenerate{
        public static async Task<List<QuoteResponse>> QuoteListGenerator() {
            try {
                var quote = RestService.For<IQuoteController>("https://type.fit");
                var quoteAddress = await quote.GetQuoteListAsync();
                return quoteAddress;
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}