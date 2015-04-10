using System;
using System.Collections.Generic;

namespace SilentAuction.Utilities
{
    public enum BidIncrementType { IncrementValue = 1, IncrementNumber }

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
            List<decimal> bidList = new List<decimal>();

            int numberOfLines = bidIncrementType == BidIncrementType.IncrementNumber ? 
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
        #endregion

        #region Private Methods
        private decimal CalculateAmountPerLine(decimal minValue, decimal maxValue, int numberOfLines)
        {
            numberOfLines = numberOfLines > 1 ? numberOfLines - 1 : 1;

            decimal amountPerLine = (maxValue - minValue)/numberOfLines;

            return amountPerLine;
        }
        
        private int CalculateNumberOfLines(decimal minValue, decimal maxValue, decimal incrementValue)
        {
            int numberOfLines = 1;
            if (incrementValue > 0)
            {
                numberOfLines = (int) Math.Ceiling(((maxValue - minValue)/incrementValue) + 1);
            }
            return numberOfLines > 0 ? numberOfLines : 1;
        }
        #endregion
    }
}
