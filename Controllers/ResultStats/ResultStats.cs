using System.Collections.Generic;
using System;

namespace type_test.Controllers {
    public class ResultStats{
        public ResultStats (int QuoteSize, int NumberOfRightWords){
            this.quoteSize = QuoteSize;
            this.numberOfRightWords = NumberOfRightWords;
        }
        public ResultStats (){ }
        int quoteSize;
        int numberOfRightWords;
        TimeSpan totalElapsedTime;
        
        // todo implement cronometer
        
        public void ShowResults (){            
            List<decimal> listOfResults = this.GetResults();
            Console.WriteLine($"The quote had: {this.quoteSize} words\nand you typed correctly: {this.numberOfRightWords}");
            Console.WriteLine($"Therefore your accuracy was: {listOfResults[0]}%");
        }

        private List<decimal> GetResults () {
            List<decimal> resultsList = new List<decimal>();
            decimal accuracy = this.GetAccuracy(this.numberOfRightWords, this.quoteSize);
            resultsList.Add(accuracy);
            return resultsList;
        }

        private decimal GetAccuracy(int totalRightWords, int sizeQuote){
            decimal accuracy = (totalRightWords / quoteSize) * 100;
            return accuracy;
        }

        public void GetTotalTime (DateTime start) {
            DateTime end =  new DateTime();
            end =  DateTime.Now;
            this.totalElapsedTime = end.Subtract(start);
            Console.WriteLine($"Your total-time was: {this.totalElapsedTime}");
        }
    }
}