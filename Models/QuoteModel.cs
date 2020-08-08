using Newtonsoft.Json;

namespace type_test.Models{
    public class CepResponse {
        [JsonProperty("text")] public string Text;
        [JsonProperty("author")] public string Author;
    }
}