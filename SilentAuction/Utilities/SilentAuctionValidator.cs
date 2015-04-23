using System;
using System.Linq;
using SilentAuction.SilentAuctionDataSetTableAdapters;

namespace SilentAuction.Utilities
{
    public class SilentAuctionValidator
    {
        public static bool ValidateAuctionId(int auctionId, ref string errorMsg)
        {
            if (auctionId > 0) return true;
            errorMsg = "Auction is required";
            return false;
        }

        public static bool ValidateDonorId(int? donorId, ref string errorMsg)
        {
            if(donorId != null && (donorId > 0)) return true;
            errorMsg = "Donor is required";
            return false;
        }

        public static bool ValidateDonorName(string donorName, ref string errorMsg)
        {
            if (new DonorsTableAdapter().GetDonorsData().Any(d => d.Name == donorName)) return true;
            errorMsg = "Donor Name is required";
            return false;
        }

        public static bool ValidateItemName(string itemName, ref string errorMsg)
        {
            if (!string.IsNullOrEmpty(itemName)) return true;
            errorMsg = "Item Name required";
            return false;
        }

        public static bool ValidateQty(int qty, ref string errorMsg)
        {
            if (qty > 0) return true;
            errorMsg = "Quantity must be greater than zero";
            return false;
        }

        public static bool ValidateRetailValue(decimal retailValue, ref string errorMsg)
        {
            if (retailValue >= 0) return true;
            errorMsg = "Retail Value must be greater than or equal to zero";
            return false;
        }

        public static bool ValidateMinimumBid(decimal minBid, ref string errorMsg)
        {
            if (minBid >= 0) return true;
            errorMsg = "Minimum Bid must be greater than or equal to zero";
            return false;
        }

        public static bool ValidateMaximumBid(decimal maxBid, ref string errorMsg)
        {
            if (maxBid >= 0) return true;
            errorMsg = "Maximum Bid must be greater than or equal to zero";
            return false;
        }

        public static bool ValidateMaximumBidGreaterThanMinimumBid(decimal minBid, decimal maxBid, ref string errorMsg)
        {
            if (maxBid > minBid) return true;
            errorMsg = "Maximum Bid must be greater than the Minimum Bid";
            return false;
        }

        public static bool ValidateBuyItNow(decimal buyItNowValue, ref string errorMsg)
        {
            if (buyItNowValue > 0) return true;
            errorMsg = "Buy It Now value must be greater than zero";
            return false;
        }

        public static bool ValidateNumberOfBids(int numberOfBids, ref string errorMsg)
        {
            if (numberOfBids <= 0)
            {
                errorMsg = "Number of Bids must be greater than zero";
                return false;
            }

            if (numberOfBids <= Constants.MaxNumberOfLines) return true;
            errorMsg = string.Format("Number of Bids must be less than or equal to {0}", Constants.MaxNumberOfLines);
            return false;
        }

        public static bool ValidateBidIncrementValue(decimal minBid, decimal maxBid, decimal incrementValue, ref string errorMsg)
        {
            BidCalculator calculator = new BidCalculator();

            if (incrementValue <= 0)
            {
                errorMsg = "Bid Increment value must be greater than zero";
                return false;
            }

            if (!ValidateMaximumBidGreaterThanMinimumBid(minBid, maxBid, ref errorMsg)) return false;
            int numberOfBids = calculator.CalculateNumberOfLines(minBid, maxBid, incrementValue);
            if (numberOfBids <= Constants.MaxNumberOfLines) return true;
            incrementValue = calculator.CalculateAmountPerLine(minBid, maxBid, Constants.MaxNumberOfLines);
            errorMsg = string.Format("Bid Increment value too small. The number of bids must calculate to {0} or less. Using the maximum number of lines, this calculates to approximately {1}\n",
                Constants.MaxNumberOfLines, Math.Ceiling(incrementValue).ToString("C0"));
            return false;
        }
    }
}
