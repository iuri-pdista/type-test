using System.Collections.Generic;

namespace type_test.Models {
    public class TypeChallengeModel{
        public TypeChallengeModel(string quote, string userTry, bool isUserCorrect){
            quotes.Add(quote);
            userTryList.Add(userTry);
            numberOfRightAttempts.Add(isUserCorrect);
        }        
        public static List<string> quotes;
        public static List<string> userTryList;
        public static List<bool> numberOfRightAttempts;
    }
}