using System;
using System.ComponentModel.DataAnnotations;
using SilentAuction.Core.Concrete;

namespace SilentAuction.Core.Entities
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DonorId { get; set; }

        [Required]
        public int AuctionId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(5000)]
        public string Description { get; set; }

        [Required]
        public int Qty { get; set; }

        [MaxLength(5000)]
        public string Notes { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        //public Auction Auction
        //{
        //    get { return new AdoAuctionRepository().GetAuction(AuctionId); }
        //}

        public Donor Donor
        {
            get { return new AdoDonorRepository().GetDonor(DonorId); }
        }
    }
}
