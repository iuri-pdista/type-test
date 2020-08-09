using  System;
using type_test.Models;

namespace type_test.Controllers{
    public static class TypeChallenge{
        public static void RecordTry (string quote) {
            var splitQuote = quote.Split(" ");
            int quoteLength = splitQuote.Length;
            string userTry = Console.ReadLine().ToString();
            var userTrySplit = userTry.Split(" ");
            int userTryLength = userTrySplit.Length;
            int count = ProccessTry(splitQuote, userTrySplit);
            bool isUserCorrect = IsUserCorrect(count, quoteLength);
            TypeChallengeModel.SetNewTry(quote, userTry, isUserCorrect);
            ResultStats results = new ResultStats(quoteLength, count);
            results.ShowResults();
        }
        private static int ProccessTry (string[] splitQuote, string[] userTrySplit) {
            int count = 0;
            for (int i = 0; i < splitQuote.Length; i++){
                if (splitQuote[i] == userTrySplit[i]){
                    count += 1;
                }
            }
            return count;
        }

        private static bool IsUserCorrect(int count, int splitQuoteLength){
            if ( (count >= (splitQuoteLength)/2) && (count <= splitQuoteLength) ) {
                Console.WriteLine("Congrats you nailed");
                return true;
            }
            else{
                Console.WriteLine( "You failed, need more training" );
                return false;
            }
        }
    }
}