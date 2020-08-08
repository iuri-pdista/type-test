using System;
using System.Threading.Tasks;
using Refit;
using type_test.Controllers;

namespace type_test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try {
                var quote = RestService.For<IQuoteController>("https://type.fit");
                var quoteAddress = await quote.GetQuoteAsync();
                Console.WriteLine($"Autor: {quoteAddress[1].Text} \nFrase: {quoteAddress[1].Author}");
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
