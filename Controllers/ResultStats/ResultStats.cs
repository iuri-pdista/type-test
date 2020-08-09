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
            try{
                List<decimal> listOfResults = this.GetResults();
                Console.WriteLine($"The quote had: {this.quoteSize} words\nand you typed correctly: {this.numberOfRightWords}");
                Console.WriteLine($"Therefore your accuracy was: {listOfResults[0]}%");
                // cronometer Console.WriteLine($"Your total-time was: {listOfResults[1]}");
            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }
        }

        private List<decimal> GetResults () {
            try{
                List<decimal> resultsList = new List<decimal>();
                // todo fix accuracy bug
                decimal accuracy = this.GetAccuracy(this.numberOfRightWords, this.quoteSize);
                resultsList.Add(accuracy);
                // todo implement logic to calculate time
                return resultsList;
            }
            catch(Exception ex){
                Console.WriteLine(ex);
                return null;
            }
        }

        private decimal GetAccuracy(int totalRightWords, int sizeQuote){
            decimal accuracy = (totalRightWords / quoteSize) * 100;
            return accuracy;
        }
    }
}