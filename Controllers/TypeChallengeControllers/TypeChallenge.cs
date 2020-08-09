using  System;
using type_test.Models;

namespace type_test.Controllers{
    public static class TypeChallenge{
        public static DateTime RecordTry (string quote) {
            DateTime end = new DateTime();
            end = DateTime.Now;
            var splitQuote = quote.Split(" ");
            int quoteLength = splitQuote.Length;
            string userTry = Console.ReadLine().ToString();
            var userTrySplit = userTry.Split(" ");
            int userTryLength = userTrySplit.Length;
            bool isUserCorrect = ProccessTry(splitQuote, userTrySplit);
            TypeChallengeModel.SetNewTry(quote, userTry, isUserCorrect);
            ResultStats results = new ResultStats(quoteLength, userTryLength);
            results.ShowResults();
            return end;
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