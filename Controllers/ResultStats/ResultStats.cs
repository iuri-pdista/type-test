using System.Collections.Generic;
using System;

namespace type_test.Controllers {
    public class ResultStats{
        public ResultStats (int QuoteSize, int NumberOfRightWords){
            this.quoteSize = QuoteSize;
            this.numberOfRightWords = NumberOfRightWords;
        }
        
        int quoteSize;
        int numberOfRightWords;
        
        // todo implement cronometer
        
        public void ShowResults (){
            List<decimal> listOfResults = GetResults();
            Console.WriteLine($"Your accuracy was: {listOfResults[0]}");
            // cronometer Console.WriteLine($"Your total-time was: {listOfResults[1]}");
        }

        private List<decimal> GetResults () {
            List<decimal> resultsList = null;
            decimal accuracy = GetAccuracy(this.numberOfRightWords, this.quoteSize);
            resultsList.Add(accuracy);
            // todo implement logic to calculate time
            return resultsList;
        }

        private decimal GetAccuracy(int totalRightWords, int sizeQuote){
            decimal accuracy = (totalRightWords / quoteSize) * 100;
            return accuracy;
        }
    }
}