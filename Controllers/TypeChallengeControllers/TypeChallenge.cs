using  System;
using type_test.Models;
using type_test;

namespace type_test.Controllers{
    public static class TypeChallenge{
        public static void RecordTry (string quote) {
            var splitQuote = quote.Split(" ");
            int quoteLength = splitQuote.Length;
            string userTry = ProcessTry(quote);
            var userTrySplit = userTry.Split(" ");
            int userTryLength = userTrySplit.Length;
            bool isUserCorrect = IsUserCorrect(quoteLength, splitQuote, userTrySplit);
            TypeChallengeModel.SetNewTry(quote, userTry, isUserCorrect);
            // ResultStats results = new ResultStats(quoteLength, count);
            // results.ShowResults();
        }
        private static int CompareTry (string[] splitQuote, string[] userTrySplit) {
            int count = 0;
            for (int i = 0; i < splitQuote.Length; i++){
                if (splitQuote[i] == userTrySplit[i]){
                    count += 1;
                }
            }
            return count;
        }

        private static bool IsUserCorrect(int splitQuoteLength, string[] quoteSplit, string[] splitUserTry){
            int count = CompareTry(quoteSplit, splitUserTry);
            if ( (count >= (splitQuoteLength)/2) && (count <= splitQuoteLength) ) {
                Console.WriteLine("Congrats you nailed");
                return true;
            }
            else{
                Console.WriteLine( "You failed, need more training" );
                return false;
            }
        }

        private static string ProcessTry (string quote) {
            string userTry = Console.ReadLine().ToString();
            if (userTry.Length < quote.Length){
                Console.WriteLine("You failed! Need more training! Let's try again");
                Environment.Exit(0);
                return " ";
            }
            else{
                return userTry;
            }
        }
    }
}