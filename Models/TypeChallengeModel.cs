using System.Collections.Generic;

namespace type_test.Models {
    public static class TypeChallengeModel{
        public static void SetNewTry(string quote, string userTry, bool isUserCorrect){
            quotes.Add(quote);
            userTryList.Add(userTry);
            numberOfRightAttempts.Add(isUserCorrect);
        }
        public static List<string> quotes = new List<string>();
        public static List<string> userTryList = new List<string>();
        public static List<bool> numberOfRightAttempts = new List<bool>();
    }
}