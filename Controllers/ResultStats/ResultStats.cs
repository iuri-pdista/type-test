using System.Collections.Generic;
using System;

namespace type_test.Controllers {
    public class ResultStats{
        public ResultStats (double QuoteSize, double NumberOfRightWords){
            this.quoteSize = QuoteSize;
            this.numberOfRightWords = NumberOfRightWords;
        }
        public ResultStats (){ }
        double quoteSize;
        double numberOfRightWords;
        TimeSpan totalElapsedTime;
        
        // todo implement cronometer
        
        public void ShowResults (){            
            List<double> listOfResults = this.GetResults();
            Console.WriteLine($"The quote had: {this.quoteSize} words\nAnd you typed correctly: {this.numberOfRightWords}");
            Console.WriteLine($"Therefore your accuracy was: {String.Format("{0:0.00}",listOfResults[0])}%");
        }

        private List<double> GetResults () {
            List<double> resultsList = new List<double>();
            double accuracy = this.GetAccuracy(this.numberOfRightWords, this.quoteSize);
            resultsList.Add(accuracy);
            return resultsList;
        }

        private double GetAccuracy(double totalRightWords, double sizeQuote){
            Console.WriteLine(totalRightWords + quoteSize);
            return ((totalRightWords / quoteSize)*100);
        }

        public void GetTotalTime (DateTime start) {
            DateTime end =  new DateTime();
            end =  DateTime.Now;
            this.totalElapsedTime = end.Subtract(start);
            Console.WriteLine($"Your total-time was: {this.totalElapsedTime}");
        }
    }
}