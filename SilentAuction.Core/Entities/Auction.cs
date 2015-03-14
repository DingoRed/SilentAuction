using System;
using System.ComponentModel.DataAnnotations;

namespace SilentAuction.Core.Entities
{
    public class Auction
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(5000)]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
