using Newtonsoft.Json;

namespace type_test.Models{
    public class QuoteResponse {
        [JsonProperty("text")] public string Text;
        [JsonProperty("author")] public string Author;
    }
}