using System;
using System.Collections.Generic;

namespace SilentAuction.Utilities
{
    public enum BidIncrementType { IncrementValue = 1, NumberOfBids }

    public class BidCalculator
    {
        #region Public Methods
        /// <summary>
        /// Calculates a list of bids.  NOTE: Currently rounds off to next whole number for bids.
        /// </summary>
        /// <param name="bidIncrementType">Calculated based on Number of Bids or Increment Value</param>
        /// <param name="minValue">Minimum Bid Value</param>
        /// <param name="maxValue">Maximum Bid Value</param>
        /// <param name="incrementValue">Increment Value</param>
        /// <param name="numberOfBids">Number of Bids</param>
        /// <returns>List of Bid Amounts</returns>
        public List<decimal> GetBidList(BidIncrementType bidIncrementType, decimal minValue, decimal maxValue,
            decimal incrementValue, int numberOfBids)
        {
            if (bidIncrementType == BidIncrementType.IncrementValue && incrementValue <= 0)
                throw new Exception("Invalid Increment Value");
            if (bidIncrementType == BidIncrementType.NumberOfBids && numberOfBids <= 0)
                throw new Exception("Invalid Number of Bids");
            if (minValue < 0)
                throw new Exception("Invalid Minimum Value");
            if (maxValue <= minValue)
                throw new Exception("Invalid Maximum Value");

            List<decimal> bidList = new List<decimal>();


            int numberOfLines = bidIncrementType == BidIncrementType.NumberOfBids ? 
                numberOfBids : CalculateNumberOfLines(minValue, maxValue, incrementValue);

            decimal amountPerLine = bidIncrementType == BidIncrementType.IncrementValue ? 
                incrementValue : CalculateAmountPerLine(minValue, maxValue, numberOfLines);

            for (int i = 0; i < numberOfLines; i++)
            {
                decimal lineAmount = Math.Ceiling(minValue + (amountPerLine * i));
                bidList.Add(lineAmount);
            }

            return bidList;
        }

        /// <summary>
        /// Determines the number of lines needed
        /// </summary>
        /// <param name="minValue">The minimum or starting value</param>
        /// <param name="maxValue">The maximum or ending value</param>
        /// <param name="incrementValue">The amount to increment each time</param>
        /// <returns>The number of lines needed</returns>
        public int CalculateNumberOfLines(decimal minValue, decimal maxValue, decimal incrementValue)
        {
            int numberOfLines = 1;
            if (incrementValue > 0)
            {
                numberOfLines = (int) Math.Ceiling(((maxValue - minValue)/incrementValue) + 1);
            }
            return numberOfLines > 0 ? numberOfLines : 1;
        }

        /// <summary>
        /// Determines the amount per line
        /// </summary>
        /// <param name="minValue">The minimum or starting value</param>
        /// <param name="maxValue">The maximum or ending value</param>
        /// <param name="numberOfLines">The number of lines to calculate for</param>
        /// <returns>The amount per line (exact)</returns>
        public decimal CalculateAmountPerLine(decimal minValue, decimal maxValue, int numberOfLines)
        {
            numberOfLines = numberOfLines > 1 ? numberOfLines - 1 : 1;

            decimal amountPerLine = (maxValue - minValue)/numberOfLines;

            return amountPerLine;
        }
        
        #endregion
    }
}
