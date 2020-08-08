using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using type_test.Models;

namespace type_test.Controllers {
    public interface IQuoteController {
        [Get("/api/quotes")]
        Task<List<QuoteResponse>> GetQuoteListAsync();
    }
}