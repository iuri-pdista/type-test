using  System;
using type_test.Models;

namespace type_test.Controllers{
    public static class TypeChallenge{
        public static void RecordTry (string quote) {
            var splitQuote = quote.Split(" ");
            int quoteLength = splitQuote.Length;
            string userTry = Console.ReadLine().ToString();
            int userTryLength = userTry.Length;
            var userTrySplit = userTry.Split(" ");
            bool isUserCorrect = ProccessTry(splitQuote, userTrySplit);
            TypeChallengeModel newTry = new TypeChallengeModel(quote, userTry, isUserCorrect);
            ResultStats results = new ResultStats(quoteLength, userTryLength);
            results.ShowResults();
        }
        private static bool ProccessTry (string[] splitQuote, string[] userTrySplit) {
            decimal count = 0;
            foreach ( string quoteWords in splitQuote ) {
                foreach ( string userTryWords in userTrySplit ){
                    if ( quoteWords == userTryWords ){
                        count += 1;
                    }
                }
            }
            if ( count >= (splitQuote.Length)/2 ) {
                Console.WriteLine("Congrats you nailed");
                return true;
            }
            else{
                Console.WriteLine("You failed, need more training");
                return false;
            }
        }
    }
}